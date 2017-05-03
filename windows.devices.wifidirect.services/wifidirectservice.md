---
-api-id: T:Windows.Devices.WiFiDirect.Services.WiFiDirectService
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class WiFiDirectService : Windows.Devices.WiFiDirect.Services.IWiFiDirectService
-->

# Windows.Devices.WiFiDirect.Services.WiFiDirectService

## -description
Represents a Wi-Fi Direct service. This class is used by code on a device that seeks to use a Wi-Fi Direct Service, to establish a Wi-Fi Direct Service session with the service provider.

## -remarks
This is one of several classes that support connecting two devices with a preference for which device should be the Group Owner. See the [Windows.Devices.WiFiDirect.Service](windows_devices_wifidirect_services.md) topic for a discussion of device pairing and how it can cause the Group Owner preference to be ignored (and how to fix that.)

Your code does not instantiate this class directly. Instead, your code follows this process to get an instance of this class and use it to establish a Wi-Fi Direct Service session.


1. Use one of the [GetSelector](wifidirectservice_getselector.md) methods to get a query string for a particular service
1. Create a [DeviceWatcher](../windows.devices.enumeration/devicewatcher.md) that watches for Advertisers that match the query string. When an Advertiser is found, decide whether to use that Advertiser, either programmatically or by asking the user to indicate a choice.
1. Once your Seeker has identified the desired service advertiser, call the static [FromIdAsync](wifidirectservice_fromidasync.md) method with the Device ID of the chosen advertiser device. FromIdAsync retrieves an instance of [WiFiDirectService](wifidirectservice.md) for the requested service on the requested device.
1. Proceed to establish a session by calling [WiFiDirectService.ConnectAsync](wifidirectservice_connectasync.md).


## -examples

## -see-also
