---
-api-id: T:Windows.System.AppActivationResult
-api-type: winrt class
---

<!-- Class syntax.
public class AppActivationResult
-->

# Windows.System.AppActivationResult

## -description
Gets the result of activating an app via [AppDiagnosticInfo.ActivateAsync](appdiagnosticinfo_activateasync_1981716034.md).

## -remarks
On success, the [AppResourceGroupInfo](appactivationresult_appresourcegroupinfo.md) property will correspond to the newly-activated app instance.
On failure, the **HResult** will be set appropriately, and the **AppResourceGroupInfo** will be set to `null`.

## -see-also

## -examples

## -capabilities
appDiagnostics
