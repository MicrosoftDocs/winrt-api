---
-api-id: T:Windows.UI.Notifications.ToastNotifier
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ToastNotifier : Windows.UI.Notifications.IToastNotifier, Windows.UI.Notifications.IToastNotifier2
-->

# Windows.UI.Notifications.ToastNotifier

## -description
Raises a toast notification to the specific app to which the ToastNotifier is bound. This class also lets you schedule and remove toast notifications.

## -remarks
When it is created, ToastNotifier is bound to a specific app, so the methods of this class affect only that app.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Update(NotificationData,String,String) |
| 1703 | 15063 | Update(NotificationData,String) |
| 1809 | 17763 | ScheduledToastNotificationShowing |

## -examples
The following example shows how to create and send a toast notification that includes text and images, including use of the [Show](toastnotifier_show_184420709.md) method.



```csharp
var notificationManager = ToastNotificationManager;
var template = ToastTemplateType.ToastImageAndText01;
var toastXml = notificationManager.GetTemplateContent(template);

var images = toastXml.GetElementsByTagName("image");
images[0].SetAttribute("src", "images/toastImageAndText.png");

var textNodes = toastXml.GetElementsByTagName("text");
textNodes[0].AppendChild(toastXml.CreateTextNode("Text input 1"));

var toast = new ToastNotification(toastXml);
notificationManager.CreateToastNotifier().Show(toast);
```

The following example shows the use of the [GetScheduledToastNotifications](toastnotifier_getscheduledtoastnotifications_1959697028.md) and [RemoveFromSchedule](toastnotifier_removefromschedule_833207209.md) methods.



```csharp
var notifier = ToastNotificationManager.CreateToastNotifier();
var scheduled = notifier.GetScheduledToastNotifications();

for (int i = 0; i < scheduled.Count; i++) {
    if (scheduled[i].Id == itemId) {
        notifier.RemoveFromSchedule(scheduled[i]);
    }
}
```



## -see-also
[Toast content](/windows/uwp/design/shell/tiles-and-notifications/adaptive-interactive-toasts), [Toast content schema](/windows/uwp/design/shell/tiles-and-notifications/toast-schema), [Send a local toast notification](/windows/uwp/design/shell/tiles-and-notifications/send-local-toast), [Windows Notifications GitHub samples](https://github.com/WindowsNotifications)

