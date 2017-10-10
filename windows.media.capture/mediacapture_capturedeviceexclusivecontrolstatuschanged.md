---
-api-id: E:Windows.Media.Capture.MediaCapture.CaptureDeviceExclusiveControlStatusChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler CaptureDeviceExclusiveControlStatusChanged<MediaCapture, MediaCaptureDeviceExclusiveControlStatusChangedEventArgs>
-->

# Windows.Media.Capture.MediaCapture.CaptureDeviceExclusiveControlStatusChanged

## -description
Occurs when the exclusive control status of the capture device changes.

## -remarks
When an app has exclusive control of the capture device, it can modify the settings of the device. An app that does not have exclusive control of the capture device can still capture media, but it can't change the capture settings. Request exclusive control by setting the [MediaCaptureInitializationSettings.SharingMode](mediacaptureinitializationsettings_sharingmode.md) property to **ExclusiveControl** before passing the structure into [InitializeAsync](mediacapture_initializeasync_315323248.md). The call to **InitializeAsync** will fail if you request exclusive control when another app already has exclusive access to the device. In this case, you can listen for **CaptureDeviceExclusiveControlStatusChanged**, and if the value of [MediaCaptureDeviceExclusiveControlStatusChangedEventArgs.Status](mediacapturedeviceexclusivecontrolstatuschangedeventargs_status.md) is **ExclusiveControlAvailable**, then you can attempt to reinitialize the **MediaCapture** with exclusive control.

If the **CaptureDeviceExclusiveControlStatusChanged** event is raised and the value of **MediaCaptureDeviceExclusiveControlStatusChangedEventArgs.Status** is **SharedReadOnlyAvailable**, then another app has acquired exclusive control of the device. In this case, you may want to update your UI to alert the user that another app may adjust the capture device settings.

## -see-also

## -examples


## -capabilities
backgroundMediaRecording
