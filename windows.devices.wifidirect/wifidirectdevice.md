---
-api-id: T:Windows.Devices.WiFiDirect.WiFiDirectDevice
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class WiFiDirectDevice : Windows.Devices.WiFiDirect.IWiFiDirectDevice, Windows.Foundation.IClosable
-->

# Windows.Devices.WiFiDirect.WiFiDirectDevice

## -description
Manages connections to associated Wi-Fi Direct devices.

## -remarks
You can use the WiFiDirectDevice class to establish a socket connection with other devices that have a Wi-Fi Direct (WFD) capable device. You can call the [GetDeviceSelector](wifidirectdevice_getdeviceselector_185243134.md) method to get the device identifier for a Wi-Fi Direct device. Once you have a reference to a WiFiDirectDevice on your computer, you can call the [GetConnectionEndpointPairs](wifidirectdevice_getconnectionendpointpairs_1958888015.md) method to get an [EndpointPair](../windows.networking/endpointpair.md) object and establish a socket connection using the [Windows.Networking.Sockets](../windows.networking.sockets/windows_networking_sockets.md) API.

You can add a handler for the [ConnectionStatusChanged](wifidirectdevice_connectionstatuschanged.md) event to be notified when the connection has been established or disconnected.

Only one app can be connected to a Wi-Fi Direct device at a time.

You must enable the **Proximity** capability to communicate with Wi-Fi Direct devices.

## -examples


[!code-csharp[2](../windows.devices.wifidirect/code/WiFiDirect_Device/cs/MainPage.xaml.cs#Snippet2)]

## -see-also
[WiFiDirectDevice sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/WiFiDirectDevice%20sample)
