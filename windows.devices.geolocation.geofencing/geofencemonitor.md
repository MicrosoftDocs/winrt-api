---
-api-id: T:Windows.Devices.Geolocation.Geofencing.GeofenceMonitor
-api-type: winrt class
---

<!-- Class syntax.
public class GeofenceMonitor : Windows.Devices.Geolocation.Geofencing.IGeofenceMonitor
-->

# Windows.Devices.Geolocation.Geofencing.GeofenceMonitor

## -description
Contains the information about the monitored [Geofence](geofence.md) objects.

## -remarks
Use the static [Current](geofencemonitor_current.md) property to get the `GeofenceMonitor` object which contains all of an app's geofence information.

### Key properties and methods
- [Geofences](geofencemonitor_geofences.md): Collection to register and manage geofences for monitoring
- [ReadReports](geofencemonitor_readreports_231406138.md): Retrieves state change reports since the last read
- [GeofenceStateChanged](geofencemonitor_geofencestatechanged.md): Event fired when geofence states change
- [Status](geofencemonitor_status.md): Current operational status of the monitor

### Background task integration
The `GeofenceMonitor` class is commonly used in background tasks to handle geofence events when the app is not running. Background tasks should call [ReadReports](geofencemonitor_readreports_231406138.md) to process accumulated state changes and clear the report queue.

> [!IMPORTANT]
> Applications must handle [UnauthorizedAccessException](/dotnet/api/system.unauthorizedaccessexception) when accessing GeofenceMonitor if location permissions are disabled. Check location access before registering geofences or reading reports.

## -examples

### Processing geofence state changes in a background task

```csharp
public sealed class GeofenceBackgroundTask : IBackgroundTask
{
    public void Run(IBackgroundTaskInstance taskInstance)
    {
        var deferral = taskInstance.GetDeferral();

        try
        {
            ProcessGeofenceStateChangedReports();
        }
        catch (UnauthorizedAccessException)
        {
            // Location permissions disabled - handle gracefully
            // App-specific: log error and notify user when app resumes
        }
        finally
        {
            deferral.Complete();
        }
    }

    private void ProcessGeofenceStateChangedReports()
    {
        var monitor = GeofenceMonitor.Current;
        var reports = monitor.ReadReports();

        foreach (var report in reports)
        {
            var geofenceId = report.Geofence.Id;
            var timestamp = report.Geoposition.Coordinate.Timestamp;

            // Handle different state changes
            switch (report.NewState)
            {
                case GeofenceState.Entered:
                    // App-specific: log entry, trigger notifications, start tracking
                    HandleGeofenceEntered(geofenceId, timestamp);
                    break;

                case GeofenceState.Exited:
                    // App-specific: log exit, stop location tracking, update analytics
                    HandleGeofenceExited(geofenceId, timestamp);
                    break;

                case GeofenceState.Removed:
                    // Handle automatic removal (expired or single-use)
                    var reason = report.RemovalReason;
                    if (reason == GeofenceRemovalReason.Expired)
                    {
                        // App-specific: re-register if needed, update UI
                        HandleGeofenceExpired(geofenceId);
                    }
                    else if (reason == GeofenceRemovalReason.Used)
                    {
                        // App-specific: process single-use completion
                        HandleGeofenceUsed(geofenceId);
                    }
                    break;
            }
        }

        // App-specific: persist state changes, update tile notifications
        if (reports.Count > 0)
        {
            SaveReportSummary(reports);
        }
    }
}
```

### Registering geofences and handling events in foreground

```cpp
winrt::fire_and_forget SetupGeofenceMonitoring()
{
    using namespace winrt::Windows::Devices::Geolocation;
    using namespace winrt::Windows::Devices::Geolocation::Geofencing;

    auto monitor = GeofenceMonitor::Current();

    // Check permission before proceeding
    auto accessStatus = co_await Geolocator::RequestAccessAsync();
    if (accessStatus != GeolocationAccessStatus::Allowed)
    {
        // App-specific: show permission dialog or disable geofencing features
        co_return;
    }

    // Register for state change events with C++/WinRT event handling
    monitor.GeofenceStateChanged({ this, &MainPage::OnGeofenceStateChanged });
    monitor.StatusChanged({ this, &MainPage::OnGeofenceMonitorStatusChanged });

    // Create and register a geofence
    BasicGeoposition position{};
    position.Latitude = 47.6062;
    position.Longitude = -122.3321;

    auto geocircle = Geocircle(position, 100.0); // 100 meter radius
    auto geofence = Geofence(L"home-location", geocircle);

    monitor.Geofences().Append(geofence);
}

void OnGeofenceStateChanged(GeofenceMonitor const& sender,
                           winrt::Windows::Foundation::IInspectable const&)
{
    // Process real-time state changes (app is running)
    auto reports = sender.ReadReports();
    for (auto const& report : reports)
    {
        // App-specific: update UI, show notifications
        UpdateLocationStatus(report.Geofence().Id(), report.NewState());
    }
}
```

## -see-also
[Geofence](geofence.md),
[GeofenceState](geofencestate.md),
[GeofenceStateChangeReport](geofencestatechangereport.md),
[Geolocation sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/Geolocation),
[Windows.Devices.Geolocation](../windows.devices.geolocation/windows_devices_geolocation.md)

## -capabilities
location
