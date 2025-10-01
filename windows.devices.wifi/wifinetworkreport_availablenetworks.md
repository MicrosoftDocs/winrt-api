---
-api-id: P:Windows.Devices.WiFi.WiFiNetworkReport.AvailableNetworks
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.WiFi.WiFiAvailableNetwork> AvailableNetworks { get; }
-->

# Windows.Devices.WiFi.WiFiNetworkReport.AvailableNetworks

## -description

> [!IMPORTANT]
> Location consent is now required for Wi-Fi BSSID access. For details on how this affects apps using Wi-Fi or location APIs,
> see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

A list of available networks.

## -property-value
A read-only collection of [WiFiAvailableNetwork](/uwp/api/windows.devices.wifi.wifiavailablenetwork) objects, representing the containing a list of available networks.

## -remarks

This list will not show any [On-Demand Hotspot networks](/uwp/api/windows.devices.wifi.wifiondemandhotspotnetwork). Those networks are only exposed in the Windows UI. 

## -examples

## -see-also
