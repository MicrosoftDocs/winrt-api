---
-api-id: P:Windows.UI.Notifications.ScheduledToastNotification.SnoozeInterval
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.TimeSpan> SnoozeInterval { get; }
-->

# Windows.UI.Notifications.ScheduledToastNotification.SnoozeInterval

## -description
Gets the amount of time between occurrences of the notification.

## -property-value
The time between occurrences of the notification. This value will be between 60 seconds and 60 minutes, inclusive.

## -remarks
This value is set when the [ScheduledToastNotification](scheduledtoastnotification.md) object is created.

## -examples

## -see-also
[Scheduled notifications sample](http://code.msdn.microsoft.com/windowsapps/scheduled-notifications-da477093), [Toast schema](https://docs.microsoft.com/uwp/schemas/tiles/toastschema/schema-root), [Guidelines and checklist for scheduled notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
