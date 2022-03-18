---
-api-id: T:Windows.Networking.BackgroundTransfer.UploadOperation
-api-type: winrt class
---

<!-- Class syntax.
public class UploadOperation : Windows.Networking.BackgroundTransfer.IBackgroundTransferOperation, Windows.Networking.BackgroundTransfer.IBackgroundTransferOperationPriority, Windows.Networking.BackgroundTransfer.IUploadOperation, Windows.Networking.BackgroundTransfer.IUploadOperation2
-->

# Windows.Networking.BackgroundTransfer.UploadOperation

## -description
Performs an asynchronous upload operation. For an overview of Background Transfer capabilities, see [Transferring data in the background](/previous-versions/windows/apps/hh452979(v=win.10)). Download the [Background transfer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTransfer) for a code example.

## -remarks
After app termination, an app should enumerate all existing UploadOperation instances at next start-up using [GetCurrentUploadsAsync](backgrounduploader_getcurrentuploadsasync_1938169689.md). When a UWP app using Background Transfer is terminated, incomplete uploads will persist in the background. If the app is restarted after termination and these incomplete operations are not enumerated and re-introduced to the current session, they will go stale and continue to occupy device resources.**Timeout considerations**

+ 1.) When establishing a new connection for an upload over TCP/SSL, the connection attempt is aborted if not established within five minutes.
+ 2.) After the connection has been established, an HTTP request message that has not received a response within two minutes is aborted.
Assuming there is Internet connectivity, Background Transfer will retry an upload up to three times. In the event Internet connectivity is not detected, additional attempts will not be made until it is.

**Debugging Guidance**

Stopping a debugging session in Microsoft Visual Studio is comparable to closing your app; PUT uploads are paused and POST uploads are aborted. Even while debugging, your app should enumerate and then pause, restart, or cancel any persisted uploads.

However, if Microsoft Visual Studio project updates, like changes to the app manifest, require that the app is uninstalled and re-deployed for debugging, [GetCurrentUploadsAsync](backgrounduploader_getcurrentuploadsasync_1938169689.md) cannot enumerate persisted operations created using the previous app deployment.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | MakeCurrentInTransferGroup |
| 2004 | 19041 | RemoveRequestHeader |
| 2004 | 19041 | SetRequestHeader |

## -examples
The following example demonstrates how to configure and begin a basic upload operation.

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
[Quickstart: Upload a file](/previous-versions/windows/apps/hh700372(v=win.10)), [Background transfer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTransfer), [Background transfer sample (Windows 8.x)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Background%20Transfer%20sample)

## -capabilities
internetClient, internetClientServer, privateNetworkClientServer
