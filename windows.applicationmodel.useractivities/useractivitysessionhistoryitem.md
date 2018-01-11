---
-api-id: T:Windows.ApplicationModel.UserActivities.UserActivitySessionHistoryItem
-api-type: winrt class
---

<!-- Class syntax.
public class UserActivitySessionHistoryItem
-->

# Windows.ApplicationModel.UserActivities.UserActivitySessionHistoryItem
Provides the start and end time for when a user was engaged in a particular activity.

## -description

## -remarks
Many applications provide most-recently-used (MRU) lists. For example, "Recent Documents". This class provides start and end time information about a [UserActivity](useractivity.md) so that you can provide a similar experience for user activities.

## -see-also

## -examples
```csharp
private async void UpdateMRU()
{
    UserActivityChannel channel = UserActivityChannel.GetDefault();

    // Returns the 10 most recently engaged UserActivity objects, sorted by engagement EndTime (null EndTime first)
    IList<UserActivitySessionHistoryItem> recentActivity = await channel.GetRecentUserActivitiesAsync(maxUniqueActivities: 10);

    foreach (var activity in recentActivity)
    {
        List<UserActivitySessionHistoryItem> engagements = await channel.GetSessionHistoryItemsForUserActivityAsync(activity.ActivityId, new DateTimeOffset(DateTime.Now, TimeSpan.FromDays(1)));

        //EndTime may be null for active activities,
        if (e.EngagementTime.EndTime != null
        {
            long totalEngagementTime = engagements.Sum(e => e.EngagementTime.EndTime.Ticks - e.EngagementTime.StartTime.Ticks);
            // Your implementation here, e.g. AddMRUTileToGridView(activity, totalEngagementTime);
        }
    }
}
```
