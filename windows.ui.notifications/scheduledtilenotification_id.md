---
-api-id: P:Windows.UI.Notifications.ScheduledTileNotification.Id
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string Id { get;  set; }
-->

# Windows.UI.Notifications.ScheduledTileNotification.Id

## -description
Gets or sets the unique ID that is used to identify the scheduled tile in the schedule.

## -property-value
The notification's identifier. This string is limited to 16 characters.

## -remarks
[ScheduledTileNotification.tag](scheduledtilenotification_tag.md) and ScheduledTileNotification.id serve similar purposes: 
+ The [ScheduledTileNotification.tag](scheduledtilenotification_tag.md) property is used by Windows to prevent duplicate notification content from appearing in the queue at the same time. It allows the notification to be updated in-place in the queue to prevent it from containing out-of-date information.
+ The id property identifies the notification in the schedule. This allows the notification to be identified or removed from the schedule.


## -examples
The following example, which shows a tile scheduled to display in one hour, includes the use of the Id property to label the scheduled notification.

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
