---
-api-id: N:Windows.Devices.WiFiDirect
-api-type: winrt namespace
---

# Windows.Devices.WiFiDirect

## -description
Contains classes that support connecting to associated Wi-Fi Direct devices and associated endpoints for PCs, tablets, and phones.

## -remarks
You can use the [WiFiDirectDevice](wifidirectdevice.md) class to establish a socket connection with other devices that have a Wi-Fi Direct (WFD) capable device. You can call the [GetDeviceSelector](wifidirectdevice_getdeviceselector.md) method to get the device identifier for a Wi-Fi Direct device. Once you have a reference to a [WiFiDirectDevice](wifidirectdevice.md) on your computer, you can call the [GetConnectionEndpointPairs](wifidirectdevice_getconnectionendpointpairs.md) method to get an [EndpointPair](../windows.networking/endpointpair.md) object and establish a socket connection using classes in the [Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md) namespace.

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
        // No device Id specified.
        if (String.IsNullOrEmpty(deviceId)) { return "Please specify a Wi- Fi Direct device Id."; }

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

```javascript
var wfdDevice;

function connect(deviceId) {
    var result = ""; 

    try
    {
        // No device Id specified.
        if (!deviceId) { return "Please specify a Wi- Fi Direct device Id."; }

        // Connect to the selected Wi-Fi Direct device.
        Windows.Devices.WiFiDirect.WiFiDirectDevice.fromIdAsync(deviceId).then(
            function (wfdDeviceResult) {
                if (!wfdDeviceResult) {
                    result = "Connection to " + deviceId + " failed.";
                }

                wfdDevice = wfdDeviceResult;

                // Register for connection status change notification.
                wfdDevice.onconnectionstatuschanged = onConnectionChanged; 

                // Get the EndpointPair information.
                var endpointPairCollection = wfdDevice.getConnectionEndpointPairs();

                if (endpointPairCollection.Count > 0) {
                    var endpointPair = endpointPairCollection[0];
                    result = "Local IP address " + endpointPair.localHostName.toString() + 
                        " connected to remote IP address " + endpointPair.remoteHostName.toString();
                }
                else {
                    result = "Connection to " + deviceId + " failed.";
                }
            });

    }
    catch (err) {
        // Handle error.
        result = "Error occurred: " + err.message;
    }

    return result;
}

function onConnectionChanged(status) {
    if (status == Windows.Devices.WiFiDirect.WiFiDirectConnectionStatus.connected) {
        // Connection successful.
    }
    else {
        // Disconnected.
       disconnect();
    }
}

function disconnect() {
    if (wfdDevice) {
        wfdDevice.dispose(); 
    }
}

```



## -see-also
[WiFiDirectDevice sample](http://go.microsoft.com/fwlink/p/?LinkID=301419), [Wi-Fi Direct sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620626)