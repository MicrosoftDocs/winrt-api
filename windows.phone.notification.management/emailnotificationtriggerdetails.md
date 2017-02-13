---
-api-id: T:Windows.Phone.Notification.Management.EmailNotificationTriggerDetails
-api-type: winrt class
---

<!-- Class syntax.
public class EmailNotificationTriggerDetails : Windows.Phone.Notification.Management.IAccessoryNotificationTriggerDetails, Windows.Phone.Notification.Management.IEmailNotificationTriggerDetails, Windows.Phone.Notification.Management.IEmailNotificationTriggerDetails2
-->

# Windows.Phone.Notification.Management.EmailNotificationTriggerDetails

## -description
Represents all information necessary to render an email notification on an accessory.

## -remarks
> [!IMPORTANT]
> When the phone is pin locked, email notifications may come in with no information due to Data Protection Under pin Lock (DPUL). This feature is enabled by the end-user.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
[IAccessoryNotificationTriggerDetails](iaccessorynotificationtriggerdetails.md)