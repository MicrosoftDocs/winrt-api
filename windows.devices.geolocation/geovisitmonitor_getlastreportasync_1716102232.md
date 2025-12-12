---
-api-id: M:Windows.Devices.Geolocation.GeovisitMonitor.GetLastReportAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Geolocation.Geovisit> GetLastReportAsync()
-->

# Windows.Devices.Geolocation.GeovisitMonitor.GetLastReportAsync

## -description
Retrieves the latest Visit-related event the user has completed.

## -returns
An asynchronous operation with a [Geovisit](geovisit.md) instance representing the user's latest Visit.

## -remarks
This method allows you to get the most recent visit information without having to wait for new visit events to occur. The returned visit represents the last completed visit state change.

## -examples

## -see-also
[Geovisit](geovisit.md), [GeovisitMonitor](geovisitmonitor.md)

## -capabilities
location
