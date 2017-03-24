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
To get an instance of this object, call the [TileUpdateManager.CreateTileUpdaterForApplication](tileupdatemanager_createtileupdaterforapplication.md) or [TileUpdateManager.CreateTileUpdaterForSecondaryTile](tileupdatemanager_createtileupdaterforsecondarytile.md) method.

When it is created, [TileUpdater](tileupdater.md) is bound to a specific app or secondary tile, so the methods of this class affect only the single tile that the object instance is bound to.

## -examples
The following example shows [Update](tileupdater_update.md) used to send a notification to the app's tile.

```javascript

function sendTileTextNotification() {
    var Notifications = Windows.UI.Notifications;

    // Get an XML DOM version of a specific template by using getTemplateContent.
    var tileXml = Notifications.TileUpdateManager.getTemplateContent(Notifications.TileTemplateType.tileWide310x150Text03);

    // You will need to look at the template documentation to know how many text fields a particular template has.
    // Get the text attribute for this template and fill it in.
    var tileAttributes = tileXml.getElementsByTagName("text");
    tileAttributes[0].appendChild(tileXml.createTextNode("Hello World!"));

    // Create the notification from the XML.
    var tileNotification = new Notifications.TileNotification(tileXml);

    // Send the notification to the calling app's tile.
    Notifications.TileUpdateManager.createTileUpdaterForApplication().update(tileNotification);
}
```

The following line of code uses [EnableNotificationQueue](tileupdater_enablenotificationqueue.md) to enable the notification queue for the calling app's tile.

```javascript

Windows.UI.Notifications.TileUpdateManager.createTileUpdaterForApplication().enableNotificationQueue(true);
```

The following example shows the use of the [RemoveFromSchedule](tileupdater_removefromschedule.md) method.

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