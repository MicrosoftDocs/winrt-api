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
You can access information about the event with the [StatusChangedEventArgs](statuschangedeventargs.md) object that is
passed to your event handler.

When using a geofence, use the
[GeofenceMonitor](../windows.devices.geolocation.geofencing/geofencemonitor.md)'s
[StatusChanged](../windows.devices.geolocation.geofencing/geofencemonitor_statuschanged.md) event to monitor changes in
location permissions instead of this event from the [Geolocator](geolocator.md) class. A
[GeofenceMonitorStatus](../windows.devices.geolocation.geofencing/geofencemonitorstatus.md) of `Disabled` is equivalent
to a `Disabled` [PositionStatus](positionstatus.md), and both indicate that the app does not have permission to access
location.

The [Geolocator](geolocator.md) object triggers the `StatusChanged` event to indicate that the user's location settings
changed. That event passes the corresponding status via the argument's `Status` property (of type
[PositionStatus](positionstatus.md)). Note that this method is not called from the UI thread and the
[Dispatcher](../windows.ui.core/coredispatcher.md) object invokes the UI changes. For more info, see
[Get current location](/windows/uwp/maps-and-location/get-location).

## -examples

## -see-also
[Geolocation sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/Geolocation),
[Get current location](/windows/uwp/maps-and-location/get-location),
[Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence),
[StatusChangedEventArgs](statuschangedeventargs.md)

## -capabilities
location
