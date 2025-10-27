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



```csharp
var currentTime = DateTime.Now;
var seconds = 60;
var dueTime = currentTime.AddSeconds(seconds * 60);
var idNumber = new Random().Next(0, 100000000);

var tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150Text09);

// Set up the wide tile text.
var tileTextAttributes = tileXml.GetElementsByTagName("text");
tileTextAttributes[0].AppendChild(tileXml.CreateTextNode("This is a scheduled notification"));
tileTextAttributes[1].AppendChild(tileXml.CreateTextNode("Received: " + dueTime.ToLocalTime().ToString()));

// Set up the medium tile text.
var squareTileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150Text04);
var squareTileTextAttributes = squareTileXml.GetElementsByTagName("text");
squareTileTextAttributes[0].AppendChild(squareTileXml.CreateTextNode("This is a scheduled notification"));

// Include the medium tile in the notification.
var node = tileXml.ImportNode(squareTileXml.GetElementsByTagName("binding").Item(0), true);
tileXml.GetElementsByTagName("visual").Item(0).AppendChild(node);

// Create the notification object.
var futureTile = new ScheduledTileNotification(tileXml, dueTime);
futureTile.Id = "Tile" + idNumber;

// Add to the schedule.
TileUpdateManager.CreateTileUpdaterForApplication().AddToSchedule(futureTile);
```



## -see-also
ScheduledTileNotification, [Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Tile schema](/uwp/schemas/tiles/tilesschema/schema-root), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)

