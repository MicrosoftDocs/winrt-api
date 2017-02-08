---
-api-id: M:Windows.Storage.StorageFile.ReplaceWithStreamedFileFromUriAsync(Windows.Storage.IStorageFile,Windows.Foundation.Uri,Windows.Storage.Streams.IRandomAccessStreamReference)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> ReplaceWithStreamedFileFromUriAsync(Windows.Storage.IStorageFile fileToReplace, Windows.Foundation.Uri uri, Windows.Storage.Streams.IRandomAccessStreamReference thumbnail)
-->

# Windows.Storage.StorageFile.ReplaceWithStreamedFileFromUriAsync

## -description
Replaces the contents of the file referred to by the specified [IStorageFile](istoragefile.md) object with a new data stream of the specified Uniform Resource Identifier (URI). This method lets the app download the data on-demand when the [StorageFile](storagefile.md) that represents the stream is first accessed.

The data stream is accessed through the [StorageFile](storagefile.md) that is returned and the data is downloaded on-demand when the [StorageFile](storagefile.md) is first accessed.

Replaces the [IStorageFile](istoragefile.md) object that represents the specified file with a new [StorageFile](storagefile.md) that provides a stream of the specified Uniform Resource Identifier (URI).

## -parameters
### -param fileToReplace
The file that the created [StorageFile](storagefile.md) will provide a stream of.

### -param uri
The Uniform Resource Identifier (URI) of the resource used to create the [StorageFile](storagefile.md).

### -param thumbnail
The thumbnail image for the [StorageFile](storagefile.md) to create.

For a high-quality thumbnail, one edge of this thumbnail should be at least 1024 pixels.

## -returns
When this method completes, it returns a [StorageFile](storagefile.md) object that represents the streamed file. Subsequently, this [StorageFile](storagefile.md) object should be used to access file content instead of the file (type [IStorageFile](istoragefile.md)) that was specified to be replace.

## -remarks

## -examples

## -see-also
