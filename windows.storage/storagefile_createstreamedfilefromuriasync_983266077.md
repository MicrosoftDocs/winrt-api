---
-api-id: M:Windows.Storage.StorageFile.CreateStreamedFileFromUriAsync(System.String,Windows.Foundation.Uri,Windows.Storage.Streams.IRandomAccessStreamReference)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CreateStreamedFileFromUriAsync(System.String displayNameWithExtension, Windows.Foundation.Uri uri, Windows.Storage.Streams.IRandomAccessStreamReference thumbnail)
-->

# Windows.Storage.StorageFile.CreateStreamedFileFromUriAsync

## -description
Creates a [StorageFile](storagefile.md) to represent a stream of data from the specified Uniform Resource Identifier (URI) resource. This method lets the app download the data on-demand when the [StorageFile](storagefile.md) that represents the stream is first accessed.

## -parameters
### -param displayNameWithExtension
The user-friendly name of the [StorageFile](storagefile.md) to create, including a file type extension.

### -param uri
The Uniform Resource Identifier (URI) of the resource used to create the [StorageFile](storagefile.md).

### -param thumbnail
The thumbnail image for the [StorageFile](storagefile.md) to create.

For a high-quality thumbnail, one edge of this thumbnail should be at least 1024 pixels.

## -returns
When this method completes, it returns a [StorageFile](storagefile.md) object that represents the Uniform Resource Identifier (URI) resource.

## -remarks
This method is nearly equivalent to [CreateStreamedFileAsync](storagefile_createstreamedfileasync.md), except when using this method, the system provides a [StreamedFileDataRequestedHandler](streamedfiledatarequestedhandler.md) on the app's behalf and implements this function to download the specified [Uri](../windows.foundation/uri.md) into the streamed file.

## -examples

## -see-also
