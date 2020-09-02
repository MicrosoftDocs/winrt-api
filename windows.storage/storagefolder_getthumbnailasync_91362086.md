---
-api-id: M:Windows.Storage.StorageFolder.GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode,System.UInt32,Windows.Storage.FileProperties.ThumbnailOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.FileProperties.StorageItemThumbnail> GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode mode, System.UInt32 requestedSize, Windows.Storage.FileProperties.ThumbnailOptions options)
-->

# Windows.Storage.StorageFolder.GetThumbnailAsync

## -description
Gets a thumbnail image for the current folder, sized for the specified purpose of the thumbnail and adjusted to the requested size with the specified options.

## -parameters
### -param mode
A value from the enumeration that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.

For guidance about choosing the best thumbnail mode, see [Guidelines and checklist for thumbnails](/windows/uwp/files/index).

### -param requestedSize
The requested size, in pixels, of the longest edge of the thumbnail. This method uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.

If this method can't find a thumbnail image that it can scale to the requested size, it may return a larger thumbnail. If no larger thumbnail is available, it may return a thumbnail image that is smaller than the requested size.

### -param options
A value from the enumeration that specifies how to retrieve and size the image. The default value, **UseCurrentScale**, is suitable for most apps.

## -returns
When this method completes successfully, it returns a [StorageItemThumbnail](../windows.storage.fileproperties/storageitemthumbnail.md) that represents the thumbnail image, or **null** if there is no thumbnail image associated with the folder.

## -remarks

## -examples

## -see-also
[GetThumbnailAsync(ThumbnailMode)](storagefolder_getthumbnailasync_1575071988.md), [GetThumbnailAsync(ThumbnailMode, UInt32)](storagefolder_getthumbnailasync_1511435522.md)