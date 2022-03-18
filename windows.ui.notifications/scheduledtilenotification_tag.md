---
-api-id: P:Windows.UI.Notifications.ScheduledTileNotification.Tag
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string Tag { get;  set; }
-->

# Windows.UI.Notifications.ScheduledTileNotification.Tag

## -description
Gets or sets a string that Windows can use to prevent duplicate notification content from appearing in the queue.

## -property-value
A string of 16 characters or less (plus a terminating null character) that identifies the notification in the stack. While there is no set form for the string content, we recommend that it should relate to the content of the notification.

## -remarks
ScheduledTileNotification.tag and [ScheduledTileNotification.id](scheduledtilenotification_id.md) serve similar purposes: 
+ The ScheduledTileNotification.tag property is used by Windows to prevent duplicate notification content from appearing in the queue at the same time. It allows the notification to be updated in-place in the queue to prevent it from containing out-of-date information.
+ The [ScheduledTileNotification.id](scheduledtilenotification_id.md) property identifies the notification in the schedule. This allows the notification to be identified or removed from the schedule.

## -examples

## -see-also
[Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
