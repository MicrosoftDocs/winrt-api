---
-api-id: M:Windows.Storage.StorageFile.CreateStreamedFileAsync(System.String,Windows.Storage.StreamedFileDataRequestedHandler,Windows.Storage.Streams.IRandomAccessStreamReference)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CreateStreamedFileAsync(System.String displayNameWithExtension, Windows.Storage.StreamedFileDataRequestedHandler dataRequested, Windows.Storage.Streams.IRandomAccessStreamReference thumbnail)
-->

# Windows.Storage.StorageFile.CreateStreamedFileAsync

## -description
Creates a [StorageFile](storagefile.md) to represent the specified stream of data. This method lets the app produce the data on-demand by specifying a function to be invoked when the [StorageFile](storagefile.md) that represents the stream is first accessed.




## -parameters
### -param displayNameWithExtension
The user-friendly name of the [StorageFile](storagefile.md) to create, including a file type extension.

### -param dataRequested
The function that should be invoked when the [StorageFile](storagefile.md) that is returned is first accessed. This function should produce the data stream represented by the returned [StorageFile](storagefile.md) and lets the app produce data on-demand instead of writing the contents of the file at creation time.

### -param thumbnail
The thumbnail image for the [StorageFile](storagefile.md) to create.

For a high-quality thumbnail, one edge of this thumbnail should be at least 1024 pixels.

## -returns
When this method completes, it returns a [StorageFile](storagefile.md) object that represents the new stream of data.

## -remarks
Both this method and [CreateStreamedFileFromUriAsync](storagefile_createstreamedfilefromuriasync.md) can be used to create a [StorageFile](storagefile.md) that can be passed to other methods or passed to another app through app contracts.

These methods let you defer expensive operations to produce the data until that data needed (when it is first accessed). This avoids creating unnecessary delays in user interaction while the data is produced.

## -examples

## -see-also
