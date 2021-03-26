---
-api-id: M:Windows.UI.Notifications.ToastNotifier.GetScheduledToastNotifications
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.UI.Notifications.ScheduledToastNotification> GetScheduledToastNotifications()
-->

# Windows.UI.Notifications.ToastNotifier.GetScheduledToastNotifications

## -description
Gets the collection of [ScheduledToastNotification](scheduledtoastnotification.md) objects that this app has scheduled for display.

> [!IMPORTANT]
> This method is only supported in applications which use WinRT as their default application framework.

## -returns
The collection of scheduled toast notifications that the app bound to this notifier has scheduled for timed display.

## -remarks

## -examples
The following example shows the use of the GetScheduledToastNotifications method.

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
