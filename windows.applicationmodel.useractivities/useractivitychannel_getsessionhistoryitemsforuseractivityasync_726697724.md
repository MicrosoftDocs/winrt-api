---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivityChannel.GetSessionHistoryItemsForUserActivityAsync(System.String,Windows.Foundation.DateTime)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<UserActivitySessionHistoryItem>> UserActivityChannel.GetSessionHistoryItemsForUserActivityAsync(String activityId, DateTime startTime)
-->

# Windows.ApplicationModel.UserActivities.UserActivityChannel.GetSessionHistoryItemsForUserActivityAsync

## -description
Gets the session history for a user activity.

## -parameters
### -param activityId
Identifies the user activity to get session history for.

### -param startTime
Get user activity sessions that were active between **startTime** and now.

## -returns
A list of user activity session objects that were active during the specified time for the specified user activity.

## -remarks

## -see-also

## -examples

```csharp
private async void GetMostRecentActivity()
{
    UserActivityChannel channel = UserActivityChannel.GetDefault();

    // Gets the 10 most recently engaged UserActivity objects, sorted by engagement EndTime (null EndTimes sort first)
    IList<UserActivitySessionHistoryItem> recentActivity = await channel. GetRecentUserActivitiesAsync(maxUniqueActivities: 10);

    foreach (var activity in recentActivity)
    {
        var engagements = await channel.GetSessionHistoryItemsForUserActivityAsync(activity.UserActivity.ActivityId, new DateTimeOffset(DateTime.Now, TimeSpan.FromDays(1)));

        long totalEngagementTime = 0;
        foreach(var e in engagements)
        {
            if (e.EndTime != null) // EndTime may be null for active UserActivities
            {
                totalEngagementTime += e.EndTime.Value.Ticks - e.StartTime.Ticks);
            }
            // App specific code to display the activity engagement time
        }
    }
}
```
