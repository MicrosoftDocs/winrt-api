---
-api-id: T:Windows.UI.Notifications.TileUpdater
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class TileUpdater : Windows.UI.Notifications.ITileUpdater, Windows.UI.Notifications.ITileUpdater2
-->

# Windows.UI.Notifications.TileUpdater

## -description
Changes the content of the specific tile that the updater is bound to.

## -remarks
To get an instance of this object, call the [TileUpdateManager.CreateTileUpdaterForApplication](tileupdatemanager_createtileupdaterforapplication_1541898748.md) or [TileUpdateManager.CreateTileUpdaterForSecondaryTile](tileupdatemanager_createtileupdaterforsecondarytile_445640521.md) method.

When it is created, TileUpdater is bound to a specific app or secondary tile, so the methods of this class affect only the single tile that the object instance is bound to.

## -examples
The following example shows [Update](tileupdater_update_673402202.md) used to send a notification to the app's tile.



```csharp
var tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150Text03);
var tileAttributes = tileXml.GetElementsByTagName("text");
tileAttributes[0].AppendChild(tileXml.CreateTextNode("Hello World!"));

var tileNotification = new TileNotification(tileXml);
TileUpdateManager.CreateTileUpdaterForApplication().Update(tileNotification);
```

The following line of code uses [EnableNotificationQueue](tileupdater_enablenotificationqueue_1798421599.md) to enable the notification queue for the calling app's tile.



```csharp
TileUpdateManager.CreateTileUpdaterForApplication().EnableNotificationQueue(true);
```

The following example shows the use of the [RemoveFromSchedule](tileupdater_removefromschedule_928610118.md) method.



```csharp
var notifier = TileUpdateManager.CreateTileUpdaterForApplication();
var scheduled = notifier.GetScheduledTileNotifications();

for (int i = 0; i < scheduled.Count; i++) {
    if (scheduled[i].Id == itemId) {
        notifier.RemoveFromSchedule(scheduled[i]);
    }
}
```



## -see-also

