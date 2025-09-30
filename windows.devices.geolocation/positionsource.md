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
The position was obtained from an IP address.

### -field Unknown:4
The position was obtained from an unknown source.

### -field Default:5
The position was obtained from the user's manually-set location.

### -field Obfuscated:6
The position was obtained via the coarse location feature and was therefore intentionally made inaccurate to a degree.

## -remarks

The [PositionSource](positionsource.md) value helps applications understand the characteristics and reliability of location
data. Different sources have different accuracy profiles and power consumption implications.

> [!NOTE]
> The position source reflects the provider currently delivering location data. The system selects a single provider based
> on availability, cost, accuracy, and reliability, and may switch to a different source if conditions change.

### Source characteristics

Different location sources have varying characteristics for accuracy, acquisition time, and power consumption. For detailed
accuracy expectations, see the [Windows.Devices.Geolocation](windows_devices_geolocation.md) namespace overview.

- `Satellite`: Provides the highest accuracy outdoors but requires a clear sky view. Initial acquisition may take 30+
  seconds for a cold start, but it provides the most precise positioning once established.
- `WiFi`: Provides good accuracy in urban areas with dense WiFi networks. It delivers fast acquisition times and works
  well indoors where WiFi access point databases are comprehensive.
- `Cellular`: Offers moderate accuracy depending on cell tower density. It is generally available wherever cellular
  service exists.
- `IPAddress`: Offers broad area accuracy at the city or region level. It provides instant acquisition but limited
  precision, so apps often use it as a fallback or for initial rough positioning.
- `Default`: Represents the user's manually configured location. Accuracy depends entirely on user input and may not
  reflect the current physical location.
- `Obfuscated`: Provides intentionally reduced accuracy to protect privacy. The system uses it when applications
  request coarse location to preserve user privacy while still providing general area information.

### Performance and power considerations

- Satellite positioning provides the highest accuracy but consumes more power and requires more time for initial
  positioning.
- Network-based positioning (WiFi, Cellular, IPAddress) typically offers faster acquisition with lower power
  consumption but variable accuracy.
- The platform chooses one provider at a time and falls back to alternate sources if the current provider can't deliver a
  fix or degrades unexpectedly.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 8.1 | 9600 | IPAddress |
| 8.1 | 9600 | Unknown |
| 1607 | 14393 | Default |
| 1607 | 14393 | Obfuscated |

## -examples

## -see-also

[Geocoordinate](geocoordinate.md),
[Geolocator](geolocator.md)

## -capabilities
location
