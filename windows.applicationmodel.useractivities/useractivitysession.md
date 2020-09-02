---
-api-id: T:Windows.ApplicationModel.UserActivities.UserActivitySession
-api-type: winrt class
---

<!-- Class syntax.
public class UserActivitySession : IClosable
-->

# Windows.ApplicationModel.UserActivities.UserActivitySession

## -description

Tracks a [UserActivity](useractivity.md) while the user is engaged in that activity.

## -remarks

A [UserActivity](useractivity.md) is associated with an **UserActivitySession** which tracks how long the user is engaged in that activity. For example, an activity such as watching a movie can occur a little at a time over the course of multiple days. When the user first starts the new activity of watching a movie, a **UserActivitySession** must be created. It should be disposed when the user switches to different activity. When the user resumes watching the movie, create another **UserActivitySession** from the original **UserActivity** to track the activity as long as the user is watching the movie.

## -see-also

See [Continue user activity, even across devices](/windows/uwp/launch-resume/useractivities) for more information about how to use User Activities with Windows Timeline to help users resume what they were doing on their PC, and across devices.

## -examples
