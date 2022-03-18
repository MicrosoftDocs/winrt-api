---
-api-id: M:Windows.System.AppResourceGroupInfo.StartTerminateAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppExecutionStateChangeResult> AppResourceGroupInfo.StartTerminateAsync()
-->

# Windows.System.AppResourceGroupInfo.StartTerminateAsync
Initiate moving the associated app to the terminated state.

## -description
Initiate moving the associated app to the terminated state.

## -returns
The result of trying to terminate the app.

## -remarks
The app to terminate must be running, which includes being in the active, suspending, or suspended states. This will terminate the app the same way as if the user terminated the app by tapping the close button. This will call the app's [OnSuspending](/uwp/api/windows.ui.xaml.application.Suspending) callback, as the system moves the app through the app-lifecycle states, starting with Active, moving to Suspending, then Suspended, and finally Terminated. This method will return as soon as it has initiated the workflow, before any state changes, and before the app’s **OnSuspending** callback.

## -see-also

## -examples

## -capabilities
appDiagnostics
