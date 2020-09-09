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

```javascript

var notifications = Windows.UI.Notifications;

// Get the toast notification manager for the current app.
var notificationManager = notifications.ToastNotificationManager;

// The getTemplateContent method returns a Windows.Data.Xml.Dom.XmlDocument object
// that contains the toast notification XML content.
var template = notifications.ToastTemplateType.toastImageAndText01;
var toastXml = notificationManager.getTemplateContent(template);
var template = notifications.toastTemplateType.toastImageAndText01;
var toastXml = notificationManager.getTemplateContent(notifications.ToastTemplateType[template]);

// You can use the methods from the XML document to specify the required elements for the toast.
var images = toastXml.getElementsByTagName("image");
images[0].setAttribute("src", "images/toastImageAndText.png");

var textNodes = toastXml.getElementsByTagName("text");
textNodes.forEach(function (value, index) {
    var textNumber = index + 1;
    var text = "";
    for (var j = 0; j < 10; j++) {
        text += "Text input " + /*@static_cast(String)*/textNumber + " ";
    }
    value.appendChild(toastXml.createTextNode(text));
});

// Create a toast notification from the XML, then create a ToastNotifier object
// to send the toast.
var toast = new notifications.ToastNotification(toastXml);

notificationManager.createToastNotifier().show(toast);
```

The following example shows the use of the [GetScheduledToastNotifications](toastnotifier_getscheduledtoastnotifications_1959697028.md) and [RemoveFromSchedule](toastnotifier_removefromschedule_833207209.md) methods.

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
[Toast content](/windows/uwp/design/shell/tiles-and-notifications/adaptive-interactive-toasts), [Toast content schema](/windows/uwp/design/shell/tiles-and-notifications/toast-schema), [Send a local toast notification](/windows/uwp/design/shell/tiles-and-notifications/send-local-toast), [Windows Notifications GitHub samples](https://github.com/WindowsNotifications)
