---
-api-id: P:Windows.UI.Notifications.ScheduledTileNotification.Content
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Data.Xml.Dom.XmlDocument Content { get; }
-->

# Windows.UI.Notifications.ScheduledTileNotification.Content

## -description
Gets the XML description of the content of the scheduled tile update.

## -property-value
The object that contains the notification content.

## -remarks
This information is set when the [ScheduledTileNotification](scheduledtilenotification.md) is created.

The retrieved elements and their attributes are manipulated through Document Object Model (DOM) manipulation functions. See [Tile schema](XREF:TODO:tile.Schema_Root) for an explanation of tile elements and attributes found in the XML document.


<!-- @WRITER erictill 12/13/2011 : I still don't have a good explanation why anyone would want this. -->

## -examples

## -see-also
[Scheduled notifications sample](http://go.microsoft.com/fwlink/p/?linkid=241614), [Tile schema](XREF:TODO:tile.Schema_Root), [Guidelines and checklist for scheduled notifications](http://msdn.microsoft.com/library/ca9e9121-d1b1-461f-9c7e-b25225d917ca)