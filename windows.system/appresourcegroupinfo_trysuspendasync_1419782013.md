---
-api-id: M:Windows.System.AppResourceGroupInfo.TrySuspendAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> AppResourceGroupInfo.TrySuspendAsync()
-->

# Windows.System.AppResourceGroupInfo.TrySuspendAsync

## -description
Initiate moving the associated app to the suspended state.

## -returns
**True** indicates that the app was successfully suspended; **false**, otherwise. Calling **TrySuspendAsync** on an app that is already suspended will return success.

## -remarks
Once the caller has an **AppResourceGroupInfo** for the running app, they can subsequently call this method. This will initiate the standard workflow to move the app to the Suspended state. For example, on desktop this workflow includes minimizing the app. This will also include calling the app’s [OnSuspending](https://docs.microsoft.com/uwp/api/windows.ui.xaml.application#Windows_UI_Xaml_Application_Suspending) callback in the normal way, including honoring deferrals during suspension. This method will return as soon as it has initiated the suspension workflow, and not wait for the app to transition state or for it to run its **OnSuspending** method. This is important because the app may take a long time to suspend depending on deferrals.

You can call this method from any **AppResourceGroupInfo**, but only the one for the foreground app has a high probability of succeeding. Suspending the foreground app may result in suspending other resource groups for that app.

## -see-also
[Handle app suspend](https://docs.microsoft.com/windows/uwp/launch-resume/suspend-an-app)

## -examples

## -capabilities
appDiagnostics
