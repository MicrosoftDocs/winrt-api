---
-api-id: T:Windows.UI.Notifications.ToastNotificationMode
-api-type: winrt enum
---

# Windows.UI.Notifications.ToastNotificationMode

<!--
public enum ToastNotificationMode
-->


## -description

Specifies the notification mode, which determines the set of notifications that are shown to the user.

## -enum-fields

### -field Unrestricted: 0

All notifications are allowed, including push notifications and other types of system notifications.

### -field PriorityOnly: 1

Allows only notifications marked as “priority” to be displayed, which is similar to the Do Not Disturb mode in Windows 11, where only certain priority notifications are allowed to be displayed (e.g. notifications from important contacts or apps).

### -field AlarmsOnly: 2

Allows only alert-like notifications to be shown, meaning that any non-alarm notifications are suppressed.

## -remarks

This enumeration is used by the [ToastNotificationManagerForUser.NotificationMode](toastnotificationmanagerforuser_notificationmode.md) property.

## -see-also

## -examples




