---
-api-id: T:Windows.Media.Capture.OptionalReferencePhotoCapturedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class OptionalReferencePhotoCapturedEventArgs : Windows.Media.Capture.IOptionalReferencePhotoCapturedEventArgs
-->

# Windows.Media.Capture.OptionalReferencePhotoCapturedEventArgs

## -description
Provides data for the AdvancedPhotoCapture.OptionalReferencePhotoCaptured event.

## -remarks
Get an instance of this class by handling the AdvancedPhotoCapture.OptionalReferencePhotoCaptured event.

Some devices support returning a reference photo from the capture operation that can be consumed by the calling app before all image frames for the operation have been captured or processed. On devices that do not support returning a reference photo, this event is never raised.

For how-to guidance for using [AdvancedPhotoCapture](advancedphotocapture.md), see [High dynamic range (HDR) and low-light photo capture](/windows/uwp/audio-video-camera/high-dynamic-range-hdr-photo-capture).

## -examples

## -see-also
[AdvancedPhotoCapture](advancedphotocapture.md), [High dynamic range (HDR) and low-light photo capture](/windows/uwp/audio-video-camera/high-dynamic-range-hdr-photo-capture)
