---
-api-id: T:Windows.Devices.Geolocation.VisitMonitoringScope
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum VisitMonitoringScope : int
-->

# Windows.Devices.Geolocation.VisitMonitoringScope

## -description
Contains values that describe the intended scope of location monitoring for use with the Visits feature.

## -enum-fields
### -field Venue:0
Monitor all Visit-related events that concern changes in building-sized areas.

### -field City:1
Monitor only the Visit-related events that concern changes in city-sized areas.

## -remarks
A value must be specified when setting up a [GeovisitTrigger](/uwp/api/windows.applicationmodel.background.geovisittrigger) or [GeovisitMonitor](geovisitmonitor.md), in order to determine which Visit-related events will be processed.

## -examples

## -see-also
[GeovisitMonitor](geovisitmonitor.md),
[GeovisitTrigger](/uwp/api/windows.applicationmodel.background.geovisittrigger),
[Guidelines for using Visits tracking](/windows/uwp/maps-and-location/guidelines-for-visits)

## -capabilities
location
