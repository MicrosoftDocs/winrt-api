---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundDownloader.CreateDownloadAsync(Windows.Foundation.Uri,Windows.Storage.IStorageFile,Windows.Storage.Streams.IInputStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.BackgroundTransfer.DownloadOperation> CreateDownloadAsync(Windows.Foundation.Uri uri, Windows.Storage.IStorageFile resultFile, Windows.Storage.Streams.IInputStream requestBodyStream)
-->

# Windows.Networking.BackgroundTransfer.BackgroundDownloader.CreateDownloadAsync

## -description
Creates an asynchronous download operation that includes a URI, the file that the response will be written to, and the [IInputStream](../windows.storage.streams/iinputstream.md) object from which the file contents are read.

## -parameters
### -param uri
The location of the resource.

### -param resultFile
Represents the file that the response will be written to.

### -param requestBodyStream
A stream that represents the request entity body.

## -returns
The resultant asynchronous download operation.

## -remarks
Background transfer doesn't support concurrent downloads of the same [Uri](../windows.foundation/uri.md). So an app can download *http://example.com/myfile.wmv* once, or download it again after a previous download completed. An app shouldn't start two downloads of the same [Uri](../windows.foundation/uri.md) concurrently, since this may result in truncated files.

## -examples

## -see-also
[IStorageFile](../windows.storage/istoragefile.md), [IInputStream](../windows.storage.streams/iinputstream.md)