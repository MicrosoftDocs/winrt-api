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

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

A list of available networks.

## -property-value
A read-only collection of [WiFiAvailableNetwork](/uwp/api/windows.devices.wifi.wifiavailablenetwork) objects, representing the containing a list of available networks.

## -remarks

This list will not show any [On-Demand Hotspot networks](/uwp/api/windows.devices.wifi.wifiondemandhotspotnetwork). Those networks are only exposed in the Windows UI. 

## -examples

## -see-also
