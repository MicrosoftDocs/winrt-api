---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivityChannel.DeleteActivityAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction UserActivityChannel.DeleteActivityAsync(String activityId)
-->

# Windows.ApplicationModel.UserActivities.UserActivityChannel.DeleteActivityAsync

## -description
Delete a specific user activity.

## -parameters
### -param activityId
The identifier of the user activity to delete.

## -returns
An asynchronous action.

## -remarks
You can get the identifier of the user activity from [UserActivity.ActivityId](useractivity_activityid.md).
## -see-also

## -examples
```csharp
UserActivityChannel channel = UserActivityChannel.GetDefault();
string activityId = "/article?" + article.Link;
channel.DeleteActivity(activityId);
```
