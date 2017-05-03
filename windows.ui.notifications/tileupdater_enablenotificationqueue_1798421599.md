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
+ [EnableNotificationQueueForSquare150x150](tileupdater_enablenotificationqueueforsquare150x150.md)
+ [EnableNotificationQueueForSquare310x310](tileupdater_enablenotificationqueueforsquare310x310.md)
+ [EnableNotificationQueueForWide310x150](tileupdater_enablenotificationqueueforwide310x150.md)
We recommend that you disable the notification queu when using a large tile with one of the following templates, which already show three notifications simultaneously. This avoids a tile that's distractingly busy to the user. In that case, you may want to use the size-specific enable methods instead of [EnableNotificationQueue](tileupdater_enablenotificationqueue.md). 
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
[How to use the notification queue with local notifications](http://msdn.microsoft.com/library/614a784e-f418-46f7-b961-cef128779fea), [App tiles and badges sample](http://go.microsoft.com/fwlink/p/?linkid=231469), [Quickstart: Sending a tile update](http://msdn.microsoft.com/library/d4b2cebf-9dec-4c8f-bc6d-23edca7aaf83), [Tile and tile notification overview](http://msdn.microsoft.com/library/10a05b52-42c4-4f85-9310-57663e378b9e), [The tile template catalog](http://msdn.microsoft.com/library/2d3dd627-9a34-493c-bda4-ff7b80817e4f), [Guidelines and checklist for tiles](http://msdn.microsoft.com/library/e825f754-97dd-41c2-aff4-4dfb60eda677), [How to schedule a tile notification](http://msdn.microsoft.com/library/56b0c3e3-be90-4461-a8b1-79e88072b37c), [How to set up periodic notifications for tiles](http://msdn.microsoft.com/library/96c67773-2e5b-4278-b16d-2f813b16580c), [Tiles XML schema](XREF:TODO:tile.Schema_Root)