---
-api-id: E:Windows.ApplicationModel.UserActivities.UserActivityRequestManager.UserActivityRequested
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler UserActivityRequested<UserActivityRequestManager, UserActivityRequestedEventArgs>
-->

# Windows.ApplicationModel.UserActivities.UserActivityRequestManager.UserActivityRequested

## -description
Raised when a request is made to the application to create an on-demand [UserActivity](useractivity.md) object.

## -remarks
This event is raised on the thread associated with the view that creates the **UserActivityRequestManager**.

## -see-also

## -examples

```csharp
protected override void OnNavigatedTo(NavigationEventArgs e)
{
    base.OnNavigatedTo(e);

    Windows.ApplicationModel.UserActivities.UserActivityRequestManager requestMgr = Windows.ApplicationModel.UserActivities.UserActivityRequestManager.GetForCurrentView();
    requestManager.UserActivityRequested += UserActivityRequested;
}

private async void UserActivityRequested(
    Windows.ApplicationModel.UserActivities.UserActivityRequestManager sender,
    Windows.ApplicationModel.UserActivities.UserActivityRequestedEventArgs args)
{
    // Instantiate an empty UserActivity object, or the application can reuse one from UserActivityChannel.GetOrCreateUserActivity
    Windows.ApplicationModel.UserActivities.UserActivity userActivity = // app code to create a new UserActivity;
    args.Request.SetUserActivity(userActivity);
}
```
