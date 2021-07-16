---
-api-id: T:Windows.ApplicationModel.UserActivities.UserActivityRequestedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class UserActivityRequestedEventArgs
-->

# Windows.ApplicationModel.UserActivities.UserActivityRequestedEventArgs

## -description
Passed to the [UserActivityRequestManager.UserActivityRequested](useractivityrequestmanager_useractivityrequested.md) event. Allows the handler of the event to pass back a [UserActivity](useractivity.md).

## -remarks

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
