---
-api-id: M:Windows.Media.Capture.Core.VariablePhotoSequenceCapture.UpdateSettingsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction UpdateSettingsAsync()
-->

# Windows.Media.Capture.Core.VariablePhotoSequenceCapture.UpdateSettingsAsync

## -description
Updates the frame control values of the variable photo sequence.

## -returns
An asynchronous action.

## -remarks
This method allows you to efficiently perform multiple variable photo sequence captures with different sets of frame controller values. An instance of [VariablePhotoSequenceController](../windows.media.devices.core/variablephotosequencecontroller.md) is initially obtained with a call to [MediaCapture.PrepareVariablePhotoSequenceCaptureAsync](../windows.media.capture/mediacapture_preparevariablephotosequencecaptureasync_262453199.md). Frame controller values for each frame are registered by appending a [FrameController](variablephotocapturedeventargs_usedframecontrollerindex.md) to the [DesiredFrameControllers](../windows.media.devices.core/variablephotosequencecontroller_desiredframecontrollers.md) collection. After making an initial variable photo sequence capture, you can change the values of the properties of the frame controllers in the [DesiredFrameControllers](../windows.media.devices.core/variablephotosequencecontroller_desiredframecontrollers.md) collection and then call **UpdateSettingsAsync** to have the system register the new frame controller values with the driver.

This method has the following restrictions:


+ This method can't be called while a variable photo sequence capture is in progress. Attempting to call this method between a call to [VariablePhotoSequence.StartAsync](variablephotosequencecapture_startasync_1931900819.md) and the subsequent call to [VariablePhotoSequence.StopAsync](variablephotosequencecapture_stopasync_1648475005.md) will result in an invalid request error.
+ This method can't be called after the variable photo sequence capture has been deinitialized with a call to [VariablePhotoSequence.FinishAsync](variablephotosequencecapture_finishasync_1182664592.md). Doing so will result in an invalid request error. After calling [FinishAsync](variablephotosequencecapture_finishasync_1182664592.md), you must call [PrepareVariablePhotoSequenceCaptureAsync](../windows.media.capture/mediacapture_preparevariablephotosequencecaptureasync_262453199.md) again before calling **UpdateSettingsAsync**.
+ The number of frame controllers must be the same for each variable photo sequence capture separated by calls to **UpdateSettingsAsync**. If you want to capture variable photo sequences with different numbers of frames, you must call [FinishAsync](variablephotosequencecapture_finishasync_1182664592.md) and then call [PrepareVariablePhotoSequenceCaptureAsync](../windows.media.capture/mediacapture_preparevariablephotosequencecaptureasync_262453199.md) again to reinitialize the photo sequence capture.


## -examples

## -see-also
