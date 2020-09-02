---
-api-id: M:Windows.Storage.Search.QueryOptions.SetThumbnailPrefetch(Windows.Storage.FileProperties.ThumbnailMode,System.UInt32,Windows.Storage.FileProperties.ThumbnailOptions)
-api-type: winrt method
---

<!-- Method syntax
public void SetThumbnailPrefetch(Windows.Storage.FileProperties.ThumbnailMode mode, System.UInt32 requestedSize, Windows.Storage.FileProperties.ThumbnailOptions options)
-->

# Windows.Storage.Search.QueryOptions.SetThumbnailPrefetch

## -description
Specifies the type and size of thumbnails that the system should start loading immediately when items are accessed (instead of retrieving them on a case-by-case basis). This uses more resources but makes thumbnail retrieval on query results faster.

## -parameters
### -param mode
The enumeration value that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.

For guidance about choosing the best thumbnail mode, see [Guidelines and checklist for thumbnails](/windows/uwp/files/index).

### -param requestedSize
The requested size, in pixels, of the longest edge of the thumbnail. Windows uses the *requestedSize* as a guide and tries to return a thumbnail image that can be scaled to the requested size without reducing the quality of the image.

If Windows can't find a thumbnail image that exactly meets the requested size, a larger thumbnail might be returned. If no larger thumbnail is available, a thumbnail image that is smaller than the requested size might be returned.

### -param options
The enum value that describes the desired behavior to use to retrieve the thumbnail image. The specified behavior might affect the size and/or quality of the image and how quickly the thumbnail image is retrieved.

## -remarks

## -examples

## -see-also
[Folder enumeration sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FolderEnumeration),
[Fast access to file properties in UWP](/windows/uwp/files/fast-file-properties)
