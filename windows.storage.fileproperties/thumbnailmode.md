---
-api-id: T:Windows.Storage.FileProperties.ThumbnailMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.FileProperties.ThumbnailMode : int
-->

# ThumbnailMode

## -description

Describes the purpose of the thumbnail to determine how to adjust the thumbnail image to retrieve.

## -enum-fields

### -field PicturesView:0

To display previews of picture files.

+ **Default, preferred size:** Medium, preferably at least 190 pixels (if the image size is 190 x 130)
+ **Aspect ratio:** Uniform, wide aspect ratio of about .7 (190 x 130 if the preferred size is 190)

### -field VideosView:1

To display previews of video files.

+ **Default, preferred size:** Medium, preferably at least 190 pixels (if the video size is 190 x 130)
+ **Aspect ratio:** Uniform, wide aspect ratio of about .7 (190 x 130 if the requested size is 190)

### -field MusicView:2

To display previews of music files.

+ **Default, preferred size:** Small, preferably at least 40 x 40 pixels
+ **Aspect ratio:** Uniform, square aspect ratio

### -field DocumentsView:3

To display previews of document files.

+ **Default, preferred size:** Small, preferably at least 40 x 40 pixels
+ **Aspect ratio:** Uniform, square aspect ratio

### -field ListView:4
To display previews of files (or other items) in a list.

+ **Default, preferred size:** Small, preferably at least 40 x 40 pixels
+ **Aspect ratio:** Uniform, square aspect ratio

### -field SingleItem:5

To display a preview of any single item (like a file, folder, or file group).

+ **Default, preferred size:** Large, at least 256 pixels on the longest side
+ **Aspect ratio:** Variable, uses the original aspect ratio of the file

## -remarks

Windows uses the default, preferred size as a guide to scale the thumbnail image without reducing the quality of the image. It does not guarantee the size of the thumbnail image that is retrieved.

### Using thumbnail modes

Use this enumeration to determine the thumbnail image you get when you call one of the [getThumbnailAsync](../windows.storage/istorageitemproperties_getthumbnailasync_1575071988.md) methods. These methods return the thumbnail image as a [storageItemThumbnail](storageitemthumbnail.md) object.

For example, you can get a thumbnail image to preview a video file by calling [storageFile.GetThumbnailAsync(ThumbnailMode)](../windows.storage/storagefile_getthumbnailasync_1575071988.md) and specifying the **videoView** thumbnail mode.

To help you decide which mode you should use, see [Guidelines and checklist for thumbnails](/windows/uwp/files/index).

## -examples

## -see-also

[Guidelines and checklist for thumbnails](/windows/uwp/files/index), [storageItemThumbnail class](storageitemthumbnail.md), [ThumbnailOptions enum](thumbnailoptions.md), [Windows.Storage.storageFile.getThumbnailAsync methods](../windows.storage/storagefile_getthumbnailasync_1511435522.md), [File and folder thumbnail sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileThumbnails)
