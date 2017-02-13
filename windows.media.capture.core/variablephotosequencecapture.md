---
-api-id: T:Windows.Media.Capture.Core.VariablePhotoSequenceCapture
-api-type: winrt class
---

<!-- Class syntax.
public class VariablePhotoSequenceCapture : Windows.Media.Capture.Core.IVariablePhotoSequenceCapture, Windows.Media.Capture.Core.IVariablePhotoSequenceCapture2
-->

# Windows.Media.Capture.Core.VariablePhotoSequenceCapture

## -description
Provides methods and events that enable the capture of variable photo sequences.

## -remarks
Call the [MediaCapture.PrepareVariablePhotoSequenceCaptureAsync](../windows.media.capture/mediacapture_preparevariablephotosequencecaptureasync.md) method to obtain an instance of this class.

After starting a variable photo sequence capture, you must stop the variable photo sequence capture by calling [StopAsync](variablephotosequencecapture_stopasync.md) before your app attempts to record video with the [MediaCapture](../windows.media.capture/mediacapture.md) object.

For how-to guidance for using **VariablePhotoSequenceCapture**, see [Capture a photo sequence with VariablePhotoSequence](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/variable-photo-sequence).

## -examples

## -see-also
[Capture a photo sequence with VariablePhotoSequence](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/variable-photo-sequence)