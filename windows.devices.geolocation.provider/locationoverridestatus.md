---
-api-id: T:Windows.Devices.Geolocation.Provider.LocationOverrideStatus
-api-type: winrt enum
---

# Windows.Devices.Geolocation.Provider.LocationOverrideStatus

<!--
public enum LocationOverrideStatus
-->

## -description

Defines constants that specify the status of a call to the location override API.

> [!NOTE]
> To call location-override APIs, an app must declare the `runFullTrust`
> [restricted capability](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

> [!IMPORTANT]
> The [Windows.Devices.Geolocation.Provider](/uwp/api/windows.devices.geolocation.provider.geolocationprovider) APIs are
> part of a Limited Access Feature (see
> [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to
> request an unlock token, please use the
> [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -enum-fields

### -field Success: 0

Specifies that the override API succeeded.

### -field AccessDenied: 1

Specifies that the override API failed due to access denied.

### -field AlreadyStarted: 2

Specifies that an override instance is already acquired by other application.

### -field Other: 3

Specifies an unknown status.

## -remarks

LocationOverrideStatus values are returned by
[SetOverridePosition](geolocationprovider_setoverrideposition_807670976.md) operations to indicate whether the location
override was established successfully.

### Handling specific status values

`LocationOverrideStatus.Success` indicates the override session was established and location data will be provided to
applications requesting location services.

`LocationOverrideStatus.AccessDenied` typically occurs when:
- The application lacks the required `runFullTrust` capability
- Limited Access Feature permissions have not been granted
- System policy prevents the current user context from overriding location

`LocationOverrideStatus.AlreadyStarted` indicates another process currently holds location override control. Only one
override session can be active at a time per user session. The existing session must call
[ClearOverridePosition](geolocationprovider_clearoverrideposition_399430586.md) before a new override can be
established.

`LocationOverrideStatus.Other` represents system-level failures that may be transient. Applications should implement
appropriate retry logic for this status, especially in remote connection scenarios where network connectivity may
affect the operation.

> [!IMPORTANT]
> Applications should handle all possible status values explicitly. Treat any non-success status as a failure
> condition and implement appropriate fallback behavior.

## -examples

## -see-also

[ClearOverridePosition](geolocationprovider_clearoverrideposition_399430586.md),
[GeolocationProvider](geolocationprovider.md),
[SetOverridePosition](geolocationprovider_setoverrideposition_807670976.md)
