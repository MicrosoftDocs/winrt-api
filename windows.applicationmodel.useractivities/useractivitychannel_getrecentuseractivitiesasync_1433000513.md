---
-api-id: M:Windows.ApplicationModel.UserActivities.UserActivityChannel.GetRecentUserActivitiesAsync(System.Int32)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<IList<UserActivitySessionHistoryItem>> UserActivityChannel.GetRecentUserActivitiesAsync(Int32 maxUniqueActivities)
-->

# Windows.ApplicationModel.UserActivities.UserActivityChannel.GetRecentUserActivitiesAsync

## -description
Get up to the specified number of the most recently engaged user activities, sorted by the time each user activity ended.

## -parameters
### -param maxUniqueActivities
The maximum number of user activities to get. Fewer may be returned if there aren't as many user activities as requested.

## -returns
A list of user activities, sorted by when the activities ended.

## -remarks
User activities with a `null` end time appear first in the list.

## -see-also

## -examples
