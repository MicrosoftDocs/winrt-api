---
-api-id: P:Windows.Devices.Geolocation.Provider.GeolocationProvider.IsOverridden
-api-type: winrt property
---

# Windows.Devices.Geolocation.Provider.GeolocationProvider.IsOverridden

<!--
public bool IsOverridden { get; }
-->

## -description

Gets a value indicating whether the owning [GeolocationProvider](geolocationprovider.md) is currently overridden or not. You can access this property's value in your handler for the [GeolocationProvider.IsOverriddenChanged](geolocationprovider_isoverriddenchanged.md) event.

> [!NOTE]
> To call location-override APIs, an app must declare the `runFullTrust` [restricted capability](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

> [!IMPORTANT]
> The [GeolocationProvider API](windows_devices_geolocation_provider.md) is a limited access feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). Contact `locationproviderlaf@microsoft.com` for more info.

## -property-value

A Boolean value indicating whether the owning [GeolocationProvider](geolocationprovider.md) is currently overridden or not.

## -remarks

See **Remarks** in [GeolocationProvider](geolocationprovider.md).

## -see-also
[GeolocationProvider.IsOverriddenChanged](geolocationprovider_isoverriddenchanged.md)

## -examples

## -capabilities
runFullTrust
