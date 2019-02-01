---
-api-id: M:Windows.UI.Notifications.TileUpdateManager.CreateTileUpdaterForSecondaryTile(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Notifications.TileUpdater CreateTileUpdaterForSecondaryTile(System.String tileId)
-->

# Windows.UI.Notifications.TileUpdateManager.CreateTileUpdaterForSecondaryTile

## -description
Creates and initializes a new instance of the [TileUpdater](tileupdater.md), which enables you to change the appearance of a [secondary tile](../windows.ui.startscreen/secondarytile.md). The tile can belong to the calling app or any other app in the same package.

## -parameters
### -param tileId
A unique ID for the tile.

## -returns
The object you will use to send updates to the tile identified by *tileID*.

## -remarks

## -examples
The following example demonstrates how to send a notification to a secondary tile.

```javascript

var Notifications = Windows.UI.Notifications;

// Define the notification content.
var tileXml = Notifications.TileUpdateManager.getTemplateContent(Notifications.TileTemplateType.tileWide310x150Text04);
var tileTextAttributes = tileXml.getElementsByTagName("text");
tileTextAttributes[0].appendChild(tileXml.createTextNode("Sent to a secondary tile!"));

// Provide a medium version of the notification as well, remembering that the user has control 
// over whether the tile is displaying as wide or square.
var squareTileXml = Notifications.TileUpdateManager.getTemplateContent(Notifications.TileTemplateType.tileSquare150x150Text04);
var squareTileTextAttributes = squareTileXml.getElementsByTagName("text");
squareTileTextAttributes[0].appendChild(squareTileXml.createTextNode("Sent to a secondary tile!"));

// Add the medium tile to the notification.
var node = tileXml.importNode(squareTileXml.getElementsByTagName("binding").item(0), true);
tileXml.getElementsByTagName("visual").item(0).appendChild(node);

// Create the notification based on the XML content.
var tileNotification = new Notifications.TileNotification(tileXml);

// Create a secondary tile updater and pass it the secondary tileId
var tileUpdater = Notifications.TileUpdateManager.createTileUpdaterForSecondaryTile("SecondaryTile.Dynamic");

// Send the notification to the secondary tile.
tileUpdater.update(tileNotification);
```



## -see-also
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](https://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](https://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](https://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](https://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](https://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](https://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)
