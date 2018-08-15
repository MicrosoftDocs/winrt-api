---
-api-id: T:Windows.Networking.BackgroundTransfer.UploadOperation
-api-type: winrt class
---

<!-- Class syntax.
public class UploadOperation : Windows.Networking.BackgroundTransfer.IBackgroundTransferOperation, Windows.Networking.BackgroundTransfer.IBackgroundTransferOperationPriority, Windows.Networking.BackgroundTransfer.IUploadOperation, Windows.Networking.BackgroundTransfer.IUploadOperation2
-->

# Windows.Networking.BackgroundTransfer.UploadOperation

## -description
Performs an asynchronous upload operation. For an overview of Background Transfer capabilities, see [Transferring data in the background](http://msdn.microsoft.com/library/9e2ed5b4-af57-456a-884f-1e1d2136a8e8). Download the [Background Transfer sample](http://go.microsoft.com/fwlink/p/?linkid=245064) for examples in JavaScript, C#, and C++.

## -remarks
After app termination, an app should enumerate all existing [UploadOperation](uploadoperation.md) instances at next start-up using [GetCurrentUploadsAsync](backgrounduploader_getcurrentuploadsasync_1938169689.md). When a UWP app using Background Transfer is terminated, incomplete uploads will persist in the background. If the app is restarted after termination and these incomplete operations are not enumerated and re-introduced to the current session, they will go stale and continue to occupy device resources.**Timeout considerations**


+ 1.) When establishing a new connection for an upload over TCP/SSL, the connection attempt is aborted if not established within five minutes.
+ 2.) After the connection has been established, an HTTP request message that has not received a response within two minutes is aborted.
Assuming there is Internet connectivity, Background Transfer will retry an upload up to three times. In the event Internet connectivity is not detected, additional attempts will not be made until it is.

**Debugging Guidance**

Stopping a debugging session in Microsoft Visual Studio is comparable to closing your app; PUT uploads are paused and POST uploads are aborted. Even while debugging, your app should enumerate and then pause, restart, or cancel any persisted uploads.

However, if Microsoft Visual Studio project updates, like changes to the app manifest, require that the app is uninstalled and re-deployed for debugging, [GetCurrentUploadsAsync](backgrounduploader_getcurrentuploadsasync_1938169689.md) cannot enumerate persisted operations created using the previous app deployment.

## -examples
The following example demonstrates how to configure and begin a basic upload operation, and is based on the [Background Transfer sample](http://go.microsoft.com/fwlink/p/?linkid=245064) offered in the Windows Sample Gallery.

```javascript
        var upload = null;
        var promise = null;

        function UploadFile (uriString, file) {
            try {

                var uri = Windows.Foundation.Uri(uriString);
                var uploader = new Windows.Networking.BackgroundTransfer.BackgroundUploader();

                // Set a header, so the server can save the file (this is specific to the sample server).
                uploader.setRequestHeader("Filename", file.name);

                // Create a new upload operation.
                upload = uploader.createUpload(uri, file);

                // Start the upload and persist the promise to be able to cancel the upload.
                promise = upload.startAsync().then(complete, error, progress);
            } catch (err) {
                displayError(err);
            }
        };
```

```csharp

        using Windows.Foundation; 
        using Windows.Networking.BackgroundTransfer;
        using Windows.Storage.Pickers;
        using Windows.Storage;

        private async void StartUpload_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Uri uri = new Uri(serverAddressField.Text.Trim());
                FileOpenPicker picker = new FileOpenPicker();
                picker.FileTypeFilter.Add("*");
                StorageFile file = await picker.PickSingleFileAsync();

                BackgroundUploader uploader = new BackgroundUploader();
                uploader.SetRequestHeader("Filename", file.Name);

                UploadOperation upload = uploader.CreateUpload(uri, file);

                // Attach progress and completion handlers.
                HandleUploadAsync(upload, true);
            }
            catch (Exception ex)
            {
                LogException("Upload Error", ex);
            }
        }
```



## -see-also
[Quickstart: Upload a file](http://msdn.microsoft.com/library/9c0d21a9-d253-4671-a0ef-437412a28cd8), [Background Transfer sample](http://go.microsoft.com/fwlink/p/?linkid=245064)

## -capabilities
internetClient, internetClientServer, privateNetworkClientServer
