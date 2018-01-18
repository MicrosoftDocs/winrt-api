---
-api-id: T:Windows.System.AppActivationResult
-api-type: winrt class
---

<!-- Class syntax.
public class AppActivationResult
-->

# Windows.System.AppActivationResult

## -description
Gets the result of activating an app via [AppDiagnosticInfo.LaunchAsync](appdiagnosticinfo_launchasync_79233887.md).

## -remarks
On success, [AppActivationResult.AppResourceGroupInfo](appactivationresult_appresourcegroupinfo.md) will correspond to the newly-activated app instance.
On failure, [AppActivationResult.ExtendedError](appactivationresult_extendederror.md) will be set appropriately, and [AppActivationResult.AppResourceGroupInfo](appactivationresult_appresourcegroupinfo.md) will be `null`.

## -see-also

## -examples

## -capabilities
appDiagnostics
