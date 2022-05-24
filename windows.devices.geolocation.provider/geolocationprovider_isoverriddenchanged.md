---
-api-id: E:Windows.Devices.Geolocation.Provider.GeolocationProvider.IsOverriddenChanged
-api-type: winrt event
---

# Windows.Devices.Geolocation.Provider.GeolocationProvider.IsOverriddenChanged

<!--
public event System.EventHandler<object> IsOverriddenChanged;
-->

## -description

An event that's raised when the value of the [GeolocationProvider.IsOverridden](geolocationprovider_isoverridden.md) property changes. You can register to handle this event, and access the current value of **GeolocationProvider.IsOverridden** in response.

> [!NOTE]
> To call location-override APIs, an app must declare the `runFullTrust` [restricted capability](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

> [!IMPORTANT]
> The [GeolocationProvider API](windows_devices_geolocation_provider.md) is a limited access feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). Contact `locationproviderlaf@microsoft.com` for more info.

## -remarks

See **Remarks** in [GeolocationProvider](geolocationprovider.md).

## -see-also
[GeolocationProvider.IsOverridden](geolocationprovider_isoverridden.md)

## -examples

## -capabilities
runFullTrust
