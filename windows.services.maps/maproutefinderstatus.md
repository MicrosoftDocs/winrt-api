---
-api-id: T:Windows.Services.Maps.MapRouteFinderStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Maps.MapRouteFinderStatus : int
-->

# MapRouteFinderStatus

## -description
Returns the status of a [MapRouteFinder](maproutefinder.md) query. This enumeration provides values for the [Status](maproutefinderresult_status.md) property of a [MapRouteFinderResult](maproutefinderresult.md).

## -enum-fields
### -field Success:0
The query was successful.

### -field UnknownError:1
The query returned an unknown error.

### -field InvalidCredentials:2
The query provided credentials that are not valid.

### -field NoRouteFound:3
The query did not find a route.

### -field NoRouteFoundWithGivenOptions:4
The query did not find a route with the specified options.

### -field StartPointNotFound:5
The specified starting point is not valid in a route. For example, the point is in an ocean or a desert.

### -field EndPointNotFound:6
The specified ending point is not valid in a route. For example, the point is in an ocean or a desert.

### -field NoPedestrianRouteFound:7
The query did not find a pedestrian route.

### -field NetworkFailure:8
The query encountered a network failure.

### -field NotSupported:9
The query is not supported.


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
