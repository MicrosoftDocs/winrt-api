---
-api-id: P:Windows.Networking.BackgroundTransfer.BackgroundTransferRangesDownloadedEventArgs.WasDownloadRestarted
-api-type: winrt property
---

<!-- Property syntax.
public bool WasDownloadRestarted { get; }
-->

# Windows.Networking.BackgroundTransfer.BackgroundTransferRangesDownloadedEventArgs.WasDownloadRestarted

## -description
TRUE if the download was restarted from scratch since the previous RangesDownloaded event.  

## -property-value
TRUE if the download was restarted from scratch since the previous RangesDownloaded event, otherwise FALSE.
## -remarks
This is important, as the app will need to reset any state related to previously-processed DownloadedRanges data in that case. Download restarts can occur if the remote file’s timestamp or ETag changes.
## -see-also
[RangesDownloaded Event](downloadoperation_rangesdownloaded.md)
## -examples

