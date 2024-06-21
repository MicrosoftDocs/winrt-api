---
-api-id: T:Windows.Services.Maps.MapLocation
-api-type: winrt class
---

<!-- Class syntax.
public class MapLocation : Windows.Services.Maps.IMapLocation
-->

# Windows.Services.Maps.MapLocation

## -description
Represents a geographic location.

## -remarks

A collection of MapLocation objects is returned through the [Locations](maplocationfinderresult_locations.md) property of the [MapLocationFinderResult](maplocationfinderresult.md) when you call the methods of the [MapLocationFinder](maplocationfinder.md) class.

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
[Perform geocoding and reverse geocoding](/windows/uwp/maps-and-location/geocoding)
