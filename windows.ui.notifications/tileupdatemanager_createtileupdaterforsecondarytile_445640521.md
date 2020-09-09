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
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)
