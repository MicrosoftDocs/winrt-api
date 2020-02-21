---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.GetFreeUserEntitlementForUserAsync(Windows.System.User,System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<GetEntitlementResult> AppInstallManager.GetFreeUserEntitlementForUserAsync(User user, String storeId, String campaignId, String correlationVector)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.GetFreeUserEntitlementForUserAsync


## -description

Grants a free entitlement for the specified app to the specified user.

## -parameters

### -param user

A [Windows.System.User](../windows.system/user.md) object that represents the user to which you want to grant the entitlement.

### -param storeId

The Store ID of the app for which you want to grant the entitlement.

### -param campaignId

The ID of the campaign that is associated with the entitlement.

### -param correlationVector

A correlation vector string that can be used to generate telemetry data.

## -returns

An asynchronous operation that, on successful completion, returns a [GetEntitlementResult](getentitlementresult.md) object that indicates the status of the entitlement grant.

## -remarks

## -see-also

## -examples

## -capabilities

runFullTrust

