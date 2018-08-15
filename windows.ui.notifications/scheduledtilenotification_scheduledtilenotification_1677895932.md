---
-api-id: M:Windows.UI.Notifications.ScheduledTileNotification.#ctor(Windows.Data.Xml.Dom.XmlDocument,Windows.Foundation.DateTime)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public ScheduledTileNotification(Windows.Data.Xml.Dom.XmlDocument content, Windows.Foundation.DateTime deliveryTime)
-->

# Windows.UI.Notifications.ScheduledTileNotification.ScheduledTileNotification

## -description
Creates and initializes a new instance of the [ScheduledTileNotification](scheduledtilenotification.md) object for use with a [TileUpdater](tileupdater.md).

## -parameters
### -param content
The object that provides the content for the tile notification.

### -param deliveryTime
The time at which the tile should be updated with the notification information.

## -remarks

## -examples
The following example, which shows a tile scheduled to display in one hour, includes the use of the [ScheduledTileNotification](scheduledtilenotification_scheduledtilenotification_1677895932.md) constructor to create the notification object.

```javascript

var Notifications = Windows.UI.Notifications;
var currentTime = new Date();
var seconds = 60;
var dueTime = new Date(currentTime.getTime() + seconds * 60 * 1000);
var idNumber = 123456789;

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
[Tile schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root), [Scheduled notifications sample](http://go.microsoft.com/fwlink/p/?linkid=241614), [Guidelines and checklist for scheduled notifications](http://msdn.microsoft.com/library/ca9e9121-d1b1-461f-9c7e-b25225d917ca)