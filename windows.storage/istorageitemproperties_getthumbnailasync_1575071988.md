---
-api-id: M:Windows.Storage.IStorageItemProperties.GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.FileProperties.StorageItemThumbnail> GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode mode)
-->

# Windows.Storage.IStorageItemProperties.GetThumbnailAsync

## -description
Retrieves an adjusted thumbnail image for the item, determined by the purpose of the thumbnail.

## -parameters
### -param mode
The enum value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.

## -returns
When this method completes successfully, it returns a [StorageItemThumbnail](../windows.storage.fileproperties/storageitemthumbnail.md) that represents the thumbnail image or **null** if there is no thumbnail image associated with the item.

## -remarks
In Windows 8, the [GetThumbnailAsync](istorageitemproperties_getthumbnailasync_1511435522.md) method has just one immersive monitor at a time that can show the UWP app user interface. In Windows 8.1, the UWP app user interface can appear on multiple monitors, with the option to show a single app on multiple monitors simultaneously. For scaling, consider multiple scale factors at once.

In Windows 8.1, the [GetThumbnailAsync](istorageitemproperties_getthumbnailasync_1511435522.md) method can return any size thumbnail. Therefore, apps that display local pictures should call this method to get the scaled image they want to display. This ensures that apps benefit from all cache and performance optimizations, including a special mechanism to obtain thumbnails from the cloud without downloading the full file.

## -examples

## -see-also
[GetThumbnailAsync(ThumbnailMode, UInt32)](istorageitemproperties_getthumbnailasync_1511435522.md), [GetThumbnailAsync(ThumbnailMode, UInt32, ThumbnailOptions)](istorageitemproperties_getthumbnailasync_91362086.md)