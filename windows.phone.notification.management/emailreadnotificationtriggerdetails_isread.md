---
-api-id: P:Windows.Phone.Notification.Management.EmailReadNotificationTriggerDetails.IsRead
-api-type: winrt property
---

<!-- Property syntax
public bool IsRead { get; }
-->

# Windows.Phone.Notification.Management.EmailReadNotificationTriggerDetails.IsRead

## -description
Represents whether an email has been read.

## -property-value
true if the email has been read, otherwise false.

## -remarks
The AccessoryManager will wake up the BackgroundTask when it encounters a read status change on an email. The BackgroundTask is provided an IBackgroundTaskInstance which has a TriggerDetails property that contains the IEmailReadNotificationTriggerDetails.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

The [VersionAvailable](http://msdn.microsoft.com/library/a9b27475-77d4-4e5c-8577-ca155232afdb) property can be used to determine which version of Windows Phone includes a specific API.

## -examples

## -see-also
