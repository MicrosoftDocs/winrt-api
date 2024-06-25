---
-api-id: T:Windows.Services.Maps.MapRouteOptimization
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Maps.MapRouteOptimization : int
-->

# MapRouteOptimization

## -description
Specifies the optimizations applied to a route. This enumeration provides values for certain parameters of some overloads of the [GetDrivingRouteAsync](maproutefinder_getdrivingrouteasync_1041948120.md) and [GetDrivingRouteFromWaypointsAsync](maproutefinder_getdrivingroutefromwaypointsasync_1378129125.md) methods.

## -enum-fields
### -field Time:0
Optimize the route by minimizing the time.

### -field Distance:1
Optimize the route by minimizing the distance.

### -field TimeWithTraffic:2
Optimize the route by minimizing the time with traffic.

> > [!TIP]
> Traffic-based routing is not automatically updated. To capture changes in traffic conditions, repeat the query.


### -field Scenic:3
Optimize the route to include the most scenic roads.

## -remarks
> [!IMPORTANT]
> **Bing Maps for Enterprise service retirement**
>
> The UWP [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md) and map services from the [Windows.Services.Maps](windows_services_maps.md) namespaces rely on Bing Maps. Bing Maps for Enterprise is deprecated and will be retired, at which point the MapControl and services will no longer receive data.
>
> For more information, see the [Bing Maps Developer Center](https://www.bingmapsportal.com/) and [Bing Maps documentation](/bingmaps/getting-started/).

Your app must be authenticated before it can use the [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md) and map services in the [Windows.Services.Maps](windows_services_maps.md) namespace. To authenticate your app, you must specify a maps authentication key.

See [Request a maps authentication key](/windows/uwp/maps-and-location/authentication-key).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | Scenic |

## -examples

## -see-also
[Display  routes and directions on a map](/windows/uwp/maps-and-location/routes-and-directions)
