---
-api-id: M:Windows.Storage.StorageFile.ReplaceWithStreamedFileAsync(Windows.Storage.IStorageFile,Windows.Storage.StreamedFileDataRequestedHandler,Windows.Storage.Streams.IRandomAccessStreamReference)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> ReplaceWithStreamedFileAsync(Windows.Storage.IStorageFile fileToReplace, Windows.Storage.StreamedFileDataRequestedHandler dataRequested, Windows.Storage.Streams.IRandomAccessStreamReference thumbnail)
-->

# Windows.Storage.StorageFile.ReplaceWithStreamedFileAsync

## -description
Replaces the contents of the file referred to by the specified [IStorageFile](istoragefile.md) object with a new data stream. This method lets the app produce the data on-demand by specifying a function to be invoked when the [StorageFile](storagefile.md) that represents the stream is first accessed.

## -parameters
### -param fileToReplace
The file (type [IStorageFile](istoragefile.md)) that the new data stream should be written to.

### -param dataRequested
The function that should be invoked when the [StorageFile](storagefile.md) that is returned is first accessed. This function should produce the data stream represented by the returned [StorageFile](storagefile.md) and lets the app produce data on-demand instead of writing the contents of the file at creation time.

### -param thumbnail
The thumbnail image for the [StorageFile](storagefile.md) to create.

For a high-quality thumbnail, one edge of this thumbnail should be at least 1024 pixels.

## -returns
When this method completes, it returns a [StorageFile](storagefile.md) object that represents the new data stream. Subsequently, this [StorageFile](storagefile.md) object should be used to access file content instead of the file (type [IStorageFile](istoragefile.md)) that was specified to be replace.

## -remarks
This method lets you defer expensive operations to produce the data until that data needed (when it is first accessed). This avoids creating unnecessary delays in user interaction while the data is produced.

## -examples

## -see-also
