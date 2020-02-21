---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.GetFreeUserEntitlementAsync(System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<GetEntitlementResult> AppInstallManager.GetFreeUserEntitlementAsync(String storeId, String campaignId, String correlationVector)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.GetFreeUserEntitlementAsync


## -description

Grants a free entitlement for the specified app to the current user.

## -parameters

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

