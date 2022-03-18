---
-api-id: T:Windows.UI.Notifications.ScheduledTileNotification
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ScheduledTileNotification : Windows.UI.Notifications.IScheduledTileNotification
-->

# Windows.UI.Notifications.ScheduledTileNotification

## -description
Defines the visual content and timing for a single, non-recurring scheduled update to a tile.

## -remarks

## -examples
The following example shows a tile scheduled to display in one hour.

```javascript

var Notifications = Windows.UI.Notifications;
var currentTime = new Date();
var seconds = 60;
var dueTime = new Date(currentTime.getTime() + seconds * 60 * 1000);
var idNumber = Math.floor(Math.random() * 100000000);  // Generates a unique ID number for the notification.

var tileXml = Notifications.TileUpdateManager.getTemplateContent(Notifications.TileTemplateType.tileWide310x150Text09);

// Set up the wide tile text.
var tileTextAttributes = tileXml.getElementsByTagName("text");
tileTextAttributes[0].appendChild(tileXml.createTextNode("This is a scheduled notification"));
tileTextAttributes[1].appendChild(tileXml.createTextNode("Received: " + dueTime.toLocaleTimeString()));

// Set up the medium tile text.
var squareTileXml = Notifications.TileUpdateManager.getTemplateContent(Notifications.TileTemplateType.tileSquare150x150Text04);
var squareTileTextAttributes = squareTileXml.getElementsByTagName("text");
squareTileTextAttributes[0].appendChild(squareTileXml.createTextNode("This is a scheduled notification"));

// Include the medium tile in the notification.
var node = tileXml.importNode(squareTileXml.getElementsByTagName("binding").item(0), true);
tileXml.getElementsByTagName("visual").item(0).appendChild(node);

// Create the notification object.
var futureTile = new Notifications.ScheduledTileNotification(tileXml, dueTime);
futureTile.id = "Tile" + idNumber;

// Add to the schedule.
Notifications.TileUpdateManager.createTileUpdaterForApplication().addToSchedule(futureTile);
```



## -see-also
ScheduledTileNotification, [Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Tile schema](/uwp/schemas/tiles/tilesschema/schema-root), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
