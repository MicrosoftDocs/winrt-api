---
-api-id: T:Windows.Devices.WiFi.WiFiNetworkReport
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class WiFiNetworkReport : Windows.Devices.WiFi.IWiFiNetworkReport
-->

# Windows.Devices.WiFi.WiFiNetworkReport

## -description

> [!IMPORTANT]
> Location consent is now required for Wi-Fi BSSID access. For details on how this affects apps using Wi-Fi or location APIs,
> see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Contains the result of a network scan operation.

## -remarks
The system creates an instance of this object when a network scan completes successfully and raises a [WiFiAdapter.AvailableNetworksChanged](wifiadapter_availablenetworkschanged.md) event. (You can initiate a network scan using the [WiFiAdapter.FindAllAdaptersAsync](wifiadapter_findalladaptersasync_130273039.md) static method or the [WiFiAdapter.ScanAsync](wifiadapter_scanasync_1036183308.md) method on a particular adapter.) You can also retrieve the results of the most current scan from a given Wi-Fi adapter by getting the [WiFiAdapter.NetworkReport](wifiadapter_networkreport.md) property.

## -examples

## -see-also
