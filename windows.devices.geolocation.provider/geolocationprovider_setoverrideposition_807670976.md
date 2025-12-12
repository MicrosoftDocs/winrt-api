---
-api-id: M:Windows.Devices.Geolocation.Provider.GeolocationProvider.SetOverridePosition(Windows.Devices.Geolocation.BasicGeoposition,Windows.Devices.Geolocation.PositionSource,System.Double)
-api-type: winrt method
---

# Windows.Devices.Geolocation.Provider.GeolocationProvider.SetOverridePosition(Windows.Devices.Geolocation.BasicGeoposition,Windows.Devices.Geolocation.PositionSource,System.Double)

<!--
public Windows.Devices.Geolocation.Provider.LocationOverrideStatus SetOverridePosition (Windows.Devices.Geolocation.BasicGeoposition newPosition, Windows.Devices.Geolocation.PositionSource positionSource, double accuracyInMeters);
-->

## -description

Sets an override position for the user's location. You can clear the override position by calling [GeolocationProvider.ClearOverridePosition](geolocationprovider_clearoverrideposition_399430586.md)

> [!NOTE]
> To call location-override APIs, an app must declare the `runFullTrust` [restricted capability](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

> [!IMPORTANT]
> The [Windows.Devices.Geolocation.Provider](/uwp/api/windows.devices.geolocation.provider.geolocationprovider) APIs are part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -parameters

### -param newPosition

The override position.

### -param positionSource

The source that's overriding the position.

### -param accuracyInMeters

The accuracy of the override position, in meters.

## -returns

Returns [LocationOverrideStatus](locationoverridestatus.md), which indicates whether the override was applied. The method returns `LocationOverrideStatus.Success` when the platform accepts the new position; values such as `LocationOverrideStatus.AccessDenied` or `LocationOverrideStatus.AlreadyStarted` indicate the request was rejected.

## -remarks

See the remarks in [GeolocationProvider](geolocationprovider.md).

## -examples

## -see-also

[GeolocationProvider.ClearOverridePosition](geolocationprovider_clearoverrideposition_399430586.md)

## -capabilities
runFullTrust
