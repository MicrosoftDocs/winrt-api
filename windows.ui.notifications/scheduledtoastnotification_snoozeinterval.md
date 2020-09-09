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
[Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Toast schema](/uwp/schemas/tiles/toastschema/schema-root), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
