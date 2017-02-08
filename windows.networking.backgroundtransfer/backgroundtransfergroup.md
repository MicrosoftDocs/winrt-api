---
-api-id: T:Windows.Networking.BackgroundTransfer.BackgroundTransferGroup
-api-type: winrt class
---

<!-- Class syntax.
public class BackgroundTransferGroup : Windows.Networking.BackgroundTransfer.IBackgroundTransferGroup
-->

# Windows.Networking.BackgroundTransfer.BackgroundTransferGroup

## -description
A named group used to associate multiple download or upload operations. This class makes it easy for your app to create these groups and to complete downloads and uploads simultaneously, in serial, or based on priority.

For example, if a user decides to download and watch episodes from a popular television series, your app can prioritize the earliest episodes in the series or let the user choose which episode to download first.

## -remarks
A [BackgroundTransferGroup](backgroundtransfergroup.md) object can persist to support transfer operations that span app sessions. New methods have been introduced to [BackgroundDownloader](backgrounddownloader.md), [BackgroundUploader](backgrounduploader.md), [DownloadOperation](downloadoperation.md), and [UploadOperation](uploadoperation.md) to simplify accessing groups created in a previous app session.

> [!NOTE]
> Up to 50 unique transfer groups per app are supported.

## -examples

## -see-also
