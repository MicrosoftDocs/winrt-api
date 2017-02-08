---
-api-id: T:Windows.Media.Capture.LowLagMediaRecording
-api-type: winrt class
---

<!-- Class syntax.
public class LowLagMediaRecording : Windows.Media.Capture.ILowLagMediaRecording, Windows.Media.Capture.ILowLagMediaRecording2, Windows.Media.Capture.ILowLagMediaRecording3
-->

# Windows.Media.Capture.LowLagMediaRecording

## -description
Provides methods for taking a low lag media recording.

## -remarks
Use the following methods on the [MediaCapture](mediacapture.md) class to initialize the recording, which must be called before [StartAsync](lowlagmediarecording_startasync.md): [PrepareLowLagRecordToStreamAsync](mediacapture_preparelowlagrecordtostreamasync.md), [PrepareLowLagRecordToStorageFileAsync](mediacapture_preparelowlagrecordtostoragefileasync.md), and [PrepareLowLagRecordToCustomSinkAsync](mediacapture_preparelowlagrecordtocustomsinkasync.md). These are asynchronous methods which return a [LowLagMediaRecording](lowlagmediarecording.md) object when they are finished.

[StopAsync](lowlagmediarecording_stopasync.md) stops the operation, which can be restarted with [StartAsync](lowlagmediarecording_startasync.md).

[FinishAsync](lowlagmediarecording_finishasync.md) stops the media recording operation and releases the [LowLagMediaRecording](lowlagmediarecording.md) object and resources used by the media recording operation. If you want to restart the recording after calling [FinishAsync](lowlagmediarecording_finishasync.md), you will need to call one of the **PrepareLowLagRecord** methods to initialize a new [LowLagMediaRecording](lowlagmediarecording.md) object.

If the media type is changed or an effect is added, you must call [PrepareLowLagRecordToStreamAsync](mediacapture_preparelowlagrecordtostreamasync.md), [PrepareLowLagRecordToStorageFileAsync](mediacapture_preparelowlagrecordtostoragefileasync.md), or [PrepareLowLagRecordToCustomSinkAsync](mediacapture_preparelowlagrecordtocustomsinkasync.md) to create a new [LowLagMediaRecording](lowlagmediarecording.md) object.

For how-to guidance for using **LowLagMediaCapture** to capture video, see [Basic photo, video, and audio capture with MediaCapture](https://msdn.microsoft.com/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).

## -examples

## -see-also
[Basic photo, video, and audio capture with MediaCapture](https://msdn.microsoft.com/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture), [MediaControl.VideoDeviceController](mediacapture_videodevicecontroller.md), [PrepareLowLagRecordToStreamAsync](mediacapture_preparelowlagrecordtostreamasync.md), [PrepareLowLagRecordToStorageFileAsync](mediacapture_preparelowlagrecordtostoragefileasync.md), [PrepareLowLagRecordToCustomSinkAsync](mediacapture_preparelowlagrecordtocustomsinkasync.md)