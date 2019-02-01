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
[Quickstart: Download a file](https://msdn.microsoft.com/library/f7b1a3a0-87b8-4c85-a2a3-be9ff7f04d53), [Background Transfer Download sample](https://go.microsoft.com/fwlink/p/?linkid=245064)
