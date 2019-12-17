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
Calling this method will abort the HTTP request but preserve state for the download and the partially downloaded response. This method will fail when called for operations that haven't been started yet, are already paused, or use POST requests.

## -examples

## -see-also
[Quickstart: Download a file](https://docs.microsoft.com/previous-versions/windows/apps/hh700370(v=win.10)), [Background Transfer Download sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Background%20Transfer%20sample)
