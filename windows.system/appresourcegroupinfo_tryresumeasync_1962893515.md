---
-api-id: M:Windows.System.AppResourceGroupInfo.TryResumeAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> AppResourceGroupInfo.TryResumeAsync()
-->

# Windows.System.AppResourceGroupInfo.TryResumeAsync

## -description
Initiate moving the associated app to the active state.

## -returns
**True** indicates that the app was successfully suspended; **false**, otherwise. Calling **TryResumeAsync** on an app that is not suspended will result in a failure.

## -remarks
For an app in the suspended state, call this method to initiate the standard workflow to bring the app back to the active state. This workflow includes calling the app’s [Resuming](https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.application#Windows_UI_Xaml_Application_Resuming) callback. This method will return as soon as it has initiated the workflow, before the app’s Resuming callback, and before any state changes.

## -see-also
[Handle app resume](https://docs.microsoft.com/windows/uwp/launch-resume/resume-an-app)

## -examples

## -capabilities
appDiagnostics
