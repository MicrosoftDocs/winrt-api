---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivityRequest.SetUserActivity(Windows.ApplicationModel.UserActivities.UserActivity)
-api-type: winrt method
---

<!-- Method syntax.
public void UserActivityRequest.SetUserActivity(UserActivity activity)
-->

# Windows.ApplicationModel.UserActivities.UserActivityRequest.SetUserActivity

## -description
Sets the [UserActivity](useractivity.md) to return when the [UserActivityRequested](useractivityrequestmanager_useractivityrequested.md) event is raised.

## -parameters
### -param activity
The user activity to store.

## -remarks
[UserActivity.ActivationUri](/uwp/api/windows.applicationmodel.useractivities.useractivity.ActivationUri) and **[UserActivity.VisualElements.DisplayText](/uwp/api/windows.applicationmodel.useractivities.useractivityvisualelements.DisplayText)** must be set or this method will fail.

## -see-also

## -examples
```csharp
private async void UserActivityRequested(
    Windows.ApplicationModel.UserActivities.UserActivityRequestManager sender,
    Windows.ApplicationModel.UserActivities.UserActivityRequestedEventArgs args)
{
    UserActivity userActivity = // app code to create a userActivity
    args.Request.SetUserActivity(userActivity);
}
```
