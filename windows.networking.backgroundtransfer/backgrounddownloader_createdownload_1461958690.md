---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundDownloader.CreateDownload(Windows.Foundation.Uri,Windows.Storage.IStorageFile,Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.BackgroundTransfer.DownloadOperation CreateDownload(Windows.Foundation.Uri uri, Windows.Storage.IStorageFile resultFile, Windows.Storage.IStorageFile requestBodyFile)
-->

# Windows.Networking.BackgroundTransfer.BackgroundDownloader.CreateDownload

## -description
Initializes a [DownloadOperation](downloadoperation.md) object with the resource [Uri](../windows.foundation/uri.md), the file that the response is written to, and the request entity body.

## -parameters
### -param uri
The location of the resource.

### -param resultFile
The file that the response will be written to.

### -param requestBodyFile
A file that represents the request entity body, which contains additional data the server requires before the download can begin. The file this object points to must be valid for the duration of the download.

## -returns
The resultant download operation.

## -remarks
The resultant [DownloadOperation](downloadoperation.md) supports scenarios where a valid download request contains specific data required by the server. For example, a website requires a filled out form before the download can take place.

Background transfer doesn't support concurrent downloads of the same [Uri](../windows.foundation/uri.md). So an app can download *`http://example.com/myfile.wmv`* once, or download it again after a previous download completed. An app shouldn't start two downloads of the same [Uri](../windows.foundation/uri.md) concurrently, since this may result in truncated files.

> [!IMPORTANT]
> Creating a large number of transfers on the main UI thread with **CreateDownload** can result in degraded performance of your app's UI. If you are queuing up a large number of transfers, it is recommended that you call **CreateDownload** on a background worker thread as in the following example.

```csharp
operation = await Task.Run(() => { return myDownloader.CreateDownload(uri, file); });
```

> [!NOTE]
> Some file systems have file size limits. Background transfer has special logic to fast-fail transfers that exceed the destination drive's file size limits (for example, files that exceed 4GB in size for FAT32 file systems). If the server responds with a `Content-Length` header value greater than the file system's maximum file size, then the download operation immediately fails with HRESULT_FROM_WIN32(ERROR_FILE_SYSTEM_LIMITATION).

## -examples

## -see-also
[CreateDownload(Uri, IStorageFile)](backgrounddownloader_createdownload_186972694.md)