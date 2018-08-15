---
-api-id: T:Windows.Devices.WiFi.WiFiAvailableNetwork
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class WiFiAvailableNetwork : Windows.Devices.WiFi.IWiFiAvailableNetwork
-->

# Windows.Devices.WiFi.WiFiAvailableNetwork

## -description
Describes an available Wi-Fi network.

## -remarks
You do not instantiate objects of this class directly. The system creates instances of this object in as part of the process of scanning for networks and raising the [WiFiAdapter.AvailableNetworksChanged](wifiadapter_availablenetworkschanged.md) event. You can initiate a network scan using the [WiFiAdapter.FindAllAdaptersAsync](wifiadapter_findalladaptersasync_130273039.md) static method or the [WiFiAdapter.ScanAsync](wifiadapter_scanasync_1036183308.md) method on a particular adapter. You can also retrieve the list of networks from the results of the most current scan from a given Wi-Fi adapter by getting the [AvailableNetworks](wifinetworkreport_availablenetworks.md) property of the [WiFiAdapter.NetworkReport](wifiadapter_networkreport.md).

## -examples

## -see-also
