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
> The [Windows.Devices.Geolocation.Provider](/uwp/api/windows.devices.geolocation.provider.geolocationprovider) APIs are part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -property-value

A Boolean value indicating whether the owning [GeolocationProvider](geolocationprovider.md) is currently overridden or not.

## -remarks

See **Remarks** in [GeolocationProvider](geolocationprovider.md).

## -see-also
[GeolocationProvider.IsOverriddenChanged](geolocationprovider_isoverriddenchanged.md)

## -examples

## -capabilities
runFullTrust
