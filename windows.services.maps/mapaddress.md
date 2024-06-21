---
-api-id: T:Windows.Services.Maps.MapAddress
-api-type: winrt class
---

<!-- Class syntax.
public class MapAddress : Windows.Services.Maps.IMapAddress, Windows.Services.Maps.IMapAddress2
-->

# Windows.Services.Maps.MapAddress

## -description
Represents an address.

## -remarks

A collection of [MapLocation](maplocation.md) objects is returned through the [Locations](maplocationfinderresult_locations.md) property of the [MapLocationFinderResult](maplocationfinderresult.md) when you call the methods of the [MapLocationFinder](maplocationfinder.md) class. Each [MapLocation](maplocation.md) object has an [Address](maplocation_address.md) property which returns a MapAddress.

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
