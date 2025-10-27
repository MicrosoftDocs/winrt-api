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



    ```csharp
    var currentTime = DateTime.Now;
    var seconds = 30;

    var tileXml = TileUpdateManager.GetTemplateContent(TileTemplateType.TileWide310x150Text04);
    var tileTextAttributes = tileXml.GetElementsByTagName("text");
    tileTextAttributes[0].AppendChild(tileXml.CreateTextNode("This notification will expire at " + currentTime.AddSeconds(seconds).ToLocalTime().ToString()));

    var tileNotification = new TileNotification(tileXml);
    tileNotification.ExpirationTime = currentTime.AddSeconds(seconds);

    TileUpdateManager.CreateTileUpdaterForApplication().Update(tileNotification);
    ```



## -see-also
[How to use the notification queue with local notifications](/previous-versions/windows/apps/hh465429(v=win.10)), [App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)

