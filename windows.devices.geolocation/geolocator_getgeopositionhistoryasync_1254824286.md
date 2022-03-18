---
-api-id: M:Windows.Devices.Geolocation.Geolocator.GetGeopositionHistoryAsync(Windows.Foundation.DateTime)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Devices.Geolocation.Geoposition>> GetGeopositionHistoryAsync(Windows.Foundation.DateTime startTime)
-->

# Windows.Devices.Geolocation.Geolocator.GetGeopositionHistoryAsync

## -description
Starts an asynchronous operation to retrieve the location history of the device.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters
### -param startTime
Represents the beginning of the time span for which positions are to be returned.

## -returns
Positions (of type [Geoposition](geoposition.md)) that were collected during the specified time span.

## -remarks
The GetGeopositionHistoryAsync method allows your app to asynchronously fetch a list of positions that have been collected by location services. Only positions that have been collected since the specified *startTime* will be returned. If no positions are available from that time span, an empty list will be returned.

This method returns only positions that have already been collected by location services in the last 24 hours; it does not resolve new positions. Specifying a time span that exceeds this 24-hour window will not yield any additional positions.

Location services collects positions only when an app or services queries for the user's location - but no more than once per second. Location history is limited to 3600 positions; if location history isn't cleared by the user, each position will be stored in location history between 1 and 24 hours.

> [!NOTE]
> If you use a background task to call this method frequently, it's important to consider the impact that will have on the battery. Although this method doesn't trigger the GPS receiver, processor resources are still required to run the background task.

## -examples

## -see-also
[Get current location](/windows/uwp/maps-and-location/get-location), [Set up a geofence](/windows/uwp/maps-and-location/set-up-a-geofence), [GetGeopositionHistoryAsync(DateTime, TimeSpan)](geolocator_getgeopositionhistoryasync_544182854.md), [geolocation sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Geolocation)

## -capabilities
locationHistory
location
