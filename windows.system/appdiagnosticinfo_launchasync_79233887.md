---
-api-id: M:Windows.System.AppDiagnosticInfo.LaunchAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppActivationResult> AppDiagnosticInfo.LaunchAsync()
-->

# Windows.System.AppDiagnosticInfo.LaunchAsync

## -description
Launches the app associated with the diagnostic info.

## -returns
On success, `AppActivationResult.AppResourceGroupInfo` will correspond to the newly-activated app instance.
On failure, `AppActivationResult.Exception` will reflect the error, and `ActivationResult.AppResourceGroupInfo` will be `null`.

## -remarks
The target app will be launched as if the user had tapped its entry in the app-list or its primary tile in the Start menu. The system will invoke the app’s [OnLaunched](/uwp/api/windows.ui.xaml.application.onlaunched#Windows_UI_Xaml_Application_OnLaunched_Windows_ApplicationModel_Activation_LaunchActivatedEventArgs_) callback, passing in [ActivationKind.Launch](/uwp/api/windows.applicationmodel.activation.activationkind) and an [IActivatedEventArgs](/uwp/api/windows.applicationmodel.activation.iactivatedeventargs) of type [LaunchActivatedEventArgs](/uwp/api/windows.applicationmodel.activation.launchactivatedeventargs).

## -see-also

## -examples
