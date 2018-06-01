---
-api-id: N:Windows.Networking.BackgroundTransfer
-api-type: winrt namespace
---

# Windows.Networking.BackgroundTransfer

## -description

Enables advanced download and upload transfer capabilities within an app. For an overview of Background Transfer capabilities, see [Transferring data in the background](http://msdn.microsoft.com/library/9e2ed5b4-af57-456a-884f-1e1d2136a8e8). Download the [Background Transfer sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTransfer) for examples in JavaScript, C#, and C++.

> [!NOTE]
> Background transfer is primarily designed for long-term transfer operations for resources like video, music, and large images. For short-term operations involving transfers of smaller resources (i.e. a couple KB), the HTTP APIs are recommended. [HttpClient](../windows.web.http/httpclient.md) is preferred and can be used in all languages supported by UWP apps. [XHR](http://msdn.microsoft.com/library/62fc3e32-3d52-4654-8807-8c0563150f01) can be used in JavaScript. [IXHR2](http://msdn.microsoft.com/library/cc7aed53-b2c5-4d83-b85d-cff2f5ba7b35) can be used in C++.

## -remarks

On most platforms, Background Transfer will continue to transfer your files (download or upload) even when the app is suspended or when it exits. When your app starts up, you should call [BackgroundDownloader.GetCurrentDownloadsAsync](backgrounddownloader_getcurrentdownloadsasync_1101292265.md) or [BackgroundUploader.GetCurrentUploadsAsync](backgrounduploader_getcurrentuploadsasync_1938169689.md) to enumerate all of your incomplete transfers. Then call [DownloadOperation.AttachAsync](downloadoperation_attachasync_267853378.md) or [UploadOperation.AttachAsync](uploadoperation_attachasync_267853378.md), respectively, on each one. Doing so retrieves the transfer's latest state and causes the transfers to be resumed after a system reboot. When [DownloadOperation.IsRandomAccessRequired](downloadoperation_israndomaccessrequired.md) is `true`, the download resumes automatically after a reboot. You should call **AttachAsync** even in that case. If your app is running when the transfers complete (that is, when the call to **AttachAsync** returns), then you can do work in response. Alternatively, you can use [BackgroundTransferCompletionGroup](backgroundtransfercompletiongroup.md) to launch a background task when the transfers complete.

On Xbox, Background Transfer only transfers your files (download or upload) while the app is in the foreground. When an app is either suspended, put into the background, or has exited, the app's background transfers are suspended. When the app runs in the foreground again, its transfers are resumed automatically.

## -examples

## -see-also

[Adding support for networking](http://msdn.microsoft.com/library/1c5819d6-bed7-4d65-b9d7-af5a2239b43f), [How to configure network isolation capabilities](http://msdn.microsoft.com/library/0a97956e-fda9-4791-b87b-9e03ae135382), [Quickstart: Downloading a file](http://msdn.microsoft.com/library/f7b1a3a0-87b8-4c85-a2a3-be9ff7f04d53), [Quickstart: Uploading a file](http://msdn.microsoft.com/library/9c0d21a9-d253-4671-a0ef-437412a28cd8), [Transferring a file from a network resource](http://msdn.microsoft.com/library/0101fd52-e381-42ef-84df-86a406316e7b), [Transferring data in the background](http://msdn.microsoft.com/library/9e2ed5b4-af57-456a-884f-1e1d2136a8e8), [HttpClient](../windows.web.http/httpclient.md), [IXHR2](http://msdn.microsoft.com/library/cc7aed53-b2c5-4d83-b85d-cff2f5ba7b35), [Windows.Storage](../windows.storage/windows_storage.md), [XHR](http://msdn.microsoft.com/library/62fc3e32-3d52-4654-8807-8c0563150f01), [Background Transfer sample](http://go.microsoft.com/fwlink/p/?linkid=245064), [Background transfer sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620510)
