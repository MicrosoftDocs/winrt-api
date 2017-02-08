---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundUploader.CreateUpload(Windows.Foundation.Uri,Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.BackgroundTransfer.UploadOperation CreateUpload(Windows.Foundation.Uri uri, Windows.Storage.IStorageFile sourceFile)
-->

# Windows.Networking.BackgroundTransfer.BackgroundUploader.CreateUpload

## -description
Initializes an [UploadOperation](uploadoperation.md) that indicates the location for and file for upload.

## -parameters
### -param uri
The location for the upload.

### -param sourceFile
The file for upload.

## -returns
The resultant upload operation.

## -remarks
> [!IMPORTANT]
> Creating a large number of transfers on the main UI thread with **CreateUpload** can result in degraded performance of your app's UI. If you are queuing up a large number of transfers, it is recommended that you call **CreateUpload** on a background worker thread as in the following example.

```csharp
operation = await Task.Run(() => { return myDownloader.CreateUpload(uri, file); });

```



## -examples

## -see-also
[UploadOperation](uploadoperation.md), [IStorageFile](../windows.storage/istoragefile.md)