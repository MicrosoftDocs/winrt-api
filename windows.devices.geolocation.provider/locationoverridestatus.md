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
> To call location-override APIs, an app must declare the `runFullTrust` [restricted capability](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

> [!IMPORTANT]
> The [Windows.Devices.Geolocation.Provider](/uwp/api/windows.devices.geolocation.provider.geolocationprovider) APIs are part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, contact [Microsoft Support](https://support.serviceshub.microsoft.com/supportforbusiness/create?sapId=d15d3aa2-0512-7cb8-1df9-86221f5cbfde).

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

## -see-also

## -examples
