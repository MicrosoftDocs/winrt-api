---
-api-id: M:Windows.ApplicationModel.UserActivities.Core.CoreUserActivityManager.DeleteUserActivitySessionsInTimeRangeAsync(Windows.ApplicationModel.UserActivities.UserActivityChannel,Windows.Foundation.DateTime,Windows.Foundation.DateTime)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction CoreUserActivityManager.DeleteUserActivitySessionsInTimeRangeAsync(UserActivityChannel channel, DateTime startTime, DateTime endTime)
-->

# Windows.ApplicationModel.UserActivities.Core.CoreUserActivityManager.DeleteUserActivitySessionsInTimeRangeAsync

## -description
Delete user activities created during a specified timeframe.

## -parameters
### -param channel
The channel that was used to create the user activities.

### -param startTime
The beginning of the time range in which to delete user activities.

### -param endTime
The end of the time range in which to delete user activities.

## -returns
An asynchronous action.

## -remarks

## -see-also

## -examples
```csharp
public static async Task DeleteActiviesForDay(DateTime date)
{
    var startDate = date.Day;
    var endDate = date.Day + TimeSpan.FromDays(1);
    await Windows.ApplicationModel.UserActivities.Core.CoreUserActivityManager.DeleteUserActivitySessionsInTimeRangeAsync(UserActivityChannel.GetDefault(), startDate, endDate);
}
```
