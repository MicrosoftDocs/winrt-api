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
The following example uses ExpirationTime to show a tile notification for 30 seconds.

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
[How to use the notification queue with local notifications](/previous-versions/windows/apps/hh465429(v=win.10)), [App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)
