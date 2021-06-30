---
-api-id: M:Windows.ApplicationModel.Core.CoreApplication.RequestRestartAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<RestartResult> CoreApplication.RequestRestartAsync(String launchArguments)
-->

# Windows.ApplicationModel.Core.CoreApplication.RequestRestartAsync

## -description
Restart the app.

## -parameters
### -param launchArguments
The arguments to pass to the restarted instance.

## -returns
The status of the restart request.

## -remarks
* The app must be visible and foreground when it calls this API.
* If the restart fails, but the user subsequently launches the app manually, the app will launch normally and no restart arguments will be passed.
* If the app wasn't launched in the normal way, but was launched by a share contract, file picker, app-service, and so on, the app should not call this API because the user will not expect the resulting behavior.
* The app should not request an Extended Execution session after it has called this API because that will result in a poor user experience.
* If the app has any in-process background tasks running when it calls this API, those tasks will be cancelled in the normal way. Out-of-process background tasks will not be affected.
* When the app is restarted, [LaunchActivatedEventArgs.PreviousExecutionState](/uwp/api/Windows.ApplicationModel.Activation.LaunchActivatedEventArgs) will have the value **Terminated** so that the app can distinguish between a resume and a restart.

## -see-also
[Windows.ApplicationModel.Core.CoreApplication.RequestRestartAsyncForUser](coreapplication_requestrestartforuserasync_1889038893.md), [How to restart your app programmatically](https://blogs.windows.com/buildingapps/2017/07/28/restart-app-programmatically/#oPS3xDHQYpflJRkA.97)

## -examples

```csharp
private async void DoMajorAppReconfiguration()
{
    // Attempt restart, with arguments.
    AppRestartFailureReason result =
        await CoreApplication.RequestRestartAsync("-fastInit -level 1 -foo");

    // Restart request denied, send a toast to tell the user to restart manually.
    if (result == AppRestartFailureReason.NotInForeground
        || result == AppRestartFailureReason.Other)
    {
        SendToast("Please manually restart.");
    }
}

```
