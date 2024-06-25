---
-api-id: T:Windows.Services.Maps.MapRouteManeuverKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Maps.MapRouteManeuverKind : int
-->

# MapRouteManeuverKind

## -description
Describes the various types of maneuvers that can occur in a route. This enumeration provides values for the [Kind](maproutemaneuver_kind.md) property of a [MapRouteManeuver](maproutemaneuver.md).

## -enum-fields
### -field None:0
The maneuver is not defined.

### -field Start:1
The start of the route.

### -field Stopover:2
A stopover on the route.

### -field StopoverResume:3
The route has resumed after a stopover.

### -field End:4
The end of the route.

### -field GoStraight:5
Go straight.

### -field UTurnLeft:6
Make a U-turn to the left.

### -field UTurnRight:7
Make a U-turn to the right.

### -field TurnKeepLeft:8
Keep left.

### -field TurnKeepRight:9
Keep right.

### -field TurnLightLeft:10
Make a gentle left turn.

### -field TurnLightRight:11
Make a gentle right turn.

### -field TurnLeft:12
Turn left.

### -field TurnRight:13
Turn right.

### -field TurnHardLeft:14
Make a hard left turn.

### -field TurnHardRight:15
Make a hard right turn.

### -field FreewayEnterLeft:16
Enter the freeway on the left.

### -field FreewayEnterRight:17
Enter the freeway on the right.

### -field FreewayLeaveLeft:18
Leave the freeway on the left.

### -field FreewayLeaveRight:19
Leave the freeway on the right.

### -field FreewayContinueLeft:20
Continue on the freeway on the left.

### -field FreewayContinueRight:21
Continue on the freeway on the right.

### -field TrafficCircleLeft:22
Enter the traffic circle on the left.

### -field TrafficCircleRight:23
Enter the traffic circle on the right.

### -field TakeFerry:24
Take the ferry.


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
