---
-api-id: M:Windows.ApplicationModel.Core.CoreApplication.RequestRestartForUserAsync(Windows.System.User,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<RestartResult> CoreApplication.RequestRestartForUserAsync(User user, String launchArguments)
-->

# Windows.ApplicationModel.Core.CoreApplication.RequestRestartForUserAsync

## -description
Restart the app in the context of a different user.

## -parameters
### -param user
The user to restart the app as.

### -param launchArguments
The arguments to pass to the restarted instance.

## -returns
The status of the restart request.

## -remarks
* The app must be visible and foreground when it calls this API.
* If the restart fails, but the user subsequently launches the app manually, the app will launch normally and no restart arguments will be passed.
* If the app wasn't launched in the normal way, but was launched by a share contract, file picker, app-service, and so on, the app should not call this API because the user will not expect the resulting behavior.
* The app is responsible for ensuring the validity of the **User** object. The activation will fail if there is policy in place which prevents that user from executing the app.
* The app should not request an Extended Execution session after it has called this API because that will result in a poor user experience.
* If the app has any in-process background tasks running when it calls this API, those tasks will be cancelled in the normal way. Out-of-process background tasks will not be affected.
* When the app is restarted, [LaunchActivatedEventArgs.PreviousExecutionState](/uwp/api/Windows.ApplicationModel.Activation.LaunchActivatedEventArgs) will have the value **Terminated** so that the app can distinguish between a resume and a restart.

## -see-also
[Windows.ApplicationModel.Core.CoreApplication.RequestRestartAsync](coreapplication_requestrestartasync_172604043.md), [How to restart your app programmatically](https://blogs.windows.com/buildingapps/2017/07/28/restart-app-programmatically/#oPS3xDHQYpflJRkA.97)

## -examples
```csharp
private async void RestartAsAnotherUser(string selectedUser)
{
    IReadOnlyList<User> users = await User.FindAllAsync();
    foreach (User user in users)
    {
        object accountProperty =
            await user.GetPropertyAsync(KnownUserProperties.AccountName);
        string accountName = (string)accountProperty;
        if (accountName == selectedUser)
        {
            // Attempt restart, with arguments.
            AppRestartFailureReason result = await App.RequestRestartForUserAsync(
                user, "-fastInit -mainMenu");

            // Restart request denied, tell the user to restart manually.
            if (result== AppRestartFailureReason.InvalidUser)
            {
                SendToast(string.Format("Could not restart as user {0} - please manually restart.", user));
            }
        }
    }
}
```
