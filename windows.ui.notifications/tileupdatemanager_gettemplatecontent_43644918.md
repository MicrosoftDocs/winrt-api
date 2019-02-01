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
> When this method is called on a Windows 8 system, it returns a [version 1 template](https://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f). When this method is called on a Windows 8.1 system, it returns a [version 2 template](https://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f). However, if an app specifies Windows 8 compatibility in its manifest, this method returns a [version 1 template](https://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f).

## -parameters
### -param type
The name of the template.

## -returns
The object that contains the XML.

## -remarks
You can use Document Object Model (DOM) manipulation functions to customize the template content for use in a [TileNotification](tilenotification.md) update that you will send to the tile through the [TileUpdater](tileupdater.md) that you create through the other methods of this class.

See [tile schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root) for an explanation of tile elements and attributes.

## -examples
The following example shows [GetTemplateContent](tileupdatemanager_gettemplatecontent_43644918.md) used to retrieve the XML content of a tile template.

```javascript

var tileTemplate = Windows.UI.Notifications.TileTemplateType.tileWide310x150Text03;
var tileXml = Windows.UI.Notifications.TileUpdateManager.getTemplateContent(tileTemplate);
```



## -see-also
[App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](https://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](https://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](https://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](https://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](https://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](https://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)
