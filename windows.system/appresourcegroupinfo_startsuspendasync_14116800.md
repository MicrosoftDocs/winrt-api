---
-api-id: M:Windows.System.AppResourceGroupInfo.StartSuspendAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppExecutionStateChangeResult> AppResourceGroupInfo.StartSuspendAsync()
-->

# Windows.System.AppResourceGroupInfo.StartSuspendAsync

## -description
Initiate moving the associated app to the suspended state.

## -returns
The result of trying to suspend the app.

## -remarks
Calling this method on an app that is already suspended will return success.

This method initiates the standard workflow to move the app to the Suspended state. For example, on desktop this workflow includes minimizing the app. This will also include calling the app’s [OnSuspending](/uwp/api/windows.ui.xaml.application.Suspending) callback in the normal way, including honoring deferrals during suspension. This method will return as soon as it has initiated the suspension workflow, and not wait for the app to transition state or for it to run its **OnSuspending** method. Note that the app may take a long time to suspend, depending on deferrals.

You can call this method from any **AppResourceGroupInfo**, but only the one for the foreground app has a high probability of succeeding. Suspending the foreground app may result in suspending other resource groups for that app.

This method won’t work on [ResourceGroups](/windows/uwp/launch-resume/declare-background-tasks-in-the-application-manifest) that relate to background tasks because they don’t have the concept of suspend/resume.

This method won’t work on [Desktop Bridge](/windows/uwp/porting/desktop-to-uwp-root) apps because they don’t have the concept of suspend/resume.

## -see-also
[Handle app suspend](/windows/uwp/launch-resume/suspend-an-app)

## -examples

## -capabilities
appDiagnostics
