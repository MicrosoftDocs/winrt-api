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

## -examples

This example shows how to use the [Geolocator](geolocator.md) class to retrieve the device's location. For more info, see [Get current location](http://msdn.microsoft.com/library/24dc9a41-8cc1-48b0-bc6d-24bf571afcc8).

```csharp
using Windows.Devices.Geolocation;
...
var accessStatus = await Geolocator.RequestAccessAsync();
switch (accessStatus)
{
    case GeolocationAccessStatus.Allowed:
        _rootPage.NotifyUser("Waiting for update...", NotifyType.StatusMessage);

        // If DesiredAccuracy or DesiredAccuracyInMeters are not set (or value is 0), DesiredAccuracy.Default is used.
        Geolocator geolocator = new Geolocator { DesiredAccuracyInMeters = _desireAccuracyInMetersValue };

        // Subscribe to StatusChanged event to get updates of location status changes
        _geolocator.StatusChanged += OnStatusChanged;
                        
        // Carry out the operation
        Geoposition pos = await geolocator.GetGeopositionAsync();

        UpdateLocationData(pos);
        _rootPage.NotifyUser("Location updated.", NotifyType.StatusMessage);
        break;

    case GeolocationAccessStatus.Denied:
        _rootPage.NotifyUser("Access to location is denied.", NotifyType.ErrorMessage);
        LocationDisabledMessage.Visibility = Visibility.Visible;
        UpdateLocationData(null);
        break;

    case GeolocationAccessStatus.Unspecified:
        _rootPage.NotifyUser("Unspecified error.", NotifyType.ErrorMessage);
        UpdateLocationData(null);
        break;
}
```

## -see-also

[Get current location](http://msdn.microsoft.com/library/24dc9a41-8cc1-48b0-bc6d-24bf571afcc8), [geolocation sample](http://go.microsoft.com/fwlink/p/?linkid=533278), [Geotag sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620547)

## -capabilities

location
ID_CAP_LOCATION [Windows Phone]
