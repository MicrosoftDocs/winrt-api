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
The retrieved elements and their attributes are manipulated through Document Object Model (DOM) manipulation functions to customize the tile content. See [tile schema](/uwp/schemas/tiles/tilesschema/schema-root) for an explanation of tile elements and attributes found in the XML document.

## -examples

## -see-also
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)
