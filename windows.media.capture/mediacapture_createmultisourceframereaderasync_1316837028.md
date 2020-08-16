---
-api-id: M:Windows.Media.Capture.MediaCapture.CreateMultiSourceFrameReaderAsync(Windows.Foundation.Collections.IIterable{Windows.Media.Capture.Frames.MediaFrameSource})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<MultiSourceMediaFrameReader> MediaCapture.CreateMultiSourceFrameReaderAsync(IIterable<MediaFrameSource> inputSources)
-->

# Windows.Media.Capture.MediaCapture.CreateMultiSourceFrameReaderAsync


## -description

Creates a [MultiSourceMediaFrameReader](../windows.media.capture.frames/multisourcemediaframereader.md) that is used to acquire time-correlated frames from one or more [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) objects.

## -parameters

### -param inputSources

A [IIterable](../windows.foundation.collections/iiterable_1.md) list of [MediaFrameSource](../windows.media.capture.frames/mediaframesource.md) objects to be used by the frame reader.

## -returns

An asynchronous operation that returns a [MultiSourceMediaFrameReader](../windows.media.capture.frames/multisourcemediaframereader.md) upon successful completion.

## -remarks

## -see-also

## -examples

## -capabilities

backgroundMediaRecording

