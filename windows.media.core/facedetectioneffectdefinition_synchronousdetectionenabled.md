---
-api-id: P:Windows.Media.Core.FaceDetectionEffectDefinition.SynchronousDetectionEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool SynchronousDetectionEnabled { get;  set; }
-->

# Windows.Media.Core.FaceDetectionEffectDefinition.SynchronousDetectionEnabled

## -description
Gets or sets a value indicating whether synchronous face detection is enabled.

## -property-value
True if synchronous face detection is enabled; otherwise, false.

## -remarks
When synchronous detection is enabled, the system will delay the return of a video frame until the face detection operation for the frame is complete. When the frames do arrive, the timestamp of the [FaceDetectionEffectFrame](facedetectioneffectframe.md) will match the timestamp of the associated [VideoFrame](../windows.media/videoframe.md). When synchronous detection is disabled, the timestamp of the [FaceDetectionEffectFrame](facedetectioneffectframe.md) will typically be slightly later than the associated[VideoFrame](../windows.media/videoframe.md).

## -examples

## -see-also
