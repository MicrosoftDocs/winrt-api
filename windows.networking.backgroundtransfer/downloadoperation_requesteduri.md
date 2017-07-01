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
## -examples

## -see-also
[RecoverableWebErrorStatuses](downloadoperation_recoverableweberrorstatuses.md)