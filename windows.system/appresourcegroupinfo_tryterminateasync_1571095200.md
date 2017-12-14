---
-api-id: M:Windows.System.AppResourceGroupInfo.TryTerminateAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> AppResourceGroupInfo.TryTerminateAsync()
-->

# Windows.System.AppResourceGroupInfo.TryTerminateAsync

## -description
Initiate moving the associated app to the terminated state.

## -returns
**True** indicates that the app was successfully terminated; **false**, otherwise.

## -remarks
For an app that is running, which includes being in the active, suspending, or suspended states, call this method to terminate the app. This will terminate the app the same way as if the user terminated the app by tapping the close button. This will call the app's [OnSuspending](https://docs.microsoft.com/uwp/api/windows.ui.xaml.application#Windows_UI_Xaml_Application_Suspending) callback, as the system moves the app through the app-lifecycle states, starting with Active, moving to Suspending, then Suspended, and finally Terminated. This method will return as soon as it has initiated the workflow, before any state changes, and before the app’s **OnSuspending** callback.

## -see-also

## -examples

## -capabilities
appDiagnostics
