---
-api-id: P:Windows.Networking.BackgroundTransfer.DownloadOperation.RequestedUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri RequestedUri { get; }
-->

# Windows.Networking.BackgroundTransfer.DownloadOperation.RequestedUri

## -description
Gets the URI from which to download the file.

## -property-value
The URI to download from.

## -remarks
The URI can be updated in for transfers that have hit a recoverable error (PausedRecoverableWebErrorStatus), or that have explicitly paused by the app (PausedByApplication). Once the URI has been updated, the app must call [DownloadOperation.Resume](downloadoperation_resume_406343050.md) to initiate a retry.

Due to OS limitations, downloads that don't opt into random access mode will always restart from scratch whenever their URL is updated. To opt into random access mode, set [DownloadOperation.IsRandomAccessRequired](downloadoperation_israndomaccessrequired.md) to true. Transfers configured that way have full support for resumable URL updates. If the timestamp or file size of the updated URL is different from that of the previous URL, the download will restart from scratch. Otherwise, the transfer will resume from the same position using the new URL.

## -examples

## -see-also
[RecoverableWebErrorStatuses](downloadoperation_recoverableweberrorstatuses.md)
