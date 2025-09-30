---
-api-id: T:Windows.Devices.Geolocation.Geofencing.GeofenceStateChangeReport
-api-type: winrt class
---

<!-- Class syntax.
public class GeofenceStateChangeReport : Windows.Devices.Geolocation.Geofencing.IGeofenceStateChangeReport
-->

# Windows.Devices.Geolocation.Geofencing.GeofenceStateChangeReport

## -description
Contains the information about the state changes for a [Geofence](geofence.md).

## -remarks
Use the [GeofenceMonitor.ReadReports](geofencemonitor_readreports_231406138.md) method to get a collection of GeofenceStateChangeReport objects which contain information about changes in state to a geofence.

### Key properties
- [Geofence](geofencestatechangereport_geofence.md): The geofence that changed state
- [NewState](geofencestatechangereport_newstate.md): Current state (Entered, Exited, or Removed)
- [Geoposition](geofencestatechangereport_geoposition.md): Location information when the state change occurred
- [RemovalReason](geofencestatechangereport_removalreason.md): Why the geofence was removed (if applicable)

### Report lifecycle
State change reports accumulate in the system until consumed by calling [ReadReports](geofencemonitor_readreports_231406138.md). Each call to ReadReports clears the report queue and returns all pending reports since the last read. Reports may contain multiple state changes for the same geofence if events occurred rapidly.

> [!NOTE]
> Reports are available both when the app is running in the foreground (via [GeofenceStateChanged](geofencemonitor_geofencestatechanged.md) events) and when returning from background suspension. Background tasks should always call ReadReports to process accumulated events.

## -examples

### Processing geofence state changes

```csharp
private void ProcessGeofenceReport(GeofenceStateChangeReport report)
{
    switch (report.NewState)
    {
        case GeofenceState.Entered:
            // App-specific: start location-based services, log entry
            HandleGeofenceEntry(report.Geofence.Id, report.Geoposition);
            break;

        case GeofenceState.Exited:
            // App-specific: stop services, calculate dwell time
            HandleGeofenceExit(report.Geofence.Id);
            break;

        case GeofenceState.Removed:
            // Check why the geofence was removed and handle accordingly
            if (report.RemovalReason == GeofenceRemovalReason.Expired)
            {
                // App-specific: recreate geofence if still needed
                HandleExpiredGeofence(report.Geofence.Id);
            }
            else if (report.RemovalReason == GeofenceRemovalReason.Used)
            {
                // App-specific: single-use geofence completed successfully
                HandleCompletedGeofence(report.Geofence.Id);
            }
            break;
    }
}
```

## -see-also
[Geofence](geofence.md),
[GeofenceMonitor](geofencemonitor.md),
[GeofenceRemovalReason](geofenceremovalreason.md),
[GeofenceState](geofencestate.md),
[Geolocation sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/Geolocation)

## -capabilities
location
