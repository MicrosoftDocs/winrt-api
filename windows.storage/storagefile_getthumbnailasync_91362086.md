---
-api-id: M:Windows.Storage.StorageFile.GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode,System.UInt32,Windows.Storage.FileProperties.ThumbnailOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.FileProperties.StorageItemThumbnail> GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode mode, System.UInt32 requestedSize, Windows.Storage.FileProperties.ThumbnailOptions options)
-->

# Windows.Storage.StorageFile.GetThumbnailAsync

## -description
Retrieves an adjusted thumbnail image for the file, determined by the purpose of the thumbnail, the requested size, and the specified options.

## -parameters
### -param mode
The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.

For guidance about choosing the best thumbnail mode, see [Guidelines and checklist for thumbnails](https://docs.microsoft.com/windows/uwp/files/thumbnails).

### -param requestedSize
The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to scale the thumbnail image without reducing the quality of the image.

If Windows can't find a thumbnail image that it can scale to meet the requested size, a larger thumbnail might be returned. If no larger thumbnail is available, a thumbnail image that is smaller than the requested size might be returned.

### -param options
The enum value that describes the desired behavior to use to retrieve the thumbnail image. The specified behavior might affect the size and/or quality of the image and how quickly the thumbnail image is retrieved.




## -returns
When this method completes successfully, it returns a [StorageItemThumbnail](../windows.storage.fileproperties/storageitemthumbnail.md) that represents the thumbnail image or **null** if there is no thumbnail image associated with the file.

## -remarks

## -examples
This example shows you how to capture the thumbnail of a file using the [storageFile.getThumbnailAsync(mode, requestedSize, options)](storagefile_getthumbnailasync_91362086.md) method.

```javascript
storageFile.getThumbnailAsync(
    Windows.Storage.FileProperties.ThumbnailMode.musicView,
    100,
    Windows.Storage.FileProperties.ThumbnailOptions.useCurrentScale).then(
        function (storageItemThumbnail) {
            // Add code to process thumbnail
        }
    );
```

You must have a [StorageFile](storagefile.md) object (`storageFile` in the example) that represents your file in order to use one of the [StorageFile.GetThumbnailAsync](storagefile_getthumbnailasync_1511435522.md) methods.

## -see-also
[GetThumbnailAsync(ThumbnailMode)](storagefile_getthumbnailasync_1575071988.md), [GetThumbnailAsync(ThumbnailMode, UInt32)](storagefile_getthumbnailasync_1511435522.md), [ThumbnailOptions](../windows.storage.fileproperties/thumbnailoptions.md)
