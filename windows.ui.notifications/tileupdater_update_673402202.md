---
-api-id: M:Windows.UI.Notifications.TileUpdater.Update(Windows.UI.Notifications.TileNotification)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Update(Windows.UI.Notifications.TileNotification notification)
-->

# Windows.UI.Notifications.TileUpdater.Update

## -description
Applies a change in content or appearance to the tile.

## -parameters
### -param notification
The object that supplies the new XML definition for the tile's content.

## -remarks

## -examples
The following example shows Update used to send a notification to the app's tile.



    ```csharp
    var tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150Text03);
    var tileAttributes = tileXml.GetElementsByTagName("text");
    tileAttributes[0].AppendChild(tileXml.CreateTextNode("Hello World!"));

    var tileNotification = new TileNotification(tileXml);
    TileUpdateManager.CreateTileUpdaterForApplication().Update(tileNotification);
    ```



## -see-also
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to use the notification queue with local notifications](/previous-versions/windows/apps/hh465429(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)

