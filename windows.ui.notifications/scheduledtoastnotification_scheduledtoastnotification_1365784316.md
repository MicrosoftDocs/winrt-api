---
-api-id: M:Windows.UI.Notifications.ScheduledToastNotification.#ctor(Windows.Data.Xml.Dom.XmlDocument,Windows.Foundation.DateTime,Windows.Foundation.TimeSpan,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public ScheduledToastNotification(Windows.Data.Xml.Dom.XmlDocument content, Windows.Foundation.DateTime deliveryTime, Windows.Foundation.TimeSpan snoozeInterval, System.UInt32 maximumSnoozeCount)
-->

# Windows.UI.Notifications.ScheduledToastNotification.ScheduledToastNotification

## -description
Deprecated in Windows 10. On Windows 8 systems, creates and initializes a new instance of a [ScheduledToastNotification](scheduledtoastnotification.md) that re-appears after a specified time after initially appearing. On Windows 10, this functions equivalently to [ScheduledToastNotification(XmlDocument, DateTime)](windows.ui.notifications/scheduledtoastnotification_scheduledtoastnotification_1677895932.md). To achieve the same snooze interval behavior in Windows 10, you can use [buttons on your toasts](/windows/uwp/design/shell/tiles-and-notifications/adaptive-interactive-toasts#buttons).

## -parameters
### -param content
The XML that defines the toast notification content.

### -param deliveryTime
The date and time that Windows should first display the toast notification. You must call [AddToSchedule](toastnotifier_addtoschedule_1355516744.md) before this time.

### -param snoozeInterval
The amount of time between occurrences of the notification. To be valid, this value must be no less than 60 seconds and no more than 60 minutes.

### -param maximumSnoozeCount
The maximum number of times to display this notification. Valid values range from 1 to 5.

## -remarks
This type of snooze interval scheduled toast notification is good for a snooze alarm-like functionality. For instance, the notification could be displayed every five minutes until the maximum snooze count is reached, unless the notification is explicitly removed from the schedule by your app.



> [!IMPORTANT]
> Your app is responsible for removing the notification from the schedule once the user activates the notification through a touch or click. Failure to do so can cause the notification to re-appear until the maximum snooze count is reached, even if the user has already dealt with it.

If you want to schedule long snooze intervals like months or years, we recommend that you use individual scheduled toasts rather than this method. That will avoid timing errors caused by daylight savings time or leap years.

The following code shows a call to this method that displays a toast beginning at *myData* every five minutes for a maximum of three times. 

```javascript
new ScheduledToastNotification(toast1, myDate, 60000, 3)
```



## -examples
The following example shows a toast notification scheduled to display in one hour, including the use of this constructor to create the notification, specifying a snooze interval of 60 seconds and a maximum of five times to show the notification.

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
var toast = new Notifications.ScheduledToastNotification(toastXml, dueTime, 60 * 1000, 5);
toast.id = "Toast" + idNumber;

// Add to the schedule.
Notifications.ToastNotificationManager.createToastNotifier().addToSchedule(toast);
```



## -see-also
[ScheduledToastNotification(XmlDocument, DateTime)](scheduledtoastnotification_scheduledtoastnotification_1677895932.md), [Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Toast schema](/uwp/schemas/tiles/toastschema/schema-root), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
