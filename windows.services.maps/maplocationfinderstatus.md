---
-api-id: T:Windows.Services.Maps.MapLocationFinderStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Maps.MapLocationFinderStatus : int
-->

# MapLocationFinderStatus

## -description
Returns the status of a [MapLocationFinder](maplocationfinder.md) query. This enumeration provides values for the [Status](maplocationfinderresult_status.md) property of a [MapLocationFinderResult](maplocationfinderresult.md).

## -enum-fields
### -field Success:0
Query search operation was successful. Check result size before accessing results.

### -field UnknownError:1
The query returned an unknown error.

### -field InvalidCredentials:2
The query provided credentials that are not valid.

### -field BadLocation:3
The specified point cannot be converted to a location. For example, the point is in an ocean or a desert.

### -field IndexFailure:4
The query encountered an internal error.

### -field NetworkFailure:5
The query encountered a network failure.

### -field NotSupported:6
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
