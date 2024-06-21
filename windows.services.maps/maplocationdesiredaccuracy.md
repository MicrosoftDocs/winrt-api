---
-api-id: T:Windows.Services.Maps.MapLocationDesiredAccuracy
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Maps.MapLocationDesiredAccuracy : int
-->

# MapLocationDesiredAccuracy

## -description
Indicates the desired accuracy to use when converting latitude and longitude coordinates to a physical location like a city or address.

## -enum-fields
### -field High:0
Leverage the underlying REST API call to get richer and more accurate results.

### -field Low:1
Leverage the maps disk cache to get accurate info up to the city level.

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