---
-api-id: P:Windows.UI.Notifications.TileNotification.Content
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Data.Xml.Dom.XmlDocument Content { get; }
-->

# Windows.UI.Notifications.TileNotification.Content

## -description
Gets the XML description of the notification content, which you can then manipulate to alter the notification.

## -property-value
The object that contains the notification content.

## -remarks
The retrieved elements and their attributes are manipulated through Document Object Model (DOM) manipulation functions to customize the tile content. See [tile schema](XREF:TODO:tile.Schema_Root) for an explanation of tile elements and attributes found in the XML document.

## -examples

## -see-also
[App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](http://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](http://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](http://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](http://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](XREF:TODO:tile.Schema_Root)