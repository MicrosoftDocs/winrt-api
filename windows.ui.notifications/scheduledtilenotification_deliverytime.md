---
-api-id: P:Windows.UI.Notifications.ScheduledTileNotification.DeliveryTime
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.DateTime DeliveryTime { get; }
-->

# Windows.UI.Notifications.ScheduledTileNotification.DeliveryTime

## -description
Gets the time at which the tile is scheduled to be updated.

## -property-value
The date and time that the notification will be updated.

## -remarks
This value is set when the [ScheduledTileNotification](scheduledtilenotification.md) is created. For the tile to be updated at the specified time, the notification must be added to the schedule through the [TileUpdater.addToSchedule](tileupdater_addtoschedule_1446725541.md) method.

## -examples

## -see-also
[Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
