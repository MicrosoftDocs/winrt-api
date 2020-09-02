---
-api-id: T:Windows.UI.Notifications.ScheduledToastNotification
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ScheduledToastNotification : Windows.UI.Notifications.IScheduledToastNotification, Windows.UI.Notifications.IScheduledToastNotification2, Windows.UI.Notifications.IScheduledToastNotification3
-->

# Windows.UI.Notifications.ScheduledToastNotification

## -description
Contains the XML that defines the toast notification that will display at the scheduled time.

## -remarks
Create and initialize a new instance of this object by calling [ScheduledToastNotification](scheduledtoastnotification_scheduledtoastnotification_1365784316.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | NotificationMirroring |
| 1607 | 14393 | RemoteId |
| 1803 | 17134 | ExpirationTime |

## -examples
The following example shows a toast notification scheduled to display in one hour.

```javascript

var Notifications = Windows.UI.Notifications;
var currentTime = new Date();
var seconds = 60;
var dueTime = new Date(currentTime.getTime() + seconds * 60 * 1000);
var idNumber = Math.floor(Math.random() * 100000000);  // Generates a unique ID number for the notification.

// Set up the notification text.
var toastXml = Notifications.ToastNotificationManager.getTemplateContent(Notifications.ToastTemplateType.toastText02);
var strings = toastXml.getElementsByTagName("text");
strings[0].appendChild(toastXml.createTextNode(This is a scheduled toast notification));
strings[1].appendChild(toastXml.createTextNode("Received: " + dueTime.toLocaleTimeString()));

// Create the toast notification object.
var toast = new Notifications.ScheduledToastNotification(toastXml, dueTime);
toast.id = "Toast" + idNumber;

// Add to the schedule.
Notifications.ToastNotificationManager.createToastNotifier().addToSchedule(toast);
```



## -see-also
[Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Toast schema](/uwp/schemas/tiles/toastschema/schema-root), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
