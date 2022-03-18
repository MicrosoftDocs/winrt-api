---
-api-id: E:Windows.Devices.Geolocation.Geolocator.StatusChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler StatusChanged<Windows.Devices.Geolocation.Geolocator,  Windows.Devices.Geolocation.StatusChangedEventArgs>
-->

# Windows.Devices.Geolocation.Geolocator.StatusChanged

## -description
Raised when the ability of the [Geolocator](geolocator.md) to provide updated location changes.

## -remarks
You can access information about the event with the [StatusChangedEventArgs](statuschangedeventargs.md) object that is passed to your event handler.

When using a geofence, use the [GeofenceMonitor](../windows.devices.geolocation.geofencing/geofencemonitor.md)'s [StatusChanged](../windows.devices.geolocation.geofencing/geofencemonitor_statuschanged.md) event to monitor changes in location permissions instead of this  event from the [Geolocator](geolocator.md) class. A [GeofenceMonitorStatus](../windows.devices.geolocation.geofencing/geofencemonitorstatus.md) of **Disabled** is equivalent to a **Disabled** [PositionStatus](positionstatus.md) - both indicate that the app does not have permission to access location.

## -examples
This code example demonstrates how the StatusChanged event is handled. The [Geolocator](geolocator.md) object triggers the StatusChanged event to indicate that the user's location settings changed. That event passes the corresponding status via the argument's **Status** property (of type [PositionStatus](positionstatus.md)). Note that this method is not called from the UI thread and the [Dispatcher](../windows.ui.core/coredispatcher.md) object invokes the UI changes. For more info, see [Get current location](/windows/uwp/maps-and-location/get-location).

```csharp

using Windows.UI.Core;
...
async private void OnStatusChanged(Geolocator sender, StatusChangedEventArgs e)
{
    await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
    {
        // Show the location setting message only if status is disabled.
        LocationDisabledMessage.Visibility = Visibility.Collapsed;

        switch (e.Status)
        {
            case PositionStatus.Ready:
                // Location platform is providing valid data.
                // notify user: Location platform is ready
                break;

            case PositionStatus.Initializing:
                // Location platform is attempting to acquire a fix. 
                // notify user: Location platform is attempting to obtain a position
                break;

            case PositionStatus.NoData:
                // Location platform could not obtain location data.
                // notify user: Not able to determine the location
                break;

            case PositionStatus.Disabled:
                // The permission to access location data is denied by the user or other policies.
                // notify user: Access to location is denied

                // Clear cached location data if any
                break;

            case PositionStatus.NotInitialized:
                // The location platform is not initialized. This indicates that the application 
                // has not made a request for location data.

                // notify user: No request for location is made yet
                break;

            case PositionStatus.NotAvailable:
                // The location platform is not available on this version of the OS.

                // notify user: Location is not available on this version of the OS
                break;

            default:
                // unknown result
                break;
        }
    });
}
```



## -see-also
[Get current location](/windows/uwp/maps-and-location/get-location), [Get current location](/windows/uwp/maps-and-location/get-location), [Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence), [StatusChangedEventArgs](statuschangedeventargs.md), [geolocation sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Geolocation)

## -capabilities
location
ID_CAP_LOCATION [Windows Phone]
