---
-api-id: M:Windows.Networking.BackgroundTransfer.BackgroundTransferRangesDownloadedEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax.
public Deferral BackgroundTransferRangesDownloadedEventArgs.GetDeferral()
-->

# Windows.Networking.BackgroundTransfer.BackgroundTransferRangesDownloadedEventArgs.GetDeferral

## -description
Deferral allows apps to carry out asynchronous work within their RangesDownloaded handler without receiving a new [RangesDownloaded event](downloadoperation_rangesdownloaded.md) in the meantime. 

## -returns
**HRESULT** 
## -remarks
Serialized RangesDownloaded events make the app’s code more straightforward and let WinRT BackgroundTransfer coalesce RangesDownloaded events instead of flooding an app with multiple concurrent ones.
## -see-also
[RangesDownloaded Event](downloadoperation_rangesdownloaded.md)
## -examples

