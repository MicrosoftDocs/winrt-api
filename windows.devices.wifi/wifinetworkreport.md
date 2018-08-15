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
Contains the result of a network scan operation.

## -remarks
The system creates an instance of this object when a network scan completes successfully and raises a [WiFiAdapter.AvailableNetworksChanged](wifiadapter_availablenetworkschanged.md) event. (You can initiate a network scan using the [WiFiAdapter.FindAllAdaptersAsync](wifiadapter_findalladaptersasync_130273039.md) static method or the [WiFiAdapter.ScanAsync](wifiadapter_scanasync_1036183308.md) method on a particular adapter.) You can also retrieve the results of the most current scan from a given Wi-Fi adapter by getting the [WiFiAdapter.NetworkReport](wifiadapter_networkreport.md) property.

## -examples

## -see-also
