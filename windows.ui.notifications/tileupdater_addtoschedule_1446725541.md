---
-api-id: M:Windows.UI.Notifications.TileUpdater.AddToSchedule(Windows.UI.Notifications.ScheduledTileNotification)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void AddToSchedule(Windows.UI.Notifications.ScheduledTileNotification scheduledTile)
-->

# Windows.UI.Notifications.TileUpdater.AddToSchedule

## -description
Adds a [ScheduledTileNotification](scheduledtilenotification.md) to the schedule.

## -parameters
### -param scheduledTile
The scheduled tile update object.

## -remarks
If your call to this method returns a failure code, examine these possible causes: 
+ **Possible cause**: You've exceeded the maximum allowed number of scheduled notifications.

**Fix**: TileUpdater.addToSchedule will fail if you attempt to schedule more than 4096 notifications. Reduce your number of scheduled notifications.
+ **Possible cause**: Your notification is scheduled for a time in the past relative to the current system clock time.

**Fix**: Make sure that the scheduled notification time is in the future. Examine the system clock time.


## -examples

## -see-also
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Scheduled notifications sample](https://go.microsoft.com/fwlink/p/?linkid=241614), [Guidelines and checklist for scheduled notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method), [Quickstart: Sending a tile update](https://docs.microsoft.com/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](https://docs.microsoft.com/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](https://docs.microsoft.com/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](https://docs.microsoft.com/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)
