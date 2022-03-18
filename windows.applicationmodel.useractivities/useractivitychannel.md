---
-api-id: T:Windows.ApplicationModel.UserActivities.UserActivityChannel
-api-type: winrt class
---

<!-- Class syntax.
public class UserActivityChannel
-->

# Windows.ApplicationModel.UserActivities.UserActivityChannel

## -description

Creates or gets [UserActivity](useractivity.md) objects created on this or another device.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | DisableAutoSessionCreation |
| 1803 | 17134 | GetRecentUserActivitiesAsync |
| 1803 | 17134 | GetSessionHistoryItemsForUserActivityAsync |
| 1803 | 17134 | TryGetForWebAccount |
| 1903 | 18362 | GetForUser |

## -see-also

See [Continue user activity, even across devices](/windows/uwp/launch-resume/useractivities) for more information about how to use User Activities with Windows Timeline to help users resume what they were doing on their PC, and across devices.

## -examples

```csharp
    // Get the default UserActivityChannel and query it for our UserActivity. If the activity doesn't exist, one is created.
    UserActivityChannel channel = UserActivityChannel.GetDefault();
    UserActivity userActivity = await channel.GetOrCreateUserActivityAsync("AddCustomerPage");
 ```
