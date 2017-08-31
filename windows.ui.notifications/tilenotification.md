---
-api-id: T:Windows.UI.Notifications.TileNotification
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class TileNotification : Windows.UI.Notifications.ITileNotification
-->

# Windows.UI.Notifications.TileNotification

## -description
Defines an update to a tile, including its visuals, identification tag, and expiration time.

## -remarks

## -examples
The following example uses the [TileNotification](tilenotification_tilenotification.md) constructor to create a new instance, then uses the [ExpirationTime](tilenotification_expirationtime.md) property to show a tile notification for 30 seconds.

```javascript

function tileNotificationExpiration() {
    var Notifications = Windows.UI.Notifications;
    var tileXml = Notifications.TileUpdateManager.getTemplateContent(Notifications.TileTemplateType.tileWide310x150Text04);

    var currentTime = new Date();
    var seconds = 30;

    var tileTextAttributes = tileXml.getElementsByTagName("text");
    tileTextAttributes[0].appendChild(tileXml.createTextNode("This notification will expire at " + new Date(currentTime.getTime() + seconds * 1000)));

    var tileNotification = new Notifications.TileNotification(tileXml);

    // Set the expiration time on the notification
    var expiryTime = new Date(currentTime.getTime() + seconds * 1000);

    tileNotification.expirationTime = expiryTime;
    Notifications.TileUpdateManager.createTileUpdaterForApplication().update(tileNotification);
}
```



## -see-also
[App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](http://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](http://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](http://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](http://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)