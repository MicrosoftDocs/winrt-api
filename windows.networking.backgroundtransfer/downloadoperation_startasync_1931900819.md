---
-api-id: M:Windows.Networking.BackgroundTransfer.DownloadOperation.StartAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Networking.BackgroundTransfer.DownloadOperation, Windows.Networking.BackgroundTransfer.DownloadOperation> StartAsync()
-->

# Windows.Networking.BackgroundTransfer.DownloadOperation.StartAsync

## -description
Starts an asynchronous download operation.

## -returns
An asynchronous download operation that includes progress updates.

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

Background transfer doesn't support concurrent downloads of the same [Uri](../windows.foundation/uri.md). So an app can download *`http://example.com/myfile.wmv`* once, or download it again after a previous download completed. An app shouldn't start two downloads of the same [Uri](../windows.foundation/uri.md) concurrently, since this may result in truncated files.

A download operation must be scheduled using one of the [BackgroundDownloader.CreateDownload](backgrounddownloader_createdownload_1461958690.md) or [BackgroundDownloader.CreateDownloadAsync](backgrounddownloader_createdownloadasync_282410561.md) methods before the StartAsync method is called.

> [!IMPORTANT]
> Queuing up a large number of transfers on the main UI thread can result in degraded performance of your app's UI, even though the call is awaitable. If you are queuing up a large number of transfers, it is recommended that you call **StartAsync** on a background worker thread as in the following example.

```csharp
operation = await Task.Run(() => { return myDownloadOperation.StartAsync(); });

```



## -examples

## -see-also
[Background Transfer Download sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Background%20Transfer%20sample), [BackgroundTransferError.GetStatus](backgroundtransfererror_getstatus_1856274933.md), [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)), [Quickstart: Download a file](/previous-versions/windows/apps/hh700370(v=win.10))
