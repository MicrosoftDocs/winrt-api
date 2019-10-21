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
> When this method is called on a Windows 8 system, it returns a [version 1 template](https://docs.microsoft.com/previous-versions/windows/apps/hh761491(v=win.10)). When this method is called on a Windows 8.1 system, it returns a [version 2 template](https://docs.microsoft.com/previous-versions/windows/apps/hh761491(v=win.10)). However, if an app specifies Windows 8 compatibility in its manifest, this method returns a [version 1 template](https://docs.microsoft.com/previous-versions/windows/apps/hh761491(v=win.10)).

## -parameters
### -param type
The name of the template.

## -returns
The object that contains the XML.

## -remarks
You can use Document Object Model (DOM) manipulation functions to customize the template content for use in a [TileNotification](tilenotification.md) update that you will send to the tile through the [TileUpdater](tileupdater.md) that you create through the other methods of this class.

See [tile schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root) for an explanation of tile elements and attributes.

## -examples
The following example shows GetTemplateContent used to retrieve the XML content of a tile template.

```javascript

var tileTemplate = Windows.UI.Notifications.TileTemplateType.tileWide310x150Text03;
var tileXml = Windows.UI.Notifications.TileUpdateManager.getTemplateContent(tileTemplate);
```



## -see-also
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](https://docs.microsoft.com/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](https://docs.microsoft.com/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](https://docs.microsoft.com/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](https://docs.microsoft.com/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)
