---
-api-id: T:Windows.Services.Maps.MapRoute
-api-type: winrt class
---

<!-- Class syntax.
public class MapRoute : Windows.Services.Maps.IMapRoute, Windows.Services.Maps.IMapRoute2, Windows.Services.Maps.IMapRoute3
-->

# Windows.Services.Maps.MapRoute

## -description
Represents a path to be traveled between two or more waypoints.

## -remarks
A [MapRoute](maproute.md) object is returned through the [Route](maproutefinderresult_route.md) property of the [MapRouteFinderResult](maproutefinderresult.md) when you call the methods of the [MapRouteFinder](maproutefinder.md) class.

To display a [MapRoute](maproute.md) on a [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md), construct a [MapRouteView](../windows.ui.xaml.controls.maps/maprouteview.md) with the [MapRoute](maproute.md) and add the [MapRouteView](../windows.ui.xaml.controls.maps/maprouteview.md) to the [Routes](../windows.ui.xaml.controls.maps/mapcontrol_routes.md) collection of the [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md).

Your [Universal Windows app](https://msdn.microsoft.com/windows/uwp/get-started/universal-application-platform-guide) must be authenticated before it can use the [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md) and map services in the [Windows.Services.Maps](windows_services_maps.md) namespace. To authenticate your app, you must specify a maps authentication key.

See [Request a maps authentication key](https://msdn.microsoft.com/windows/uwp/maps-and-location/authentication-key).

## -examples

## -see-also
[Display  routes and directions on a map](https://msdn.microsoft.com/library/bbb4c23a-8f10-41d1-81ea-271be01aed81)
