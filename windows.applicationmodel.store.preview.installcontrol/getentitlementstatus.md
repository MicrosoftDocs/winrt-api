---
-api-id: T:Windows.ApplicationModel.Store.Preview.InstallControl.GetEntitlementStatus
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum GetEntitlementStatus : int {
	NetworkError = 2
	NoStoreAccount = 1
	ServerError = 3
	Succeeded = 0
}
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.GetEntitlementStatus

## -description
Defines the possible results of a request to grant a free entitlement by using the [GetFreeDeviceEntitlementAsync](appinstallmanager_getfreedeviceentitlementasync_1427505322.md), [GetFreeUserEntitlementAsync](appinstallmanager_getfreeuserentitlementasync_107347343.md), or [GetFreeUserEntitlementForUserAsync](appinstallmanager_getfreeuserentitlementforuserasync_376670896.md) methods.

## -enum-fields

## -field Succeeded:0
The request succeeded.

## -field ServerError:3
The request was unsuccessful because of a server error.

## -field NoStoreAccount:1
The request was unsuccessful because the specified user does not have a Microsoft account that is associated with the Store on the current device.

## -field NetworkError:2
The request was unsuccessful because of a network connection error.

## -remarks
The [GetEntitlementResult.Status](getentitlementresult_status.md) property returns one of the **GetEntitlementStatus** values.

## -see-also

## -examples

## -capabilities
runFullTrust
