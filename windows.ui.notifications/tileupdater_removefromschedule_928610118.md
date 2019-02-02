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
The following example shows the use of the [RemoveFromSchedule](tileupdater_removefromschedule_928610118.md) method.

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
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Scheduled notifications sample](https://go.microsoft.com/fwlink/p/?linkid=241614), [Guidelines and checklist for scheduled notifications](https://msdn.microsoft.com/library/ca9e9121-d1b1-461f-9c7e-b25225d917ca), [Quickstart: Sending a tile update](https://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](https://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](https://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](https://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](https://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](https://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)
