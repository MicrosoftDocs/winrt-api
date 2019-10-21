---
-api-id: M:Windows.Networking.BackgroundTransfer.DownloadOperation.Resume
-api-type: winrt method
---

<!-- Method syntax
public void Resume()
-->

# Windows.Networking.BackgroundTransfer.DownloadOperation.Resume

## -description
Resumes a paused download operation.

## -remarks
This method can be called on a paused download operation to resume the download. The download operation will try to resume the download if possible. Only requests where the server accepts range-requests can resume. Otherwise the download is restarted.

## -examples

## -see-also
[Quickstart: Download a file](https://docs.microsoft.com/previous-versions/windows/apps/hh700370(v=win.10)), [Background Transfer Download sample](https://go.microsoft.com/fwlink/p/?linkid=245064)
