---
-api-id: T:Windows.Networking.BackgroundTransfer.BackgroundTransferContentPart
-api-type: winrt class
---

<!-- Class syntax.
public class BackgroundTransferContentPart : Windows.Networking.BackgroundTransfer.IBackgroundTransferContentPart
-->

# Windows.Networking.BackgroundTransfer.BackgroundTransferContentPart

## -description
Represents a content part of a multi-part transfer request. Each BackgroundTransferContentPart object can represent either a single string of text content or a single file payload, but not both.

## -remarks

## -examples
The following example demonstrates how to configure and begin a multi-part upload operation.

```javascript
        
        var upload = null;
        var promise = null;

        function MultipartUpload (uriString, files) {
            try {

                var uri = Windows.Foundation.Uri(uriString);
                var uploader = new Windows.Networking.BackgroundTransfer.BackgroundUploader();
                var contentParts = [];
                files.forEach(function (file, index) {
                    var part = new Windows.Networking.BackgroundTransfer.BackgroundTransferContentPart("File" + index, file.name);
                    part.setFile(file);
                    contentParts.push(part);
                });

                // Create a new upload operation.
                uploader.createUploadAsync(uri, contentParts).then(function (uploadOperation) {
                    // Start the upload and persist the promise to be able to cancel the upload.
                    upload = uploadOperation;
                    promise = uploadOperation.startAsync().then(complete, error, progress);
                });
            } catch (err) {
                displayError(err);
            }
        };
```



## -see-also
[CreateDownload(Uri, IStorageFile, IStorageFile)](backgrounddownloader_createdownload_1461958690.md), [CreateUploadAsync](/uwp/api/windows.networking.backgroundtransfer.backgrounduploader.createuploadasync), [Background transfer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTransfer), [Background transfer sample (Windows 8.x)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Background%20Transfer%20sample)

## -capabilities
internetClient, internetClientServer, privateNetworkClientServer
