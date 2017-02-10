---
-api-id: P:Windows.Networking.BackgroundTransfer.DownloadOperation.Progress
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.BackgroundTransfer.BackgroundDownloadProgress Progress { get; }
-->

# Windows.Networking.BackgroundTransfer.DownloadOperation.Progress

## -description
Gets the current progress of the upload operation.

## -property-value
The download operation status change.

## -remarks
The value of the Progress property is updated in real time, which means that the value can change while a progress handler is executing. As a best practice, create a local copy of the Progress property at the beginning of your progress handler, and use only that copy in your progress handler, to maintain a consistent view of progress as your handler executes.

## -examples

## -see-also
[Background Transfer Download  sample](http://go.microsoft.com/fwlink/p/?linkid=245064)