---
-api-id: T:Windows.ApplicationModel.UserActivities.UserActivitySessionHistoryItem
-api-type: winrt class
---

<!-- Class syntax.
public class UserActivitySessionHistoryItem
-->

# Windows.ApplicationModel.UserActivities.UserActivitySessionHistoryItem

## -description
Provides the start and end time that a user was engaged in a particular activity.

## -remarks
Many applications provide most-recently-used (MRU) lists. This class provides start and end time information about a [UserActivity](useractivity.md) so that you can provide a similar experience for user activities.

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
