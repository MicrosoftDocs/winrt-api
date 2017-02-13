---
-api-id: M:Windows.Networking.BackgroundTransfer.UploadOperation.AttachAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Networking.BackgroundTransfer.UploadOperation, Windows.Networking.BackgroundTransfer.UploadOperation> AttachAsync()
-->

# Windows.Networking.BackgroundTransfer.UploadOperation.AttachAsync

## -description
Returns an asynchronous operation that can be used to monitor progress and completion of the attached upload. Calling this method allows an app to attach upload operations that were started in a previous app instance.

## -returns
Upload operation with callback.

## -remarks
While this method can be called from multiple app instances, developers should not attach callbacks from the primary app instance in a background task. This will cause **BackgroundTransferHost.exe** to hang.

## -examples
```javascript
        function AttachUpload (loadedUpload) {
            try {
                upload = loadedUpload;
                promise = upload.attachAsync().then(complete, error, progress);
            } catch (err) {
                displayError(err);
            }
        };
```



## -see-also
