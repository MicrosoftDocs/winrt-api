---
-api-id: M:Windows.Networking.BackgroundTransfer.DownloadOperation.AttachAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Networking.BackgroundTransfer.DownloadOperation, Windows.Networking.BackgroundTransfer.DownloadOperation> AttachAsync()
-->

# Windows.Networking.BackgroundTransfer.DownloadOperation.AttachAsync

## -description
Returns an asynchronous operation that can be used to monitor progress and completion of the attached download. Calling this method allows an app to attach download operations that were started in a previous app instance.

## -returns
Download operation with callback.

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

While, this method can be called from multiple app instances, developers should not attach callbacks from the primary app instance in a background task. This will cause **BackgroundTransferHost.exe** to hang.

## -examples
```javascript

        function AttachDownload (loadedDownload) {
            try {
                download = loadedDownload;
                promise = download.attachAsync().then(complete, error, progress);
            } catch (err) {
                displayException(err);
            }
        };
```



## -see-also
