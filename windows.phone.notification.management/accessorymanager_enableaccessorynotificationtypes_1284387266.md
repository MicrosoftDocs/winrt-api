---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.EnableAccessoryNotificationTypes(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void EnableAccessoryNotificationTypes(System.Int32 accessoryNotificationTypes)
-->

# Windows.Phone.Notification.Management.AccessoryManager.EnableAccessoryNotificationTypes

## -description
Opt into getting notifications for toast or app uninstallation.

## -parameters
### -param accessoryNotificationTypes
One of the values specified by the [AccessoryNotificationType](accessorynotificationtype.md) enumeration.

## -remarks
Only **AccessoryNotificationType.AppUninstall** and** AccessoryNotificationType.Toast** will use the settings made by [DisableNotificationsForApplication](accessorymanager_disablenotificationsforapplication.md). For example, [AlarmNotificationTriggerDetails.AccessoryNotificationType](alarmnotificationtriggerdetails_accessorynotificationtype.md) will notify of alarm activity regardless of what is set by these two methods.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
