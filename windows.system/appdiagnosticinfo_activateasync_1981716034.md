---
-api-id: M:Windows.System.AppDiagnosticInfo.ActivateAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppActivationResult> AppDiagnosticInfo.ActivateAsync()
-->

# Windows.System.AppDiagnosticInfo.ActivateAsync

## -description
Activate the app associated with this **AppDiagnosticInfo**.

## -returns
On success, this returns an [ActivationResult](appactivationresult.md), which exposes an [AppResourceGroupInfo](appactivationresult_appresourcegroupinfo.md) property, which corresponds to the newly-activated app instance.
On failure, this returns an **ActivationResult** with the **HResult** set appropriately, and the **AppResourceGroupInfo** set to `null`.

## -remarks
The target app will be launched as if the user had tapped its entry in the app-list or its primary tile in the Start menu. The system will invoke the app’s [OnLaunched](https://docs.microsoft.com/uwp/api/windows.ui.xaml.application#Windows_UI_Xaml_Application_OnLaunched_Windows_ApplicationModel_Activation_LaunchActivatedEventArgs_) callback, passing in [ActivationKind.Launch](https://docs.microsoft.com/uwp/api/windows.applicationmodel.activation.activationkind) and an [IActivatedEventArgs](https://docs.microsoft.com/uwp/api/windows.applicationmodel.activation.iactivatedeventargs) of type [LaunchActivatedEventArgs](https://docs.microsoft.com/uwp/api/windows.applicationmodel.activation.launchactivatedeventargs)

## -see-also

## -examples

## -capabilities
appDiagnostics
