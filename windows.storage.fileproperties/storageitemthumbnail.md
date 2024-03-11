---
-api-id: T:Windows.Storage.FileProperties.StorageItemThumbnail
-api-type: winrt class
---

<!-- Class syntax.
public class StorageItemThumbnail : Windows.Foundation.IClosable, Windows.Storage.FileProperties.IThumbnailProperties, Windows.Storage.Streams.IContentTypeProvider, Windows.Storage.Streams.IInputStream, Windows.Storage.Streams.IOutputStream, Windows.Storage.Streams.IRandomAccessStream, Windows.Storage.Streams.IRandomAccessStreamWithContentType
-->

# Windows.Storage.FileProperties.StorageItemThumbnail

## -description

Represents the thumbnail image associated with a system resource (like a file or folder).

## -remarks

You can get thumbnails for many file system resources through the Windows Runtime objects that represent them. Many of these objects have methods or properties that let you get (and sometimes set) a StorageItemThumbnail that represents the thumbnail associated with a particular resource.

To find out how to get thumbnail for a particular Windows Runtime object, see the documentation for that object. For example, to get a thumbnail for a file you can call one of the [StorageFile.getThumbnailAsync](../windows.storage/storagefile_getthumbnailasync_1511435522.md) methods, or to get a thumbnail for a contact you can use the [Contact.thumbnail](../windows.applicationmodel.contacts/contact_thumbnail.md) property.

For more code samples about retrieving thumbnails, see the [Folder enumeration sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FolderEnumeration) and the [File thumbnails sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/FileThumbnails).

## -examples

This example demonstrates how to get thumbnails for files.

```csharp
// Set query options with filter and sort order for results
List<string> fileTypeFilter = new List<string>();
fileTypeFilter.Add(".jpg");
fileTypeFilter.Add(".png");
fileTypeFilter.Add(".bmp");
fileTypeFilter.Add(".gif");
var queryOptions = new QueryOptions(CommonFileQuery.OrderByName, fileTypeFilter);

// Create query and retrieve files.
var query = KnownFolders.PicturesLibrary.CreateFileQueryWithOptions(queryOptions);
IReadOnlyList<StorageFile> fileList = await query.GetFilesAsync();
// Process results
foreach (StorageFile file in fileList)
{
    // Get thumbnail
    const uint requestedSize = 190;
    const ThumbnailMode thumbnailMode = ThumbnailMode.PicturesView;
    const ThumbnailOptions thumbnailOptions = ThumbnailOptions.UseCurrentScale;
    var thumbnail = await file.GetThumbnailAsync(thumbnailMode, requestedSize, thumbnailOptions);
}
```

After [GetThumbnailAsync](../windows.storage/storagefile_getthumbnailasync_1511435522.md) completes, thumbnail gets a StorageItemThumbnail object.

In the example, the `file` variable gets a [StorageFile](../windows.storage/storagefile.md) that represents each file that we want to retrieve a thumbnail for. We used a query to obtain [StorageFile](../windows.storage/storagefile.md) objects for these files (stored in the `file` variable), but you can use whatever approach is best for your app to obtain [StorageFile](../windows.storage/storagefile.md) objects (like through the file picker).

## -see-also

[StorageFile](../windows.storage/storagefile.md), [File and folder thumbnail sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileThumbnails)