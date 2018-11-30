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
[Quickstart: Download a file](http://msdn.microsoft.com/library/f7b1a3a0-87b8-4c85-a2a3-be9ff7f04d53), [Background Transfer Download sample](http://go.microsoft.com/fwlink/p/?linkid=245064)