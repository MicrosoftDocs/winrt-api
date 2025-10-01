---
-api-id: T:Windows.Devices.Geolocation.StatusChangedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class StatusChangedEventArgs : Windows.Devices.Geolocation.IStatusChangedEventArgs
-->

# Windows.Devices.Geolocation.StatusChangedEventArgs

## -description
Provides data for the [StatusChanged](geolocator_statuschanged.md) event.

## -remarks
The [Geolocator](geolocator.md) object triggers the [StatusChanged](geolocator_statuschanged.md) event to indicate that
the user's location settings changed. That event passes the corresponding status via the argument's `Status` property
(of type [PositionStatus](positionstatus.md)). Note that this method is not called from the UI thread and the
[Dispatcher](../windows.ui.core/coredispatcher.md) object invokes the UI changes. For more info, see
[Get current location](/windows/uwp/maps-and-location/get-location).

## -examples

## -see-also
[Geolocator](geolocator.md),
[PositionStatus](positionstatus.md),
[StatusChanged](geolocator_statuschanged.md)

## -capabilities
location
