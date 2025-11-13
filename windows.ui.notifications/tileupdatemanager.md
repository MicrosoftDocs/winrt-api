---
-api-id: T:Windows.UI.Notifications.TileUpdateManager
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class TileUpdateManager 
-->

# Windows.UI.Notifications.TileUpdateManager

## -description
Creates [TileUpdater](tileupdater.md) objects used to change and update **Start** menu tiles. This class also provides access to the XML content of the system-provided tile templates so that you can customize that content for use in updating your tiles.

## -remarks
This is a static factory class and requires no instantiation.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | GetForUser |

## -examples
The following example shows [GetTemplateContent](tileupdatemanager_gettemplatecontent_43644918.md) used to retrieve the XML content of a tile template and [CreateTileUpdaterForApplication](tileupdatemanager_createtileupdaterforapplication_1541898748.md) to send the notification to the app's tile.



    ```csharp
    // Get an XML DOM version of a specific template by using GetTemplateContent
    var tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150Text03);
    var tileAttributes = tileXml.GetElementsByTagName("text");
    tileAttributes[0].AppendChild(tileXml.CreateTextNode("Hello World!"));

    var tileNotification = new TileNotification(tileXml);
    TileUpdateManager.CreateTileUpdaterForApplication().Update(tileNotification);
    ```



## -see-also
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)

