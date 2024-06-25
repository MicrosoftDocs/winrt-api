---
-api-id: T:Windows.Services.Maps.MapLocationFinder
-api-type: winrt class
---

<!-- Class syntax.
public class MapLocationFinder 
-->

# Windows.Services.Maps.MapLocationFinder

## -description
Provides methods to convert addresses to geographic locations (geocoding) and to convert geographic locations to addresses (reverse geocoding).

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
| 1607 | 14393 | FindLocationsAtAsync(Geopoint,MapLocationDesiredAccuracy) |

## -examples

## -see-also
[Perform geocoding and reverse geocoding](/windows/uwp/maps-and-location/geocoding)
