---
-api-id: M:Windows.UI.Notifications.ScheduledToastNotification.#ctor(Windows.Data.Xml.Dom.XmlDocument,Windows.Foundation.DateTime)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public ScheduledToastNotification(Windows.Data.Xml.Dom.XmlDocument content, Windows.Foundation.DateTime deliveryTime)
-->

# Windows.UI.Notifications.ScheduledToastNotification.ScheduledToastNotification

## -description
Creates and initializes a new instance of a [ScheduledToastNotification](scheduledtoastnotification.md) that will be displayed only once.

## -parameters
### -param content
The XML that defines the toast notification content.

### -param deliveryTime
The date and time that Windows should display the toast notification. You must call [AddToSchedule](toastnotifier_addtoschedule_1355516744.md) before this time.

## -remarks

## -examples
The following example shows a toast notification scheduled to display in one hour, including the use of this constructor to create the notification.



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
[ScheduledToastNotification(XmlDocument, DateTime, TimeSpan, UInt32)](scheduledtoastnotification_scheduledtoastnotification_1365784316.md), [Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Toast schema](/uwp/schemas/tiles/toastschema/schema-root), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)

