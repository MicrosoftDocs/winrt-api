---
-api-id: E:Windows.Devices.HumanInterfaceDevice.HidDevice.InputReportReceived
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler InputReportReceived<Windows.Devices.HumanInterfaceDevice.HidDevice,  Windows.Devices.HumanInterfaceDevice.HidInputReportReceivedEventArgs>
-->

# Windows.Devices.HumanInterfaceDevice.HidDevice.InputReportReceived

## -description

Establishes an event listener to handle input reports issued by the device when either [GetInputReportAsync()](hiddevice_getinputreportasync_2092816092.md) or [GetInputReportAsync(System.UInt16 reportId)](hiddevice_getinputreportasync_294410273.md) is called.

## -remarks

This method waits for the device to interrupt the host when it has data to send. Internally, the HID WinRT API sends a IOCTL read request to a lower driver in the stack.

The IOCTL is translated by the HID minidriver into a protocol-specific request. For a USB device, the minidriver translates this into an INTERRUPT IN request. And, for an I2C device that is running over the Microsoft HID-I2C miniport driver, the minidriver will wait for the device to assert an interrupt.

## -examples

Here, we retrieve an input report (inputReport) and get the content of the report in the handler for the InputReportReceived event,  triggered when the asynchronous call completes.

```csharp
HidInputReport inputReport = await device.GetInputReportAsync();
.
.
.
private void InputReportReceived(
    HidDevice sender, 
    HidInputReportReceivedEventArgs args)
    {
        HidInputReport inputReport = args.Report;
        IBuffer buffer = inputReport.Data;
        DataReader dr = DataReader.FromBuffer(buffer);
        byte[] bytes = new byte[inputReport.Data.Length];
        dr.ReadBytes(bytes);

        String inputReportContent = 
           System.Text.Encoding.ASCII.GetString(bytes);
    }
```

## -see-also

[Custom HID device sample](https://github.com/Microsoft/Windows-universal-samples/tree/6370138b150ca8a34ff86de376ab6408c5587f5d/Samples/CustomHidDeviceAccess)
