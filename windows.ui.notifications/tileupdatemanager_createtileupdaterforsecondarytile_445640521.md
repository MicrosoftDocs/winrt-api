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



```csharp
var tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150Text04);
var tileTextAttributes = tileXml.GetElementsByTagName("text");
tileTextAttributes[0].AppendChild(tileXml.CreateTextNode("Sent to a secondary tile!"));

var squareTileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileSquare150x150Text04);
var squareTileTextAttributes = squareTileXml.GetElementsByTagName("text");
squareTileTextAttributes[0].AppendChild(squareTileXml.CreateTextNode("Sent to a secondary tile!"));

var node = tileXml.ImportNode(squareTileXml.GetElementsByTagName("binding").Item(0), true);
tileXml.GetElementsByTagName("visual").Item(0).AppendChild(node);

var tileNotification = new TileNotification(tileXml);
var tileUpdater = TileUpdateManager.CreateTileUpdaterForSecondaryTile("SecondaryTile.Dynamic");
tileUpdater.Update(tileNotification);
```



## -see-also
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)

