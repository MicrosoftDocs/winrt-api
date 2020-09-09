---
-api-id: M:Windows.Storage.StorageFile.GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.FileProperties.StorageItemThumbnail> GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode mode)
-->

# Windows.Storage.StorageFile.GetThumbnailAsync

## -description
Retrieves an adjusted thumbnail image for the file, determined by the purpose of the thumbnail.

## -parameters
### -param mode
The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.

For guidance about choosing the best thumbnail mode, see [Guidelines and checklist for thumbnails](/windows/uwp/files/thumbnails).

## -returns
When this method completes successfully, it returns a [StorageItemThumbnail](../windows.storage.fileproperties/storageitemthumbnail.md) that represents the thumbnail image or **null** if there is no thumbnail image associated with the file.

## -examples

## -see-also
[GetThumbnailAsync(ThumbnailMode, UInt32)](storagefile_getthumbnailasync_1511435522.md), [GetThumbnailAsync(ThumbnailMode, UInt32, ThumbnailOptions)](storagefile_getthumbnailasync_91362086.md), [ThumbnailMode](../windows.storage.fileproperties/thumbnailmode.md)
