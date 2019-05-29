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
[Scheduled notifications sample](https://go.microsoft.com/fwlink/p/?linkid=241614), [Guidelines and checklist for scheduled notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
