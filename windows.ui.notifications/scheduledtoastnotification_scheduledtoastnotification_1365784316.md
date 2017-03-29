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
Creates and initializes a new instance of a recurring [ScheduledToastNotification](scheduledtoastnotification.md).

## -parameters
### -param content
The XML that defines the toast notification content.

### -param deliveryTime
The date and time that Windows should first display the toast notification. You must call [AddToSchedule](toastnotifier_addtoschedule.md) before this time.

### -param snoozeInterval
The amount of time between occurrences of the notification. To be valid, this value must be no less than 60 seconds and no more than 60 minutes.

### -param maximumSnoozeCount
The maximum number of times to display this notification. Valid values range from 1 to 5.

## -remarks
This type of recurring scheduled toast notification is good for a snooze alarm-like functionality. For instance, the notification could be displayed every five minutes until the maximum snooze count is reached, unless the notification is explicitly removed from the schedule in response to a user action.



> [!IMPORTANT]
> The sender is responsible for removing the notification from the schedule once the user activates the notification through a touch or click. Failure to do so can see the notification recurring until the maximum snooze count is reached, even if the user has already dealt with it.

If you want to schedule long recurrence intervals like months or years, we recommend that you use individual scheduled toasts rather than this method. That will avoid timing errors caused by daylight savings time or leap years.

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
[ScheduledToastNotification(XmlDocument, DateTime)](scheduledtoastnotification_scheduledtoastnotification_1677895932.md), [Scheduled notifications sample](http://go.microsoft.com/fwlink/p/?linkid=241614), [Toast schema](XREF:TODO:toast.Schema_Root), [Guidelines and checklist for scheduled notifications](http://msdn.microsoft.com/library/ca9e9121-d1b1-461f-9c7e-b25225d917ca)