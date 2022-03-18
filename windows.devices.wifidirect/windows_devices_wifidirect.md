---
-api-id: N:Windows.Devices.WiFiDirect
-api-type: winrt namespace
---

# Windows.Devices.WiFiDirect

## -description

Contains classes that support connecting to associated Wi-Fi Direct devices and associated endpoints for PCs, tablets, and phones.

## -remarks

You can use the [WiFiDirectDevice](wifidirectdevice.md) class to establish a socket connection with other devices that have a Wi-Fi Direct (WFD) capable device. You can call the [GetDeviceSelector](wifidirectdevice_getdeviceselector_185243134.md) method to get the device identifier for a Wi-Fi Direct device. Once you have a reference to a [WiFiDirectDevice](wifidirectdevice.md) on your computer, you can call the [GetConnectionEndpointPairs](wifidirectdevice_getconnectionendpointpairs_1958888015.md) method to get an [EndpointPair](../windows.networking/endpointpair.md) object and establish a socket connection using classes in the [Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md) namespace.

You can add a handler for the [ConnectionStatusChanged](wifidirectdevice_connectionstatuschanged.md) event to be notified when the connection has been established or disconnected.

Only one app can be connected to a Wi-Fi Direct device at a time.

You must enable the **Proximity** capability to communicate with Wi-Fi Direct devices.

## -examples

```csharp
Windows.Devices.WiFiDirect.WiFiDirectDevice wfdDevice;

private async System.Threading.Tasks.Task<String> Connect(string deviceId)
{
    string result = ""; 

    try
    {
        // No device ID specified.
        if (String.IsNullOrEmpty(deviceId)) { return "Please specify a Wi-Fi Direct device ID."; }

        // Connect to the selected Wi-Fi Direct device.
        wfdDevice = await Windows.Devices.WiFiDirect.WiFiDirectDevice.FromIdAsync(deviceId);

        if (wfdDevice == null)
        {
            result = "Connection to " + deviceId + " failed.";
        }

        // Register for connection status change notification.
        wfdDevice.ConnectionStatusChanged += new TypedEventHandler<Windows.Devices.WiFiDirect.WiFiDirectDevice, object>(OnConnectionChanged);

        // Get the EndpointPair information.
        var EndpointPairCollection = wfdDevice.GetConnectionEndpointPairs();

        if (EndpointPairCollection.Count > 0)
        {
            var endpointPair = EndpointPairCollection[0];
            result = "Local IP address " + endpointPair.LocalHostName.ToString() + 
                " connected to remote IP address " + endpointPair.RemoteHostName.ToString();
        }
        else
        {
           result = "Connection to " + deviceId + " failed.";
        }
    }
    catch (Exception err)
    {
        // Handle error.
        result = "Error occurred: " + err.Message;
    }

    return result;
}

private void OnConnectionChanged(object sender, object arg)
{
    Windows.Devices.WiFiDirect.WiFiDirectConnectionStatus status = 
        (Windows.Devices.WiFiDirect.WiFiDirectConnectionStatus)arg;

    if (status == Windows.Devices.WiFiDirect.WiFiDirectConnectionStatus.Connected)
    {
        // Connection successful.
    }
    else
    {
        // Disconnected.
        Disconnect();
    }
}

private void Disconnect()
{
    if (wfdDevice != null) 
    {
        wfdDevice.Dispose(); 
    }
}
```

## -see-also

[WiFiDirectDevice sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/WiFiDirectDevice%20sample), [Wi-Fi Direct sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620626)
