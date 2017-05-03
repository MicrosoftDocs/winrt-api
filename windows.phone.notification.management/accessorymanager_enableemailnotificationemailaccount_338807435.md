---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.EnableEmailNotificationEmailAccount(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void EnableEmailNotificationEmailAccount(System.String emailAccount)
-->

# Windows.Phone.Notification.Management.AccessoryManager.EnableEmailNotificationEmailAccount

## -description
Enables email notifications for specified email account.

## -parameters
### -param emailAccount
String containing the name of the email account.

## -remarks
> [!IMPORTANT]
> When the phone is pin locked, email notifications may come in with no information due to Data Protection Under pin Lock (DPUL). This feature is enabled by the end-user.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.


## -examples

## -see-also
