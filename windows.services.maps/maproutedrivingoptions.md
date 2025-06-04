---
-api-id: T:Windows.Services.Maps.MapRouteDrivingOptions
-api-type: winrt class
---

<!-- Class syntax.
public class MapRouteDrivingOptions : Windows.Services.Maps.IMapRouteDrivingOptions
-->

# Windows.Services.Maps.MapRouteDrivingOptions

## -description

[Deprecated - see Remarks.] Represents advanced routing options.

## -remarks

> [!IMPORTANT]
> The UWP [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md) and Windows Maps platform APIs ([Windows.Services.Maps.*](../windows.services.maps/windows_services_maps.md)) are deprecated and may not be available in future versions of Windows. For more information, see [Resources for deprecated features](/windows/whats-new/deprecated-features-resources#windows-uwp-map-control-and-windows-maps-platform-apis).

> [!IMPORTANT]
> **Bing Maps for Enterprise service retirement**
>
> The UWP [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md) and map services from the [Windows.Services.Maps](windows_services_maps.md) namespaces rely on Bing Maps. Bing Maps for Enterprise is deprecated and will be retired, at which point the MapControl and services will no longer receive data.
>
> For more information, see the [Bing Maps Developer Center](https://www.bingmapsportal.com/) and [Bing Maps documentation](/bingmaps/getting-started/).

MapRouteDrivingOptions allows you to specify advanced routing options when using the [GetDrivingRouteAsync](maproutefinder_getdrivingrouteasync_1265171240.md) method.

Your app must be authenticated before it can use the [MapControl](../windows.ui.xaml.controls.maps/mapcontrol.md) and map services in the [Windows.Services.Maps](windows_services_maps.md) namespace. To authenticate your app, you must specify a maps authentication key.

See [Request a maps authentication key](/windows/uwp/maps-and-location/authentication-key).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | DepartureTime |

## -examples

## -see-also
