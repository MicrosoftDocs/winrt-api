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


+ [PhotoImportSession.FindItemsAsync](photoimportsession_finditemsasync.md)
+ [PhotoImportFindItemsResult.ImportItemsAsync](photoimportfinditemsresult_importitemsasync.md)
+ [DeleteImportedItemsFromSourceAsync](photoimportimportitemsresult_deleteimporteditemsfromsourceasync.md)
Or, handle the [PhotoImportFindItemsResult.ItemImported](photoimportfinditemsresult_itemimported.md) event.

For how-to guidance for adding media import to your app, see [Import media from a device](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/import-media-from-a-device).

## -examples

## -see-also
[Import media from a device](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/import-media-from-a-device)