---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.DisableAllAccessoryNotificationTypes
-api-type: winrt method
---

<!-- Method syntax
public void DisableAllAccessoryNotificationTypes()
-->

# Windows.Phone.Notification.Management.AccessoryManager.DisableAllAccessoryNotificationTypes

## -description
Opt out of getting notifications for toast and application uninstallation.

## -remarks
Only [AccessoryNotificationType.AppUninstall](/uwp/api/windows.phone.notification.management.accessorynotificationtype) and [AccessoryNotificationType.Toast](accessorynotificationtype.md) will use the settings made by [DisableNotificationsForApplication](accessorymanager_disablenotificationsforapplication_1278092887.md). For example, [AlarmNotificationTriggerDetails.AccessoryNotificationType](alarmnotificationtriggerdetails_accessorynotificationtype.md) will notify of alarm activity regardless of what is set by these two methods.

Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also

## -capabilities
accessoryManager
