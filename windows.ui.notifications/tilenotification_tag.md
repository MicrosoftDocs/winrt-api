---
-api-id: P:Windows.UI.Notifications.TileNotification.Tag
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string Tag { get;  set; }
-->

# Windows.UI.Notifications.TileNotification.Tag

## -description
Gets or sets a string that Windows can use to prevent duplicate notification content from appearing in the queue.

## -property-value
A string of 16 characters or less (plus a terminating null character) that identifies the notification in the stack. While there is no set form to the string content, we recommend that it should relate to the content of the notification.

## -remarks
Use tags to replace notifications in the stack. If a new notification arrives with the same tag as an existing notification, the new notification replaces the old. For instance, if your tile shows stock prices, you want to show the most up-to-date info. An existing stock price update waiting in the queue to be displayed should be replaced by the latest quotes rather than showing them one after the other.

A new notification with a matching tag replaces any existing notification with the same tag, but the new notification does not necessarily inherit the older notification's place in the queue.

The tag should relate to the content of the notification. For example, a notification in a stock quote app could use the stock symbol (such as "msft") while a weather app notification could be tagged with the zip code (such as "98052") of the forecast. Do not simply number your notifications as "notification1", "notification2" and so on.

## -examples

## -see-also
[How to use the notification queue with local notifications](/previous-versions/windows/apps/hh465429(v=win.10)), [App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)
