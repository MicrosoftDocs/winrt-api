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
Monitor the Visist-related events that concern changes in buildings.

### -field City:1
Monitor only the Visit-related events that concern changes in cities. 

## -remarks
A value must be specified when setting up a [GeovisitTrigger](https://docs.microsoft.com/uwp/api/windows.applicationmodel.background.geovisittrigger) or [GeovisitMonitor](GeovisitMonitor.md), in order to determine which Visit-related events will be processed.

## -see-also
[GeovisitMonitor](GeovisitMonitor.md)
[GeovisitTrigger](https://docs.microsoft.com/uwp/api/windows.applicationmodel.background.geovisittrigger)

## -examples

