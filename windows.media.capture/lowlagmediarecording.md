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
Use the following methods on the [MediaCapture](mediacapture.md) class to initialize the recording, which must be called before [StartAsync](lowlagmediarecording_startasync_1931900819.md): [PrepareLowLagRecordToStreamAsync](mediacapture_preparelowlagrecordtostreamasync_1450185294.md), [PrepareLowLagRecordToStorageFileAsync](mediacapture_preparelowlagrecordtostoragefileasync_1085563722.md), and [PrepareLowLagRecordToCustomSinkAsync](mediacapture_preparelowlagrecordtocustomsinkasync_1787918353.md). These are asynchronous methods which return a LowLagMediaRecording object when they are finished.

[StopAsync](lowlagmediarecording_stopasync_1648475005.md) stops the operation, which can be restarted with [StartAsync](lowlagmediarecording_startasync_1931900819.md).

[FinishAsync](lowlagmediarecording_finishasync_1182664592.md) stops the media recording operation and releases the LowLagMediaRecording object and resources used by the media recording operation. If you want to restart the recording after calling [FinishAsync](lowlagmediarecording_finishasync_1182664592.md), you will need to call one of the **PrepareLowLagRecord** methods to initialize a new LowLagMediaRecording object.

If the media type is changed or an effect is added, you must call [PrepareLowLagRecordToStreamAsync](mediacapture_preparelowlagrecordtostreamasync_1450185294.md), [PrepareLowLagRecordToStorageFileAsync](mediacapture_preparelowlagrecordtostoragefileasync_1085563722.md), or [PrepareLowLagRecordToCustomSinkAsync](mediacapture_preparelowlagrecordtocustomsinkasync_1787918353.md) to create a new LowLagMediaRecording object.

For how-to guidance for using **LowLagMediaCapture** to capture video, see [Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | PauseWithResultAsync |
| 1607 | 14393 | StopWithResultAsync |

## -examples

## -see-also
[Basic photo, video, and audio capture with MediaCapture](/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture), [MediaControl.VideoDeviceController](mediacapture_videodevicecontroller.md), [PrepareLowLagRecordToStreamAsync](mediacapture_preparelowlagrecordtostreamasync_1450185294.md), [PrepareLowLagRecordToStorageFileAsync](mediacapture_preparelowlagrecordtostoragefileasync_1085563722.md), [PrepareLowLagRecordToCustomSinkAsync](/uwp/api/windows.media.capture.mediacapture.preparelowlagrecordtocustomsinkasync)
