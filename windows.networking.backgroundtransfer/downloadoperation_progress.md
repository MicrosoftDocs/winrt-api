---
-api-id: P:Windows.Networking.BackgroundTransfer.DownloadOperation.Progress
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.BackgroundTransfer.BackgroundDownloadProgress Progress { get; }
-->

# Windows.Networking.BackgroundTransfer.DownloadOperation.Progress

## -description
Gets the current progress of the operation.

## -property-value
An instance of a [BackgroundDownloadProgress](backgrounddownloadprogress.md) struct describing the current download operation's progress.

## -remarks
The value of **Progress** is updated in real time, which means that the value can change while a progress handler is executing. As a best practice, create a local copy of the value of the **Progress** property at the beginning of your progress handler, and use only that copy in your progress handler, to maintain a consistent view of progress as your handler executes.

## -examples

## -see-also
[Background Transfer Download sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Background%20Transfer%20sample)
