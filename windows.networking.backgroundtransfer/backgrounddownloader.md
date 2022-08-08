---
-api-id: T:Windows.Networking.BackgroundTransfer.BackgroundDownloader
-api-type: winrt class
---

<!-- Class syntax.
public class BackgroundDownloader : Windows.Networking.BackgroundTransfer.IBackgroundDownloader, Windows.Networking.BackgroundTransfer.IBackgroundDownloader2, Windows.Networking.BackgroundTransfer.IBackgroundDownloader3, Windows.Networking.BackgroundTransfer.IBackgroundTransferBase
-->

# Windows.Networking.BackgroundTransfer.BackgroundDownloader

## -description

Used to configure downloads prior to the actual creation of the download operation using [CreateDownload](backgrounddownloader_createdownload_1461958690.md). For an overview of Background Transfer capabilities, see [Transferring data in the background](/previous-versions/windows/apps/hh452979(v=win.10)). Download the [Background transfer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTransfer) for a code example.

> [!NOTE]
> Background Transfer is primarily designed for long-term transfer operations for resources like video, music, and large images. For short-term operations involving transfers of smaller resources (i.e. a couple KB), use the [Windows.Web.Http](../windows.web.http/windows_web_http.md) namespace.

## -remarks

After app termination, an app should enumerate all existing [DownloadOperation](downloadoperation.md) instances at next start-up using [GetCurrentDownloadsAsync](backgrounddownloader_getcurrentdownloadsasync_1101292265.md). When a UWP app using Background Transfer is terminated, incomplete downloads will persist in the background. If the app is restarted after termination and operations from the previous session are not enumerated and re-attached to the current session, they will remain incomplete and continue to occupy resources.

> [!NOTE]
> When an app is uninstalled any current or persisted Background Transfer operations associated with it are cleaned up.

Background transfer doesn't support concurrent downloads of the same [Uri](../windows.foundation/uri.md). So an app can download *`http://example.com/myfile.wmv`* once, or download it again after a previous download completed. An app shouldn't start two downloads of the same [Uri](../windows.foundation/uri.md) concurrently, since this may result in truncated files.

When implementing a library for Background Transfer operations, and this same library is used by other apps or components, specify a unique*group* name string (for example, a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid)) when creating downloads. An download with a group name string can only be enumerated by providing the matching string to [GetCurrentDownloadsAsync(String)](backgrounddownloader_getcurrentdownloadsasync_405117897.md), and will not appear in [GetCurrentDownloadsAsync](backgrounddownloader_getcurrentdownloadsasync_1101292265.md) calls without. This will ensure that other apps implementing that same library for downloads will not see your downloads.

Download operations via FTP are supported. However, for FTP operations, authentication credentials must be provided within the specified URI. For example, **ftp://user:password@server/file.txt**.

Security concerns can exist when download operations require a username and password for authentication. If the authentication model to be used is supported by **WinINet**, use the [ServerCredential](backgrounddownloader_servercredential.md) or [ProxyCredential](backgrounddownloader_proxycredential.md) properties. These values will be securely saved in **WinVault**. For information on supported authentication methods, see [Handling Authentication](/windows/desktop/WinInet/handling-authentication).

If the authentication model is not supported by **WinINet**, use [HttpClient](../windows.web.http/httpclient.md) to implement custom authentication and obtain a download-specific secure token (cookie). Set the appropriate header to have the secure token value used for background transfer. The service should limit the validity of the secure token only to the file that is being downloaded. 

> [!NOTE]
> The secure token will be stored in clear text within the application's folder.

Upload services that require the username and password be set in clear text in a custom header for each download file are insecure. Background transfer will cache the headers in clear text for the duration of the operation within the app's folder.

**Toast notifications**

The BackgroundDownloader class in Windows 8.1 and Windows Server 2012 R2 supports options for the user to receive tile and toast notifications when a transfer is completed successfully or fails to complete.

An app that uses [Windows.Networking.BackgroundTransfer](windows_networking_backgroundtransfer.md) to communicate through a toast notification must declare that it is **Toast capable** in the app manifest file. The **Toast capable** setting is located under the **Notifications** section of **Application** tab. Set the **Toast capable** option to "Yes" so the app can receive toast notifications.

