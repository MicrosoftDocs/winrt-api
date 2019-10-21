---
-api-id: T:Windows.Devices.WiFiDirect.WiFiDirectConnectionRequest
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class WiFiDirectConnectionRequest : Windows.Devices.WiFiDirect.IWiFiDirectConnectionRequest, Windows.Foundation.IClosable
-->

# Windows.Devices.WiFiDirect.WiFiDirectConnectionRequest

## -description
A Wi-Fi Direct connection request received by a [WiFiDirectConnectionListener](wifidirectconnectionlistener.md).

## -remarks
A WiFiDirectConnectionRequest instance is retrieved by the [GetConnectionRequest](wifidirectconnectionrequestedeventargs_getconnectionrequest_2044958184.md) method on the [WiFiDirectConnectionRequestedEventArgs](wifidirectconnectionrequestedeventargs.md) object when the [ConnectionRequested](wifidirectconnectionlistener_connectionrequested.md) event occurs on a [WiFiDirectConnectionListener](wifidirectconnectionlistener.md).

Retrieve information about the requesting device using [DeviceInformation](wifidirectconnectionrequest_deviceinformation.md).

The [Close](wifidirectconnectionrequest_close_811482585.md) method releases all unmanaged resources associated with the WiFiDirectConnectionRequest object.

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [WiFiDirectConnectionRequestedEventArgs](wifidirectconnectionrequestedeventargs.md), [WiFiDirectConnectionRequestedEventArgs.ConnectionRequested](wifidirectconnectionlistener_connectionrequested.md), [WiFiDirectConnectionListener](wifidirectconnectionlistener.md), [WiFiDirectConnectionListener.ConnectionRequested](wifidirectconnectionlistener_connectionrequested.md)
