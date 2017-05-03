---
-api-id: T:Windows.Devices.WiFiDirect.WiFiDirectConnectionRequestedEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class WiFiDirectConnectionRequestedEventArgs : Windows.Devices.WiFiDirect.IWiFiDirectConnectionRequestedEventArgs
-->

# Windows.Devices.WiFiDirect.WiFiDirectConnectionRequestedEventArgs

## -description
Provides data for a [ConnectionRequested](wifidirectconnectionlistener_connectionrequested.md) event on a [WiFiDirectConnectionListener](wifidirectconnectionlistener.md).

## -remarks
Your code doesn't instantiate this class. Instead, a [WiFiDirectConnectionRequestedEventArgs](wifidirectconnectionrequestedeventargs.md) instance is created when the when the [ConnectionRequested](wifidirectconnectionlistener_connectionrequested.md) event occurs on a [WiFiDirectConnectionListener](wifidirectconnectionlistener.md).

Not all [WiFiDirectDevice](wifidirectdevice.md) properties are exposed on [ConnectionRequested](wifidirectconnectionlistener_connectionrequested.md) event by a [WiFiDirectConnectionListener](wifidirectconnectionlistener.md). Properties that are exposed include the following:
+ Device Friendly Name
+ Device Category
+ Model ID
+ Information elements


## -examples

## -see-also
[WiFiDirectConnectionListener](wifidirectconnectionlistener.md), [WiFiDirectConnectionListener.ConnectionRequested](wifidirectconnectionlistener_connectionrequested.md)