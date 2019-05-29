---
-api-id: N:Windows.Networking.BackgroundTransfer
-api-type: winrt namespace
---

# Windows.Networking.BackgroundTransfer

## -description

Enables advanced download and upload transfer capabilities within an app. For an overview of Background Transfer capabilities, see [Transferring data in the background](https://docs.microsoft.com/previous-versions/windows/apps/hh452979(v=win.10)). Download the [Background Transfer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTransfer) for examples in JavaScript, C#, and C++.

> [!NOTE]
> Background transfer is primarily designed for long-term transfer operations for resources like video, music, and large images. For short-term operations involving transfers of smaller resources (i.e. a couple KB), the HTTP APIs are recommended. [HttpClient](../windows.web.http/httpclient.md) is preferred and can be used in all languages supported by UWP apps. [XHR](https://docs.microsoft.com/previous-versions/windows/apps/br229787(v=win.10)) can be used in JavaScript. [IXHR2](https://docs.microsoft.com/previous-versions/windows/apps/hh770550(v=win.10)) can be used in C++.

## -remarks

On most platforms, Background Transfer will continue to transfer your files (download or upload) even when the app is suspended or when it exits. When your app starts up, you should call [BackgroundDownloader.GetCurrentDownloadsAsync](backgrounddownloader_getcurrentdownloadsasync_1101292265.md) or [BackgroundUploader.GetCurrentUploadsAsync](backgrounduploader_getcurrentuploadsasync_1938169689.md) to enumerate all of your incomplete transfers. Then call [DownloadOperation.AttachAsync](downloadoperation_attachasync_267853378.md) or [UploadOperation.AttachAsync](uploadoperation_attachasync_267853378.md), respectively, on each one. Doing so retrieves the transfer's latest state and causes the transfers to be resumed after a system reboot. When [DownloadOperation.IsRandomAccessRequired](downloadoperation_israndomaccessrequired.md) is `true`, the download resumes automatically after a reboot. You should call **AttachAsync** even in that case. If your app is running when the transfers complete (that is, when the call to **AttachAsync** returns), then you can do work in response. Alternatively, you can use [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) to launch a background task when the transfers complete.

On Xbox, Background Transfer only transfers your files (download or upload) while the app is in the foreground. When an app is either suspended, put into the background, or has exited, the app's background transfers are suspended. When the app runs in the foreground again, its transfers are resumed automatically.

## -examples

## -see-also

[Adding support for networking](https://docs.microsoft.com/previous-versions/windows/apps/hh452752(v=win.10)), [How to configure network isolation capabilities](https://docs.microsoft.com/previous-versions/windows/apps/hh770532(v=win.10)), [Quickstart: Downloading a file](https://docs.microsoft.com/previous-versions/windows/apps/hh700370(v=win.10)), [Quickstart: Uploading a file](https://docs.microsoft.com/previous-versions/windows/apps/hh700372(v=win.10)), [Transferring a file from a network resource](https://docs.microsoft.com/previous-versions/windows/apps/hh761434(v=win.10)), [Transferring data in the background](https://docs.microsoft.com/previous-versions/windows/apps/hh452979(v=win.10)), [HttpClient](../windows.web.http/httpclient.md), [IXHR2](https://docs.microsoft.com/previous-versions/windows/apps/hh770550(v=win.10)), [Windows.Storage](../windows.storage/windows_storage.md), [XHR](https://docs.microsoft.com/previous-versions/windows/apps/br229787(v=win.10)), [Background Transfer sample](https://go.microsoft.com/fwlink/p/?linkid=245064), [Background transfer sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620510)
