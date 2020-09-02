---
-api-id: M:Windows.Networking.BackgroundTransfer.DownloadOperation.Pause
-api-type: winrt method
---

<!-- Method syntax
public void Pause()
-->

# Windows.Networking.BackgroundTransfer.DownloadOperation.Pause

## -description
Pauses a download operation.

## -remarks
Calling this method aborts the HTTP request, but preserves state for the download and for the partially downloaded response. This method fails when called for an operation that either: hasn't been started yet; is already paused; or that uses a POST request. To detect when the operation is fully paused, get the value of the [Progress property](/uwp/api/windows.networking.backgroundtransfer.downloadoperation.progress), and then access the [Status field](/uwp/api/windows.networking.backgroundtransfer.backgrounddownloadprogress.status) of that value. When the operation is fully paused, the *Status* field's value will no longer be **Running**. This is important if you need to pause an operation and then change [RequestedUri](/uwp/api/windows.networking.backgroundtransfer.downloadoperation.requesteduri), because you can't make that change while the the *Status* field's value is **Running**.

## -examples

## -see-also
[Quickstart: Download a file](/previous-versions/windows/apps/hh700370(v=win.10)), [Background Transfer Download sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Background%20Transfer%20sample)
