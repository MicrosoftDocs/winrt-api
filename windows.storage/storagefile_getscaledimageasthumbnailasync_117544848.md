---
-api-id: M:Windows.Storage.StorageFile.GetScaledImageAsThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode,System.UInt32,Windows.Storage.FileProperties.ThumbnailOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.FileProperties.StorageItemThumbnail> GetScaledImageAsThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode mode, System.UInt32 requestedSize, Windows.Storage.FileProperties.ThumbnailOptions options)
-->

# Windows.Storage.StorageFile.GetScaledImageAsThumbnailAsync

## -description
Gets a scaled image as a thumbnail, determined by the purpose of the thumbnail, the requested size, and the specified options

## -parameters
### -param mode
The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.

For guidance about choosing the best thumbnail mode, see [Guidelines and checklist for thumbnails](/windows/uwp/files/index).

### -param requestedSize
The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.

If Windows can't find a thumbnail image that it can scale to meet the requested size, a larger thumbnail might be returned. If no larger thumbnail is available, a thumbnail image that is smaller than the requested size might be returned.

### -param options
The enum value that describes the desired behavior to use to retrieve the thumbnail image. The specified behavior might affect the size and/or quality of the image and how quickly the thumbnail image is retrieved.

## -returns
When this method completes successfully, it returns a [StorageItemThumbnail](../windows.storage.fileproperties/storageitemthumbnail.md) that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.

## -remarks
While GetThumbnailAsync adheres to the max size supported by the thumbnail disk cache, GetScaledImageAsThumbnailAsync can extract thumbnails that are larger than what the thumbnail disk cache supports. GetScaledImageAsThumbnailAsync provides optimal quality but can affect performance by not using the disk cache if the thumbnail size is too large.

## -examples

## -see-also
[GetScaledImageAsThumbnailAsync(ThumbnailMode)](storagefile_getscaledimageasthumbnailasync_1603417158.md), [GetScaledImageAsThumbnailAsync(ThumbnailMode, UInt32)](storagefile_getscaledimageasthumbnailasync_1483024820.md), [GetThumbnailAsync(ThumbnailMode)](storagefile_getthumbnailasync_1575071988.md), [GetThumbnailAsync(ThumbnailMode, UInt32)](storagefile_getthumbnailasync_1511435522.md), [GetThumbnailAsync(ThumbnailMode, UInt32, ThumbnailOptions)](storagefile_getthumbnailasync_91362086.md)