---
-api-id: T:Windows.Devices.Geolocation.Geolocator
-api-type: winrt class
---

<!-- Class syntax.
public class Geolocator : Windows.Devices.Geolocation.IGeolocator, Windows.Devices.Geolocation.IGeolocator2, Windows.Devices.Geolocation.IGeolocatorWithScalarAccuracy
-->

# Windows.Devices.Geolocation.Geolocator

## -description

Provides access to the current geographic location.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | AllowFallbackToConsentlessPositions |
| 1607 | 14393 | DefaultGeoposition |
| 1607 | 14393 | IsDefaultGeopositionRecommended |

## -examples

This example shows how to use the Geolocator class to retrieve the device's location. For more info, see [Get current location](/windows/uwp/maps-and-location/get-location).

```csharp
using Windows.Devices.Geolocation;
...
var accessStatus = await Geolocator.RequestAccessAsync();
switch (accessStatus)
{
    case GeolocationAccessStatus.Allowed:
        // notify user: Waiting for update

        // If DesiredAccuracy or DesiredAccuracyInMeters are not set (or value is 0), DesiredAccuracy.Default is used.
        Geolocator geolocator = new Geolocator { DesiredAccuracyInMeters = _desireAccuracyInMetersValue };

        // Subscribe to StatusChanged event to get updates of location status changes
        _geolocator.StatusChanged += OnStatusChanged;
                        
        // Carry out the operation
        Geoposition pos = await geolocator.GetGeopositionAsync();

        UpdateLocationData(pos);
        // notify user: Location updated
        break;

    case GeolocationAccessStatus.Denied:
        // notify user: Access to location is denied

        break;

    case GeolocationAccessStatus.Unspecified:
        // notify user: Unspecified error
        break;
}
```

## -see-also

[Get current location](/windows/uwp/maps-and-location/get-location), [geolocation sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Geolocation), [Geotag sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620547)

## -capabilities

location
ID_CAP_LOCATION [Windows Phone]
