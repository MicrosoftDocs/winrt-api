---
-api-id: P:Windows.UI.Notifications.ScheduledToastNotification.MaximumSnoozeCount
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public uint MaximumSnoozeCount { get; }
-->

# Windows.UI.Notifications.ScheduledToastNotification.MaximumSnoozeCount

## -description
Gets the maximum number of times to display this notification.

## -property-value
The maximum number of times to display this notification. This will be a value between 1 and 5, inclusive.

## -remarks
Note that this is the number of repeat showings specified when the [ScheduledToastNotification](scheduledtoastnotification.md) is created. It is not the number of showings remaining if the toast has already been shown. There is no method to directly retrieve that information.

## -examples

## -see-also
[Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Toast schema](/uwp/schemas/tiles/toastschema/schema-root), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
