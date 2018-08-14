---
-api-id: T:Windows.Storage.FileProperties.ThumbnailOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.FileProperties.ThumbnailOptions : uint
-->

# ThumbnailOptions

## -description
Describes the behavior used to retrieve and adjust thumbnails, including the size and quality of the image and how quickly the thumbnail image is retrieved.

## -enum-fields
### -field None:0
No options.


### -field ReturnOnlyIfCached:1
Retrieve a thumbnail only if it is cached or embedded in the file.

### -field ResizeThumbnail:2
Scale the thumbnail to the requested size.


### -field UseCurrentScale:4
Default. Increase requested size based on the Pixels Per Inch (PPI) of the display.







## -remarks
This enumeration is used when you get a thumbnail image by calling one of the [getThumbnailAsync](../windows.storage/istorageitemproperties_getthumbnailasync_1511435522.md) method overloads like [storageFile.getThumbnailAsync(mode, requestedSize, options)](../windows.storage/storagefile_getthumbnailasync_91362086.md). The thumbnail image that is returned is represented by a [storageItemThumbnail](storageitemthumbnail.md) object.

## -examples

## -see-also
[storageItemThumbnail class](storageitemthumbnail.md), [ThumbnailMode enum](thumbnailmode.md), [Windows.Storage.storageFile.getThumbnailAsync(mode, requestedSize, options) method](../windows.storage/storagefile_getthumbnailasync_91362086.md)