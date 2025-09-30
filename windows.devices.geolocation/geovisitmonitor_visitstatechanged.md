---
-api-id: E:Windows.Devices.Geolocation.GeovisitMonitor.VisitStateChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler VisitStateChanged<Windows.Devices.Geolocation.GeovisitMonitor,  Windows.Devices.Geolocation.GeovisitStateChangedEventArgs>
-->

# Windows.Devices.Geolocation.GeovisitMonitor.VisitStateChanged

## -description
Raised when the user's current visit state has changed, provided this [GeovisitMonitor](geovisitmonitor.md) is currently monitoring.

## -remarks
This event is triggered when the system detects that the user has entered or left a significant location. The event provides information about the visit through the [GeovisitStateChangedEventArgs](geovisitstatechangedeventargs.md) parameter.

## -examples

## -see-also
[GeovisitMonitor](geovisitmonitor.md),
[GeovisitStateChangedEventArgs](geovisitstatechangedeventargs.md),
[Geovisit](geovisit.md)

## -capabilities
location
