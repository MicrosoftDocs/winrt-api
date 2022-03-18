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

The retrieved elements and their attributes are manipulated through Document Object Model (DOM) manipulation functions. See [Tile schema](/uwp/schemas/tiles/tilesschema/schema-root) for an explanation of tile elements and attributes found in the XML document.

## -examples

## -see-also
[Scheduled notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Scheduled%20notifications%20sample), [Tile schema](/uwp/schemas/tiles/tilesschema/schema-root), [Guidelines and checklist for scheduled notifications](/windows/uwp/controls-and-patterns/tiles-and-notifications-choosing-a-notification-delivery-method)
