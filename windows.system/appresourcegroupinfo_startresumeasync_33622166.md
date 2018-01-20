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
Call this method to initiate the standard workflow to bring an app that is in the suspended state back to the active state. This workflow includes calling the app’s [Resuming](https://docs.microsoft.com/uwp/api/windows.ui.xaml.application#Windows_UI_Xaml_Application_Resuming) callback.

This method will return as soon as it has initiated the workflow, before the app’s Resuming callback, and before any state changes.

Calling this method on an app that is not suspended will result in a failure.

## -see-also
[Handle app resume](https://docs.microsoft.com/windows/uwp/launch-resume/resume-an-app)

## -examples

## -capabilities
appDiagnostics
