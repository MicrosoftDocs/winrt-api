---
-api-id: T:Windows.Devices.WiFiDirect.WiFiDirectConnectionListener
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class WiFiDirectConnectionListener : Windows.Devices.WiFiDirect.IWiFiDirectConnectionListener
-->

# Windows.Devices.WiFiDirect.WiFiDirectConnectionListener

## -description
Class used to listen for incoming Wi-Fi Direct connection requests.

## -remarks
If multiple apps are listening for [ConnectionRequested](wifidirectconnectionlistener_connectionrequested.md) event notifications, the notifications will be sent to the apps sequentially in last in first out order of when the apps registered the event handler.

This class is similar to the [StreamSocketListener](../windows.networking.sockets/streamsocketlistener.md) class in the [Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md) namespace. When it sees an incoming request of the appropriate kind, it raises a [ConnectionRequested](wifidirectconnectionlistener_connectionrequested.md) event.

## -examples

## -see-also
[StreamSocketListener](../windows.networking.sockets/streamsocketlistener.md)