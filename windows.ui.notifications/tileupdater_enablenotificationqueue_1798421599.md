---
-api-id: M:Windows.UI.Notifications.TileUpdater.EnableNotificationQueue(System.Boolean)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void EnableNotificationQueue(System.Boolean enable)
-->

# Windows.UI.Notifications.TileUpdater.EnableNotificationQueue

## -description
Enables the tile to queue up to five notifications. This enables the notification queue on all tile sizes.

## -parameters
### -param enable
**True** to enable queuing; otherwise **false**.

## -remarks
When queuing is enabled, a maximum of five tile notifications can automatically cycle on the tile. Be careful about enabling cycling unless your app explicitly wants to use it, otherwise you can potentially have outdated notifications cycling through. Generally, the queue is FIFO (first in, first out), so that when it is full and a new notification arrives, the oldest notification is removed. However, notifications can be given a [Tag](tilenotification_tag.md), which allows a new notification with that same [Tag](tilenotification_tag.md) to replace its older notification in the queue, regardless of its position.

When your tile is based on a peek template, notification cycling is timed so that the full content is always shown before the tile cycles to the next notification.

As of Windows 8.1, you can also enable the notification queue for only specific tile sizes. See the following topics: 
+ [EnableNotificationQueueForSquare150x150](tileupdater_enablenotificationqueueforsquare150x150_2087406043.md)
+ [EnableNotificationQueueForSquare310x310](tileupdater_enablenotificationqueueforsquare310x310_2095794587.md)
+ [EnableNotificationQueueForWide310x150](tileupdater_enablenotificationqueueforwide310x150_1310885892.md)
We recommend that you disable the notification queu when using a large tile with one of the following templates, which already show three notifications simultaneously. This avoids a tile that's distractingly busy to the user. In that case, you may want to use the size-specific enable methods instead of EnableNotificationQueue. 
+ [TileSquare310x310SmallImagesAndTextList01](tiletemplatetype.md)
+ [TileSquare310x310SmallImagesAndTextList02](tiletemplatetype.md)
+ [TileSquare310x310SmallImagesAndTextList03](tiletemplatetype.md)
+ [TileSquare310x310SmallImagesAndTextList04](tiletemplatetype.md)
+ [TileSquare310x310TextList01](tiletemplatetype.md)
+ [TileSquare310x310TextList02](tiletemplatetype.md)
+ [TileSquare310x310TextList03](tiletemplatetype.md)


## -examples
The following line of code enables the notification queue for the calling app's tile.

```javascript

Windows.UI.Notifications.TileUpdateManager.createTileUpdaterForApplication().enableNotificationQueue(true);
```



## -see-also
[How to use the notification queue with local notifications](/previous-versions/windows/apps/hh465429(v=win.10)), [App tiles and badges sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/App%20tiles%20and%20badges%20sample), [Quickstart: Sending a tile update](/previous-versions/windows/apps/hh465439(v=win.10)), [Tile and tile notification overview](/previous-versions/windows/apps/hh779724(v=win.10)), [The tile template catalog](/previous-versions/windows/apps/hh761491(v=win.10)), [Guidelines and checklist for tiles](/windows/uwp/controls-and-patterns/tiles-and-notifications-creating-tiles), [How to schedule a tile notification](/previous-versions/windows/apps/hh761473(v=win.10)), [How to set up periodic notifications for tiles](/previous-versions/windows/apps/hh761476(v=win.10)), [Tiles XML schema](/uwp/schemas/tiles/tilesschema/schema-root)
