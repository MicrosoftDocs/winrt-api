---
-api-id: M:Windows.Networking.BackgroundTransfer.UploadOperation.StartAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Networking.BackgroundTransfer.UploadOperation, Windows.Networking.BackgroundTransfer.UploadOperation> StartAsync()
-->

# Windows.Networking.BackgroundTransfer.UploadOperation.StartAsync

## -description
Starts an asynchronous upload operation.

## -returns
An asynchronous upload operation that includes progress updates.


## -remarks

### Exceptions
#### COMException

Thrown when a feature-specific **HRESULT** is returned from a method call.

This is the most common exception that is thrown by networking methods. An app should use the **HRESULT** from the exception to determine the cause of the error.

#### AccessDeniedException

Thrown when access is denied to a resource or feature. This exception occurs when an app doesn't have the required network capabilities set in the app manifest for the network operation requested.

#### InvalidArgumentException

Thrown when one of the arguments that are provided to a method is not valid.

If user-supplied input caused this exception, an app could inform the user and request new input.

#### ObjectDisposedException

Thrown when an operation is performed on a disposed object.

#### OutOfMemoryException

Thrown when insufficient memory is available to complete the operation.

An upload operation must be scheduled using one of the [BackgroundUploader.CreateUpload](backgrounduploader_createupload_1442890857.md), [BackgroundUploader.CreateUploadAsync](backgrounduploader_createuploadasync_1414694207.md) , or [BackgroundUploader.CreateUploadFromStreamAsync](backgrounduploader_createuploadfromstreamasync_1788513301.md) methods before the StartAsync method is called.

> [!IMPORTANT]
> Queuing up a large number of transfers on the main UI thread can result in degraded performance of your app's UI, even though the call is awaitable. If you are queuing up a large number of transfers, it is recommended that you call **StartAsync** on a background worker thread as in the following example.

```csharp
operation = await Task.Run(() => { return myUploadOperation.StartAsync(); });

```



## -examples

## -see-also
[BackgroundTransferError.GetStatus](backgroundtransfererror_getstatus_1856274933.md), [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)), [WebErrorStatus](../windows.web/weberrorstatus.md)
