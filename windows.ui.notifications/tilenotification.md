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
The following example uses the [TileNotification](tilenotification_tilenotification_93177318.md) constructor to create a new instance, then uses the [ExpirationTime](tilenotification_expirationtime.md) property to show a tile notification for 30 seconds.

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
[App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)
