---
-api-id: P:Windows.Media.Protection.PlayReady.INDDownloadEngine.BufferFullMaxThresholdInSamples
-api-type: winrt property
---

<!-- Property syntax
public uint BufferFullMaxThresholdInSamples { get; }
-->

# Windows.Media.Protection.PlayReady.INDDownloadEngine.BufferFullMaxThresholdInSamples

## -description
Gets the maximum threshold of the sample buffer.

## -property-value
The maximum number of samples that the download engine uses to determine whether the sample buffer is full.

## -remarks
When the sample buffer contains more samples than this threshold, the download engine is notified to pause.

## -examples

## -see-also
