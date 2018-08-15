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

## -examples
The following example shows [GetTemplateContent](tileupdatemanager_gettemplatecontent_43644918.md) used to retrieve the XML content of a tile template and [CreateTileUpdaterForApplication](tileupdatemanager_createtileupdaterforapplication_1541898748.md) to send the notification to the app's tile.

```javascript

function sendTileTextNotification() {
    var Notifications = Windows.UI.Notifications;

    // Get an XML DOM version of a specific template by using getTemplateContent.
    var tileXml = Notifications.TileUpdateManager.getTemplateContent(Notifications.TileTemplateType.tileWide310x150Text03);

    // You will need to look at the template documentation to know how many text fields a particular template has.
    // Get the text attribute for this template and fill it in.
    var tileAttributes = tileXml.getElementsByTagName("text");
    tileAttributes[0].appendChild(tileXml.createTextNode("Hello World!"));

    // Create the notification from the XML.
    var tileNotification = new Notifications.TileNotification(tileXml);

    // Send the notification to the calling app's tile.
    Notifications.TileUpdateManager.createTileUpdaterForApplication().update(tileNotification);
}
```



## -see-also
[App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](http://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](http://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](http://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](http://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)