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
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)