---
-api-id: T:Windows.Media.Import.PhotoImportItem
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PhotoImportItem : Windows.Media.Import.IPhotoImportItem
-->

# Windows.Media.Import.PhotoImportItem

## -description
Represents an media item that has been imported from a source.

## -remarks
Get an instance of this class by calling one of the following methods.

+ [PhotoImportSession.FindItemsAsync](photoimportsession_finditemsasync_1686050162.md)
+ [PhotoImportFindItemsResult.ImportItemsAsync](photoimportfinditemsresult_importitemsasync_357096682.md)
+ [DeleteImportedItemsFromSourceAsync](photoimportimportitemsresult_deleteimporteditemsfromsourceasync_1949343605.md)
Or, handle the [PhotoImportFindItemsResult.ItemImported](photoimportfinditemsresult_itemimported.md) event.

For how-to guidance for adding media import to your app, see [Import media from a device](/windows/uwp/audio-video-camera/import-media-from-a-device).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | Path |

## -examples

## -see-also
[Import media from a device](/windows/uwp/audio-video-camera/import-media-from-a-device)
