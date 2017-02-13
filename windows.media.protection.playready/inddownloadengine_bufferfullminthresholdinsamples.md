---
-api-id: P:Windows.Media.Protection.PlayReady.INDDownloadEngine.BufferFullMinThresholdInSamples
-api-type: winrt property
---

<!-- Property syntax
public uint BufferFullMinThresholdInSamples { get; }
-->

# Windows.Media.Protection.PlayReady.INDDownloadEngine.BufferFullMinThresholdInSamples

## -description
Gets the minimum number of samples a sample buffer can hold before a download engine resumes downloading.

## -property-value
The minimum number of samples that the download engine uses to determine whether to resume downloading.

## -remarks
When the buffer holds a number of samples smaller than this, the download engine is notified to resume downloading.

## -examples

## -see-also