If **Toast capable** is not enabled in the app manifest, then any toast settings in the [Windows.Networking.BackgroundTransfer](windows_networking_backgroundtransfer.md) namespace will be silently ignored and no toasts notifications will be received by the app.

> [!NOTE]
> A user can manually disable or enable toast notifications for your app at any time.

For more information on toast notifications, see [Sending toast notifications](/previous-versions/windows/apps/hh868266(v=win.10)) and [How to opt in for toast notifications](/previous-versions/windows/apps/hh868218(v=win.10)).

**Handling exceptions**

A number of errors can cause exceptions to occur during a download operation. You should write code to handle exceptions when you call methods on this class. Exceptions can result from parameter validation errors, name resolution failures, and network errors. Exceptions from network errors (loss of connectivity, connection failures, and other HTTP errors, for example) can happen at any time. These errors result in exceptions being thrown. If not handled by your app, an exception can cause your entire app to be terminated by the runtime.

An app can use the **HRESULT** from the exception to determine the error that caused the exception. An app can then decide how to handle the exception based on the error code. The [BackgroundTransferError.GetStatus](backgroundtransfererror_getstatus_1856274933.md) method can convert most **HRESULT** values returned to a [WebErrorStatus](../windows.web/weberrorstatus.md) enumeration value. Most of the [WebErrorStatus](../windows.web/weberrorstatus.md) enumeration values correspond to an error returned by the native HTTP or FTP client operation. An app can filter on specific [WebErrorStatus](../windows.web/weberrorstatus.md) enumeration values to modify app behavior depending on the cause of the exception.

For information on network exceptions, see [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)).

**Debugging Guidance**

Stopping a debugging session in Microsoft Visual Studio is comparable to closing your app. Even while debugging, your app should enumerate and then, resume, restart, or cancel any downloads persisted from the previous session. For example, you can have your app cancel enumerated persisted download operations at app startup if there is no interest in previous operations for the current debug session.

If there are Microsoft Visual Studio project updates, like changes to the app manifest, and the app is uninstalled and re-deployed, [GetCurrentUploadsAsync](backgrounduploader_getcurrentuploadsasync_1938169689.md) cannot enumerate operations created using the previous app deployment.

See [Debugging and testing UWP apps](/previous-versions/dd264943(v=vs.140)) for more information.

When using Background Transfer during development, you may get into a situation where the internal caches of active and completed transfer operations can get out of sync. This may result in the inability to start new transfer operations or interact with existing operations and [BackgroundTransferGroup](backgroundtransfergroup.md) objects. In some cases, attempting to interact with existing operations may trigger a crash. This result can occur if the [TransferBehavior](backgroundtransfergroup_transferbehavior.md) property is set to **Parallel**. This issue occurs only in certain scenarios during development and is not applicable to end users of your app.

Four scenarios using Microsoft Visual Studio can cause this issue.

+ You create a new project with the same app name as an existing project, but a different language (from C++ to C#, for example).
+ You change the target architecture (from x86 to x64, for example) in an existing project.
+ You change the culture (from neutral to en-US, for example) in an existing project.
+ You add or remove a capability in the package manifest (adding **Enterprise Authentication**, for example) in an existing project.
 Regular app servicing, including manifest updates which add or remove capabilities, do not trigger this issue on end user deployments of your app.

To work around this issue, completely uninstall all versions of the app and re-deploy with the new language, architecture, culture, or capability. This can be done via the **Start** screen or using PowerShell and the `Remove-AppxPackage` cmdlet.

## -examples

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

## -see-also

[DownloadOperation](downloadoperation.md), [Handling exceptions in network apps](/previous-versions/windows/apps/dn263211(v=win.10)), [How to opt in for toast notifications](/previous-versions/windows/apps/hh868218(v=win.10)), [Quickstart: Download a file](/previous-versions/windows/apps/hh700370(v=win.10)), [Background transfer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTransfer), [Background transfer sample (Windows 8.x)](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Background%20Transfer%20sample)

## -capabilities

internetClient, internetClientServer, privateNetworkClientServer
