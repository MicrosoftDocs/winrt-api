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
[App tiles and badges sample](http://code.msdn.microsoft.com/windowsapps/app-tiles-and-badges-sample-5fc49148), [Scheduled notifications sample](https://go.microsoft.com/fwlink/p/?linkid=241614), [Guidelines and checklist for scheduled notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method), [Quickstart: Sending a tile update](https://docs.microsoft.com/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](https://docs.microsoft.com/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](https://docs.microsoft.com/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](https://docs.microsoft.com/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)
