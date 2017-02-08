---
-api-id: P:Windows.Media.Core.MediaStreamSample.KeyFrame
-api-type: winrt property
---

<!-- Property syntax
public bool KeyFrame { get;  set; }
-->

# Windows.Media.Core.MediaStreamSample.KeyFrame

## -description
Gets or sets a value that indicates the [MediaStreamSample](mediastreamsample.md) contains a keyframe.

## -property-value
**true** if the [MediaStreamSample](mediastreamsample.md) contains a frame that can be decoded independently from other frames; otherwise, **false**. The default value is **false**.

## -remarks
This flag should be set to **true** when the [MediaStreamSample](mediastreamsample.md) contains an audio or video frame which can be independently decoded from other frames. Such frames are sometimes referred to as cleanpoints, I-frames, IDR-frames or key frames.

## -examples

## -see-also
