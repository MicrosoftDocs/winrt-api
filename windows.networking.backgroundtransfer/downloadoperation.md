---
-api-id: T:Windows.Networking.BackgroundTransfer.DownloadOperation
-api-type: winrt class
---

<!-- Class syntax.
public class DownloadOperation : Windows.Networking.BackgroundTransfer.IBackgroundTransferOperation, Windows.Networking.BackgroundTransfer.IBackgroundTransferOperationPriority, Windows.Networking.BackgroundTransfer.IDownloadOperation, Windows.Networking.BackgroundTransfer.IDownloadOperation2
-->

# Windows.Networking.BackgroundTransfer.DownloadOperation

## -description
Performs an asynchronous download operation. The [Background transfer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTransfer) demonstrates this functionality. For an overview of Background Transfer capabilities, see [Transferring data in the background](/previous-versions/windows/apps/hh452979(v=win.10)).

## -examples

Sample applications that use this class include the [Background transfer sample](/samples/microsoft/windows-universal-samples/backgroundtransfer/).

The following example demonstrates how to configure and begin a basic download operation.

```csharp
using Windows.Foundation;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;

private async void StartDownload_Click(object sender, RoutedEventArgs e)
{
    try
    {
        Uri source = new Uri(serverAddressField.Text.Trim());
        string destination = fileNameField.Text.Trim();

        StorageFile destinationFile = await KnownFolders.PicturesLibrary.CreateFileAsync(
            destination, CreationCollisionOption.GenerateUniqueName);

        BackgroundDownloader downloader = new BackgroundDownloader();
        DownloadOperation download = downloader.CreateDownload(source, destinationFile);

        // Attach progress and completion handlers.
        HandleDownloadAsync(download, true);
    }
    catch (Exception ex)
    {
        LogException("Download Error", ex);
    }
}
```

## -remarks
At next start-up after application termination, your application should enumerate all existing DownloadOperation instances using [GetCurrentDownloadsAsync](backgrounddownloader_getcurrentdownloadsasync_1101292265.md). When a UWP application using Background Transfer is terminated, incomplete downloads persist in the background. If your application is restarted after termination and these incomplete operations are not enumerated and re-introduced to the current session, then they will go stale and continue to occupy device resources.

Background transfer doesn't support concurrent downloads of the same [Uri](../windows.foundation/uri.md). So an app can download *`http://example.com/myfile.wmv`* once, or download it again after a previous download completed. An app shouldn't start two downloads of the same [Uri](../windows.foundation/uri.md) concurrently, since this may result in truncated files.

> [!NOTE]
> Paused or incomplete download operations can only be resumed if the server accepts range-requests.

**Timeout considerations**

1) When establishing a new connection for a download over TCP/SSL, the connection attempt is aborted if not established within five minutes.
2) After the connection has been established, an HTTP request message that has not received a response within two minutes is aborted.
Assuming there is Internet connectivity, Background Transfer will retry a download up to three times. In the event Internet connectivity is not detected, additional attempts will not be made until it is.

**Debugging Guidance**

Stopping a debugging session in Microsoft Visual Studio is comparable to closing your app; downloads are paused and POST uploads are terminated. Even while debugging, your app should enumerate and then pause, resume, restart, or cancel any persisted downloads.

However, if Microsoft Visual Studio project updates, like changes to the app manifest, require that the app is uninstalled and re-deployed for debugging, [GetCurrentDownloadsAsync](backgrounddownloader_getcurrentdownloadsasync_1101292265.md) cannot enumerate persisted operations created using the previous app deployment.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | CurrentWebErrorStatus |
| 1709 | 16299 | GetDownloadedRanges |
| 1709 | 16299 | GetResultRandomAccessStreamReference |
| 1709 | 16299 | IsRandomAccessRequired |
| 1709 | 16299 | RangesDownloaded |
| 1709 | 16299 | RecoverableWebErrorStatuses |
| 1803 | 17134 | MakeCurrentInTransferGroup |
| 2004 | 19041 | RemoveRequestHeader |
| 2004 | 19041 | SetRequestHeader |

## -see-also
[Quickstart: Download a file](/previous-versions/windows/apps/hh700370(v=win.10)), [Background transfer sample](/samples/microsoft/windows-universal-samples/backgroundtransfer/), [Background transfer sample (Windows 8.x)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Background%20Transfer%20sample)

## -capabilities
internetClient, internetClientServer, privateNetworkClientServer
