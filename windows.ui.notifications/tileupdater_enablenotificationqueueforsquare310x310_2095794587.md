---
-api-id: M:Windows.UI.Notifications.TileUpdater.EnableNotificationQueueForSquare310x310(System.Boolean)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void EnableNotificationQueueForSquare310x310(System.Boolean enable)
-->

# Windows.UI.Notifications.TileUpdater.EnableNotificationQueueForSquare310x310

## -description
Enables the tile to queue up to five notifications on the large tile.

## -parameters
### -param enable
**True** to enable queuing on this tile size; otherwise **false**.

## -remarks
We recommend that you disable the notification queu when using a large tile with one of the following templates, which already show three notifications simultaneously. This avoids a tile that's distractingly busy to the user. 
+ [TileSquare310x310SmallImagesAndTextList01](tiletemplatetype.md)
+ [TileSquare310x310SmallImagesAndTextList02](tiletemplatetype.md)
+ [TileSquare310x310SmallImagesAndTextList03](tiletemplatetype.md)
+ [TileSquare310x310SmallImagesAndTextList04](tiletemplatetype.md)
+ [TileSquare310x310TextList01](tiletemplatetype.md)
+ [TileSquare310x310TextList02](tiletemplatetype.md)
+ [TileSquare310x310TextList03](tiletemplatetype.md)


## -examples

## -see-also
[EnableNotificationQueue](tileupdater_enablenotificationqueue.md), [EnableNotificationQueueForSquare150x150](tileupdater_enablenotificationqueueforsquare150x150.md), [EnableNotificationQueueForWide310x150](tileupdater_enablenotificationqueueforwide310x150.md)