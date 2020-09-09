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
[ScheduledToastNotification(XmlDocument, DateTime, TimeSpan, UInt32)](scheduledtoastnotification_scheduledtoastnotification_1365784316.md), [Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Toast schema](/uwp/schemas/tiles/toastschema/schema-root), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
