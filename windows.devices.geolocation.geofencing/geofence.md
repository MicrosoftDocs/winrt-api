---
-api-id: T:Windows.Devices.Geolocation.Geofencing.Geofence
-api-type: winrt class
---

<!-- Class syntax.
public class Geofence : Windows.Devices.Geolocation.Geofencing.IGeofence
-->

# Windows.Devices.Geolocation.Geofencing.Geofence

## -description
Contains the functionality to define a geofence (a geographical area of interest) to monitor.

## -remarks

### Creating geofences
Geofences define geographic areas to monitor for device entry and exit events. Each geofence requires:
- **Unique identifier**: Used to distinguish between multiple geofences
- **Geographic shape**: Currently supports circular areas ([Geocircle](../windows.devices.geolocation/geocircle.md))
- **Monitoring states**: Combination of [GeofenceState](geofencestate.md) values (Entered, Exited, Removed)

### Key properties
- [Id](geofence_id.md): Unique identifier for the geofence (up to 64 characters)
- [Geoshape](geofence_geoshape.md): Geographic boundary definition
- [MonitoredStates](geofence_monitoredstates.md): Which state changes to track
- [StartTime](geofence_starttime.md): When monitoring should begin
- [Duration](geofence_duration.md): How long to monitor (0 for indefinite)
- [DwellTime](geofence_dwelltime.md): Minimum time to remain in area before triggering
- [SingleUse](geofence_singleuse.md): Whether to remove after first trigger

### Lifecycle management
Once created, geofences are registered with [GeofenceMonitor.Geofences](geofencemonitor_geofences.md) and persist until:
- Manually removed from the collection
- Automatically removed due to expiration ([Duration](geofence_duration.md) elapsed)
- Automatically removed after single use (if [SingleUse](geofence_singleuse.md) is true)

> [!IMPORTANT]
> Geofences with duplicate [Id](geofence_id.md) values cannot be registered simultaneously. Remove existing geofences
> before adding replacements with the same identifier.

> [!NOTE]
> The system monitors registered geofences continuously, even when the app is suspended. Use background tasks to
> handle geofence events when the app is not running.

> [!NOTE]
> During remote desktop sessions, geofence events may use the remote session's reported location if a geolocation provider
> override is active. Manage overrides with the [GeolocationProvider](../windows.devices.geolocation.provider/geolocationprovider.md) API.

## -examples

This example demonstrates creating and registering basic geofences:

```csharp
using Windows.Devices.Geolocation;
using Windows.Devices.Geolocation.Geofencing;

private Geofence CreateGeofence(string id, double latitude, double longitude, double radiusMeters)
{
    var position = new BasicGeoposition
    {
        Latitude = latitude,
        Longitude = longitude
    };

    var geocircle = new Geocircle(position, radiusMeters);
    var monitoredStates = GeofenceState.Entered | GeofenceState.Exited;

    return new Geofence(id, geocircle, monitoredStates, false);
}

private async Task<bool> RegisterGeofenceAsync(Geofence geofence)
{
    var accessStatus = await Geolocator.RequestAccessAsync();
    if (accessStatus != GeolocationAccessStatus.Allowed)
    {
        return false;
    }

    try
    {
        var monitor = GeofenceMonitor.Current;
        monitor.Geofences.Add(geofence);
        return true;
    }
    catch (Exception)
    {
        // App-specific: handle registration failure
        return false;
    }
}
```

For comprehensive examples including validation, lifecycle management, background monitoring, and advanced patterns,
see the [Geolocation sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/Geolocation).

## -see-also
[Geocircle](../windows.devices.geolocation/geocircle.md),
[GeofenceMonitor](geofencemonitor.md),
[GeofenceState](geofencestate.md),
[Geolocation sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/Geolocation),
[Windows.Devices.Geolocation](windows_devices_geolocation_geofencing.md)

## -capabilities
location
