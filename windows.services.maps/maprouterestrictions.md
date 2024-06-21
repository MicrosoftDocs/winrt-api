---
-api-id: T:Windows.Services.Maps.MapRouteRestrictions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Maps.MapRouteRestrictions : uint
-->

# MapRouteRestrictions

## -description
Specifies the restrictions applied to a route. This enumeration provides values for certain parameters of some overloads of the [GetDrivingRouteAsync](maproutefinder_getdrivingrouteasync_1041948120.md) and [GetDrivingRouteFromWaypointsAsync](maproutefinder_getdrivingroutefromwaypointsasync_1378129125.md) methods.

## -enum-fields
### -field None:0
No restrictions are applied to the route.

### -field Highways:1
Avoid highways.

### -field TollRoads:2
Avoid toll roads.

### -field Ferries:4
Avoid ferries.

### -field Tunnels:8
Avoid tunnels.

### -field DirtRoads:16
Avoid dirt roads.

### -field Motorail:32
Avoid motorail train services.


## -remarks
> [!IMPORTANT]
> **Bing Maps for Enterprise service retirement**
>
> The UWP [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md) and map services from the [Windows.Services.Maps](windows_services_maps.md) namespaces rely on Bing Maps. Bing Maps for Enterprise is deprecated and will be retired, at which point the MapControl and services will no longer receive data.
>
> For more information, see the [Bing Maps Developer Center](https://www.bingmapsportal.com/) and [Bing Maps documentation](/bingmaps/getting-started/).

Your app must be authenticated before it can use the [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md) and map services in the [Windows.Services.Maps](windows_services_maps.md) namespace. To authenticate your app, you must specify a maps authentication key.

See [Request a maps authentication key](/windows/uwp/maps-and-location/authentication-key).

## -examples

## -see-also
[Display  routes and directions on a map](/windows/uwp/maps-and-location/routes-and-directions)
