---
-api-id: T:Windows.ApplicationModel.UserActivities.UserActivityRequest
-api-type: winrt class
---

<!-- Class syntax.
public class UserActivityRequest
-->

# Windows.ApplicationModel.UserActivities.UserActivityRequest

## -description
Passed as an argument to the [UserActivityRequestManager.UserActivityRequested](useractivityrequestmanager_useractivityrequested.md) event. Used to return a [UserActivity](useractivity.md) to the caller.

## -remarks
If the system is taking action that it wants to associate with a new user activity within an app, the system raises the [UserActivityRequestManager.UserActivityRequested](useractivityrequestmanager_useractivityrequested.md) event, and the app returns a **UserActivity** via the event args.

## -see-also
[UserActivityRequestManager.UserActivityRequested](useractivityrequestmanager_useractivityrequested.md)

## -examples
