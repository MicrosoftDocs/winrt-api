---
-api-id: M:Windows.UI.Notifications.ToastNotifier.RemoveFromSchedule(Windows.UI.Notifications.ScheduledToastNotification)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void RemoveFromSchedule(Windows.UI.Notifications.ScheduledToastNotification scheduledToast)
-->

# Windows.UI.Notifications.ToastNotifier.RemoveFromSchedule

## -description
Cancels the scheduled display of a specified [ScheduledToastNotification](scheduledtoastnotification.md).

> [!IMPORTANT]
> This method is only supported in applications which use WinRT as their default application framework.

## -parameters
### -param scheduledToast
The notification to remove from the schedule.

## -remarks
If you want to cancel one or more scheduled toast notifications, you can use the [GetScheduledToastNotifications](toastnotifier_getscheduledtoastnotifications_1959697028.md) method to get the full list.

## -examples
The following example shows the use of the RemoveFromSchedule method.

```javascript
var notifier = Notifications.ToastNotificationManager.createToastNotifier();
var scheduled = notifier.getScheduledToastNotifications();                    

for (var i = 0, len = scheduled.length; i < len; i++) {
    
    // The itemId value is the unique ScheduledTileNotification.Id assigned to the 
    // notification when it was created.
    if (scheduled[i].id === itemId) {
        notifier.removeFromSchedule(scheduled[i]);
    }
}
```



## -see-also
