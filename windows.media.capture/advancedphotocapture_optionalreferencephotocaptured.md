---
-api-id: E:Windows.Media.Capture.AdvancedPhotoCapture.OptionalReferencePhotoCaptured
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler OptionalReferencePhotoCaptured<Windows.Media.Capture.AdvancedPhotoCapture,  Windows.Media.Capture.OptionalReferencePhotoCapturedEventArgs>
-->

# Windows.Media.Capture.AdvancedPhotoCapture.OptionalReferencePhotoCaptured

## -description
Raised when a reference photo for the advanced photo operation has been captured, on devices that support this feature.

## -remarks
Some devices support returning a reference photo from the capture operation that can be consumed by the calling app before all image frames for the operation have been captured or processed. On devices that do not support returning a reference photo, this event is never raised.

## -examples

## -see-also
