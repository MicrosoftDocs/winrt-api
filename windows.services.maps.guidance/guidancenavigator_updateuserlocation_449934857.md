---
-api-id: M:Windows.Services.Maps.Guidance.GuidanceNavigator.UpdateUserLocation(Windows.Devices.Geolocation.Geocoordinate)
-api-type: winrt method
---

<!-- Method syntax
public void UpdateUserLocation(Windows.Devices.Geolocation.Geocoordinate userLocation)
-->

# Windows.Services.Maps.Guidance.GuidanceNavigator.UpdateUserLocation

## -description
Updates navigational guidance, using the specified geographic location.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime. For more information about the [Windows.Services.Maps.Guidance](windows_services_maps_guidance.md) namespace, please work with your Microsoft Account Team representative.

## -parameters
### -param userLocation
The user's current location.

## -remarks
To find the user's current location, use the [Geolocator](../windows.devices.geolocation/geolocator.md) object in the [Windows.Devices.Geolocation](../windows.devices.geolocation/windows_devices_geolocation.md) namespace. For more information, see [Get current location](/windows/uwp/maps-and-location/get-location).

## -examples

## -see-also
[UpdateUserLocation(Geocoordinate, BasicGeoposition)](guidancenavigator_updateuserlocation_460455845.md)