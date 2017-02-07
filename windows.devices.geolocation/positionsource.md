---
-api-id: T:Windows.Devices.Geolocation.PositionSource
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Geolocation.PositionSource : int
-->

# PositionSource

## -description
Indicates the source used to obtain a [Geocoordinate](geocoordinate.md).

## -enum-fields
### -field Cellular:0
The position was obtained from cellular network data.

### -field Satellite:1
The position was obtained from satellite data.

### -field WiFi:2
The position was obtained from Wi-Fi network data.

### -field IPAddress:3
(Starting with Windows 8.1.) The position was obtained from an IP address.

### -field Unknown:4
(Starting with Windows 8.1.) The position was obtained from an unknown source.

### -field Default:5
(Starting with Windows 10, version 1607.) The position was obtained from the user's manually-set location.

### -field Obfuscated:6
(Starting with Windows 10, version 1607.) The position was obtained via the Consentless Location feature and was therefore intentionally made inaccurate to a degree.


## -remarks

## -examples

## -see-also


## -capabilities
ID_CAP_LOCATION [Windows Phone]