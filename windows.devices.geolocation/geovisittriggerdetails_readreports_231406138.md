---
-api-id: M:Windows.Devices.Geolocation.GeovisitTriggerDetails.ReadReports
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Devices.Geolocation.Geovisit> ReadReports()
-->

# Windows.Devices.Geolocation.GeovisitTriggerDetails.ReadReports

## -description
Gets a list of Visit-related state changes that the user has logged since they were last queried.

## -returns
An [IVectorView](/uwp/api/windows.foundation.collections.ivectorview_t_) of [Geovisit](geovisit.md) instances representing the user's Visit-related state changes.

## -remarks
This method returns a collection of visit reports that have accumulated since the last time they were read. Each report represents a visit state change event.

## -examples

## -see-also
[Geovisit](geovisit.md),
[GeovisitTriggerDetails](geovisittriggerdetails.md)

## -capabilities
location
