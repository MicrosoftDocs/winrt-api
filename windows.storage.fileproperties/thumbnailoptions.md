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
<!--{annotation author="miriamw" time="1/12/2012 2:45:10 PM"}TODO: I don't really know what this means in this context.-->

### -field ReturnOnlyIfCached:1
Retrieve a thumbnail only if it is cached or embedded in the file.

### -field ResizeThumbnail:2
Scale the thumbnail to the requested size.
<!--{annotation author="miriamw" time="1/12/2012 2:43:55 PM"}TODO: Scale even if image quality is lost?-->

### -field UseCurrentScale:4
Default. Increase requested size based on the Pixels Per Inch (PPI) of the display.


<!--{annotation author="miriamw" time="1/12/2012 2:44:07 PM"}Is this the default? why is it so good or why WOULd devs want to stray?-->

<!--{annotation author="miriamw" time="1/12/2012 2:59:42 PM"}TODO: Too vague and awkard to add ... : There are very few reasons developers would want to stray away from using the scaleForPPI default thumbnail option, although a gallery app may choose to alter this in order to display more items in the view-->


## -remarks
This enumeration is used when you get a thumbnail image by calling one of the [getThumbnailAsync](../windows.storage/istorageitemproperties_getthumbnailasync.md) method overloads like [storageFile.getThumbnailAsync(mode, requestedSize, options)](../windows.storage/storagefile_getthumbnailasync_91362086.md). The thumbnail image that is returned is represented by a [storageItemThumbnail](storageitemthumbnail.md) object.

## -examples

## -see-also
[storageItemThumbnail class](storageitemthumbnail.md), [ThumbnailMode enum](thumbnailmode.md), [Windows.Storage.storageFile.getThumbnailAsync(mode, requestedSize, options) method](../windows.storage/storagefile_getthumbnailasync_91362086.md)