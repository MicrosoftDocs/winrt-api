---
-api-id: T:Windows.ApplicationModel.Background.UserNotificationChangedTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class UserNotificationChangedTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger
-->

# Windows.ApplicationModel.Background.UserNotificationChangedTrigger

## -description
Represents a trigger that fires when a [UserNotification](../windows.ui.notifications/usernotification.md) is added or removed.

## -remarks
The user notification listener requires that explicit user permission be granted before it may be used. Call [BackgroundExecutionManager.RequestAccessAsync](/uwp/api/windows.applicationmodel.background.backgroundexecutionmanager.RequestAccessAsync) from the UI thread before attempting to access notifications.

## -examples

## -see-also
[IBackgroundTrigger](ibackgroundtrigger.md)
