---
-api-id: T:Windows.Services.Maps.MapRouteManeuver
-api-type: winrt class
---

<!-- Class syntax.
public class MapRouteManeuver : Windows.Services.Maps.IMapRouteManeuver, Windows.Services.Maps.IMapRouteManeuver2, Windows.Services.Maps.IMapRouteManeuver3
-->

# Windows.Services.Maps.MapRouteManeuver

## -description
Represents actions to be taken along the path of a route leg.

## -remarks
A collection of MapRouteManeuver objects is returned through the [Maneuvers](maprouteleg_maneuvers.md) property of a [MapRouteLeg](maprouteleg.md) object. A collection of [MapRouteLeg](maprouteleg.md) objects is returned through the [Legs](maproute_legs.md) property of a [MapRoute](maproute.md) object. A [MapRoute](maproute.md) object is returned through the [Route](maproute.md) property of the [MapRouteFinderResult](maproutefinderresult.md) when you call the methods of the [MapRouteFinder](maproutefinder.md) class.

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
| 1703 | 15063 | Warnings |

## -examples

## -see-also
[Display  routes and directions on a map](/windows/uwp/maps-and-location/routes-and-directions)
