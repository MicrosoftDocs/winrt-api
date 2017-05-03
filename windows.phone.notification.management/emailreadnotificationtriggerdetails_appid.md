---
-api-id: P:Windows.Phone.Notification.Management.EmailReadNotificationTriggerDetails.AppId
-api-type: winrt property
---

<!-- Property syntax
public string AppId { get; }
-->

# Windows.Phone.Notification.Management.EmailReadNotificationTriggerDetails.AppId

## -description
The ID of the app associated with the notification, if applicable. This is not the ID of the app in the store. It is the ID of the app instance on the specific phone to uniquely identify the app.

## -property-value
A character string that specifies the ID of the app.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

The [VersionAvailable](http://msdn.microsoft.com/library/a9b27475-77d4-4e5c-8577-ca155232afdb) property can be used to determine which version of Windows Phone includes a specific API.

## -examples

## -see-also
