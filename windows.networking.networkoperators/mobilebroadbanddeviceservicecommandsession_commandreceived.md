---
-api-id: E:Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandSession.CommandReceived
-api-type: winrt event
---

# Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandSession.CommandReceived

<!--
public event Windows.Foundation.TypedEventHandler<Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandSession,Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceCommandEventArgs> CommandReceived;
-->


## -description

Raised when an unsolicited event is received from a mobile broadband device on the [MobileBroadbandDeviceServiceCommandSession](./mobilebroadbanddeviceservicecommandsession.md) object after the session is opened.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks

If you're developing an NT service or a user mode driver that controls mobile broadband devices, then this event allows you to implement a foreground event handler to receive and handle device service notifications.

## -see-also

## -examples

```csharp
using System;
using System.Threading;
using Windows.Foundation;
using Windows.Networking.NetworkOperators;

public class MobileBroadbandDeviceServiceCommandEventSample
{
    private const string sampleServiceId = "abcdefg-1234-abcd-1234-abcd1234abcd";
    private AutoResetEvent dsCommandReceivedEvent = new AutoResetEvent(false);

    public void DeviceServiceCommandSessionCommandReceived()
    {
        var modem = MobileBroadbandModem.GetDefault();
        if (modem == null)
        {
            // Handle the error.
            return;
        }

        MobileBroadbandDeviceService sampleService = modem.GetDeviceService(new Guid(sampleServiceId));
        if (sampleService == null)
        {
            // Handle the error.
            return;
        }

        var commandSession = sampleService.OpenCommandSession();
        commandSession.CommandReceived +=
                    new TypedEventHandler<MobileBroadbandDeviceServiceCommandSession,
                        MobileBroadbandDeviceServiceCommandEventArgs>(this.CommandReceivedHandler);

        bool CommandReceived = dsCommandReceivedEvent.WaitOne(10000);
        if (!CommandReceived)
        {
            // Handle the error.
        }

        commandSession.CommandReceived -= this.CommandReceivedHandler;
    }

    private void CommandReceivedHandler(MobileBroadbandDeviceServiceCommandSession sender,
        MobileBroadbandDeviceServiceCommandEventArgs e)
    {
        if (e != null)
        {
            Console.WriteLine("Received device service event");
            Console.WriteLine("  DeviceId: " + e.DeviceId);
            Console.WriteLine("  DeviceServiceId: " + e.DeviceServiceId);
            Console.WriteLine("  EventId: " + e.EventId);
            Console.WriteLine("  Received data: " + e.ReceivedData);
            dsCommandReceivedEvent.Set();
        }
    }
}
```

## -capabilities
cellularDeviceControl
