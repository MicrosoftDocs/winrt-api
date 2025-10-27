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



```csharp
var currentTime = DateTime.Now;
var seconds = 60;
var dueTime = currentTime.AddSeconds(seconds * 60);
var idNumber = new Random().Next(0, 100000000);

var toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);
var strings = toastXml.GetElementsByTagName("text");
strings[0].AppendChild(toastXml.CreateTextNode("This is a scheduled toast notification"));
strings[1].AppendChild(toastXml.CreateTextNode("Received: " + dueTime.ToLocalTime().ToString()));

var toast = new ScheduledToastNotification(toastXml, dueTime);
toast.Id = "Toast" + idNumber;

ToastNotificationManager.CreateToastNotifier().AddToSchedule(toast);
```



## -see-also
[Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Toast schema](/uwp/schemas/tiles/toastschema/schema-root), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)

