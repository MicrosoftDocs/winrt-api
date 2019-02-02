---
-api-id: P:Windows.UI.Notifications.TileNotification.ExpirationTime
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.DateTime> ExpirationTime { get;  set; }
-->

# Windows.UI.Notifications.TileNotification.ExpirationTime

## -description
Gets or sets the time that Windows will remove the notification from the tile. By default, a tile update does not expire. It is a best practice to explicitly set an expiration time to avoid stale content.

## -property-value
The date and time that the notification should be removed.

## -remarks

## -examples
The following example uses [ExpirationTime](tilenotification_expirationtime.md) to show a tile notification for 30 seconds.

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
[How to use the notification queue with local notifications](https://msdn.microsoft.com/library/614a784e-f418-46f7-b961-cef128779fea), [App tiles and badges sample](https://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](https://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](https://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](https://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](https://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](https://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](https://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](https://docs.microsoft.com/uwp/schemas/tiles/tilesschema/schema-root)
