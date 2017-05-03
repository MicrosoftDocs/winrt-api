---
-api-id: T:Windows.Phone.Notification.Management.CalendarChangedNotificationTriggerDetails
-api-type: winrt class
---

<!-- Class syntax.
public class CalendarChangedNotificationTriggerDetails : Windows.Phone.Notification.Management.IAccessoryNotificationTriggerDetails, Windows.Phone.Notification.Management.ICalendarChangedNotificationTriggerDetails
-->

# Windows.Phone.Notification.Management.CalendarChangedNotificationTriggerDetails

## -description
Represents all information necessary to render a calendar changed notification on an accessory.

## -remarks
The AccessoryManager will wake up the BackgroundTask when it encounters a calendar change. The BackgroundTask is provided an IBackgroundTaskInstance which has a TriggerDetails property that contains the ICalendarChangedNotificationTriggerDetails.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

The [VersionAvailable](http://msdn.microsoft.com/library/a9b27475-77d4-4e5c-8577-ca155232afdb) property can be used to determine which version of Windows Phone includes a specific API.

## -examples

## -see-also
[IAccessoryNotificationTriggerDetails](iaccessorynotificationtriggerdetails.md)