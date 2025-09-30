---
-api-id: N:Windows.Devices.Geolocation.Provider
-api-type: winrt namespace
---

# Windows.Devices.Geolocation.Provider

## -description

Some scenarios require a remote location source because the device's physical position doesn't represent the user's real location or the hardware can't provide the needed accuracy. This namespace exposes APIs that let full-trust components publish override positions for Windows location services.

> [!NOTE]
> To call location-override APIs, an app must declare the `runFullTrust` [restricted capability](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

> [!IMPORTANT]
> The Windows.Devices.Geolocation.Provider APIs are part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -remarks

Use this namespace when you need to override the device-reported location and provide coordinates from a separate
source. The APIs target full-trust components that must run alongside the user session to supply high-confidence
location data to Windows and any app that consumes location services.

### Typical scenarios
- Remote desktop or virtualization products that need to reflect the remote user's actual location.
- Enterprise management tools that supply authoritative location updates during regulated workflows.
- Automated testing harnesses that verify location-aware experiences with deterministic input.

### Key types
- [GeolocationProvider](geolocationprovider.md): Creates override sessions and manages their lifecycle.
- [LocationOverrideStatus](locationoverridestatus.md): Indicates the outcome of override operations.

> [!IMPORTANT]
> Override sessions apply system-wide. Always monitor [GeolocationProvider.IsOverriddenChanged](geolocationprovider_isoverriddenchanged.md)
> to detect when another component preempts your session and clean up resources promptly.

## -examples

## -see-also
[GeolocationProvider](geolocationprovider.md), [LocationOverrideStatus](locationoverridestatus.md), [Windows.Devices.Geolocation namespace](/uwp/api/windows.devices.geolocation)

## -capabilities
runFullTrust
