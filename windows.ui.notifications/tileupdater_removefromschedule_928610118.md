---
-api-id: M:Windows.UI.Notifications.TileUpdater.RemoveFromSchedule(Windows.UI.Notifications.ScheduledTileNotification)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void RemoveFromSchedule(Windows.UI.Notifications.ScheduledTileNotification scheduledTile)
-->

# Windows.UI.Notifications.TileUpdater.RemoveFromSchedule

## -description
Removes an upcoming tile update from the schedule.

## -parameters
### -param scheduledTile
The notification to remove from the schedule.

## -remarks

## -examples
The following example shows the use of the RemoveFromSchedule method.

```javascript

var notifier = Notifications.TileUpdateManager.createTileUpdaterForApplication();
var scheduled = notifier.getScheduledTileNotifications();

for (var i = 0, len = scheduled.length; i < len; i++) {
    
    // The itemId value is the unique ScheduledTileNotification.Id assigned to the 
    // notification when it was created.
    if (scheduled[i].id === itemId) {
        notifier.removeFromSchedule(scheduled[i]);
    }
}
```

## -see-also
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)