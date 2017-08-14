---
-api-id: T:Windows.Media.Capture.PhotoCaptureSource
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Capture.PhotoCaptureSource : int
-->

# PhotoCaptureSource

## -description
Specifies which stream on a video camera is used to capture photos.

## -enum-fields
### -field Auto:0
Automatically select the stream.

### -field VideoPreview:1
Use the video stream.

### -field Photo:2
Use the photo stream.


## -remarks
Some video cameras have a separate photo stream that can capture still images at higher resolution than the video stream. For more information on configuring the [MediaCapture](mediacapture.md) object, see [MediaCaptureInitializationSettings](mediacaptureinitializationsettings.md).

## -examples

## -see-also


## -capabilities
microphone, webcam
