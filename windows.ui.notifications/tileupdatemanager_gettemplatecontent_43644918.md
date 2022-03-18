---
-api-id: M:Windows.UI.Notifications.TileUpdateManager.GetTemplateContent(Windows.UI.Notifications.TileTemplateType)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Data.Xml.Dom.XmlDocument GetTemplateContent(Windows.UI.Notifications.TileTemplateType type)
-->

# Windows.UI.Notifications.TileUpdateManager.GetTemplateContent

## -description
Gets the XML content of one of the predefined tile templates so that you can customize it for a tile update.

> [!NOTE]
> When this method is called on a Windows 8 system, it returns a [version 1 template](/previous-versions/windows/apps/hh761491(v=win.10)). When this method is called on a Windows 8.1 system, it returns a [version 2 template](/previous-versions/windows/apps/hh761491(v=win.10)). However, if an app specifies Windows 8 compatibility in its manifest, this method returns a [version 1 template](/previous-versions/windows/apps/hh761491(v=win.10)).

## -parameters
### -param type
The name of the template.

## -returns
The object that contains the XML.

## -remarks
You can use Document Object Model (DOM) manipulation functions to customize the template content for use in a [TileNotification](tilenotification.md) update that you will send to the tile through the [TileUpdater](tileupdater.md) that you create through the other methods of this class.

See [tile schema](/uwp/schemas/tiles/tilesschema/schema-root) for an explanation of tile elements and attributes.

## -examples
The following example shows GetTemplateContent used to retrieve the XML content of a tile template.

```javascript

var tileTemplate = Windows.UI.Notifications.TileTemplateType.tileWide310x150Text03;
var tileXml = Windows.UI.Notifications.TileUpdateManager.getTemplateContent(tileTemplate);
```



## -see-also
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)
