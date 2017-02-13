---
-api-id: M:Windows.Phone.Notification.Management.AccessoryManager.GetEnabledAccessoryNotificationTypes
-api-type: winrt method
---

<!-- Method syntax
public int GetEnabledAccessoryNotificationTypes()
-->

# Windows.Phone.Notification.Management.AccessoryManager.GetEnabledAccessoryNotificationTypes

## -description
Gets a list of enable notification types, as represented by the [AccessoryNotificationType](accessorynotificationtype.md) enumeration.

## -returns
The values are bit flags combinations of the flags in the [AccessoryNotificationType](accessorynotificationtype.md) enumeration. You can OR the enum values together to indicate which notification types to be alerted for.

## -remarks
Calling this API requires that the **ID_CAP_SMS** and **ID_CAP_SMS_COMPANION** capabilities be specified in the application manifest.

## -examples

## -see-also
