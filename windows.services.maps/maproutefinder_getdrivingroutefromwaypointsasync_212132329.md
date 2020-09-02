---
-api-id: M:Windows.Services.Maps.MapRouteFinder.GetDrivingRouteFromWaypointsAsync(Windows.Foundation.Collections.IIterable{Windows.Devices.Geolocation.Geopoint},Windows.Services.Maps.MapRouteOptimization,Windows.Services.Maps.MapRouteRestrictions,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Maps.MapRouteFinderResult> GetDrivingRouteFromWaypointsAsync(Windows.Foundation.Collections.IIterable<Windows.Devices.Geolocation.Geopoint> wayPoints, Windows.Services.Maps.MapRouteOptimization optimization, Windows.Services.Maps.MapRouteRestrictions restrictions, System.Double headingInDegrees)
-->

# Windows.Services.Maps.MapRouteFinder.GetDrivingRouteFromWaypointsAsync

## -description
Gets a driving route for the specified waypoints (using optimizations, restrictions, and heading).

## -parameters
### -param wayPoints
The start and end coordinates and optional waypoints of the driving route.

### -param optimization
The optimizations to apply when calculating the driving route.

### -param restrictions
The restrictions to apply when calculating the driving route.

### -param headingInDegrees
The preferred start direction from the current location for the driving route.

## -returns
When this method completes successfully, it returns a driving route contained in the [MapRouteFinderResult](maproutefinderresult.md).

## -remarks

## -examples

## -see-also
[Display  routes and directions on a map](/windows/uwp/maps-and-location/routes-and-directions), [GetDrivingRouteFromWaypointsAsync(IIterable(Geopoint))](maproutefinder_getdrivingroutefromwaypointsasync_1378129125.md), [GetDrivingRouteFromWaypointsAsync(IIterable(Geopoint), MapRouteOptimization)](maproutefinder_getdrivingroutefromwaypointsasync_1782798969.md), [GetDrivingRouteFromWaypointsAsync(IIterable(Geopoint), MapRouteOptimization, MapRouteRestrictions)](maproutefinder_getdrivingroutefromwaypointsasync_2047541881.md)
