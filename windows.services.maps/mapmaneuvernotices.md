---
-api-id: T:Windows.Services.Maps.MapManeuverNotices
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Maps.MapManeuverNotices : uint
-->

# MapManeuverNotices

## -description
Provides additional information about a maneuver. This enumeration provides values for the [ManeuverNotices](maproutemaneuver_maneuvernotices.md) property of a [MapRouteManeuver](maproutemaneuver.md).

## -enum-fields
### -field None:0
There is no additional information.

### -field Toll:1
The maneuver includes a toll road.

### -field Unpaved:2
The maneuver includes an unpaved road.


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
