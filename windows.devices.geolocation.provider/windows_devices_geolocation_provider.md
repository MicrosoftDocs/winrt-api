---
-api-id: N:Windows.Devices.Geolocation.Provider
-api-type: winrt namespace
---

# Windows.Devices.Geolocation.Provider

## -description

There are some scenarios in which the physical location of the devices isn't sufficient&mdash;either because it doesn't represent the user's real location, or the current positioning capabilities of the device aren't good enough to satisfy a particular scenario. In those cases, there's a need for a remote location source to *override* the current device location, and not only be a last resolution. The types in this namespace provide those facilities.

> [!NOTE]
> To call location-override APIs, an app must declare the `runFullTrust` [restricted capability](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

> [!IMPORTANT]
> The GeolocationProvider API is a limited access feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). Contact `locationproviderlaf@microsoft.com` for more info.

## -remarks

## -see-also

[Windows.Devices.Geolocation namespace](/uwp/api/windows.devices.geolocation)

## -examples

## -capabilities
runFullTrust
