---
-api-id: M:Windows.System.AppResourceGroupInfo.StartResumeAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppExecutionStateChangeResult> AppResourceGroupInfo.StartResumeAsync()
-->

# Windows.System.AppResourceGroupInfo.StartResumeAsync

## -description
Initiate moving the associated app to the active state.

## -returns
The result of trying to resume the app.

## -remarks
Call this method to initiate the standard workflow to bring an app that is in the suspended state back to the active state. This workflow includes calling the app’s [Resuming](/uwp/api/windows.ui.xaml.application.Resuming) callback.

This method will return as soon as it has initiated the workflow, before the app’s Resuming callback, and before any state changes.

Calling this method on an app that is not suspended will result in a failure.

This method won’t work on [ResourceGroups](/windows/uwp/launch-resume/declare-background-tasks-in-the-application-manifest) that relate to background tasks because they don’t have the concept of suspend/resume.

This method won’t work on [Desktop Bridge](/windows/uwp/porting/desktop-to-uwp-root) apps because they don’t have the concept of suspend/resume.

## -see-also
[Handle app resume](/windows/uwp/launch-resume/resume-an-app)

## -examples

## -capabilities
appDiagnostics
