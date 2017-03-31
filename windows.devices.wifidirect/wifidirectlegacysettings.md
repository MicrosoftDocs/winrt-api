---
-api-id: T:Windows.Devices.WiFiDirect.WiFiDirectLegacySettings
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class WiFiDirectLegacySettings : Windows.Devices.WiFiDirect.IWiFiDirectLegacySettings
-->

# Windows.Devices.WiFiDirect.WiFiDirectLegacySettings

## -description
Settings governing "legacy" mode (non-Wi-Fi Direct connections to the access point being advertised.)

This access point allows devices that do not support Wi-Fi Direct to connect to a device that does support it, and to use the services offered by the Wi-Fi Direct device. The connection does not serve as a general-purpose Wi-Fi access point.

## -remarks
Your code retrieves instances of this class through the [WiFiDirectAdvertisement.LegacySettings](wifidirectadvertisement_legacysettings.md) property. It does not instantiate the class directly.

The SSID is initially set to a Wi-Fi Direct compatible random string beginning with ""DIRECT-"". Your code can change this value to a different SSID if you choose to do so.

The pass phrase is initialized to a random alphanumeric string. Your code can change this value to a different pass phrase if you choose to do so.

## -examples

## -see-also
