---
-api-id: M:Windows.Media.Capture.MediaCapture.FindConcurrentProfiles(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Capture.MediaCaptureVideoProfile> FindConcurrentProfiles(System.String videoDeviceId)
-->

# Windows.Media.Capture.MediaCapture.FindConcurrentProfiles

## -description
Retrieves the list of video profiles supported by the specified video capture device that can be used while another profile is used on a different capture device.

## -parameters
### -param videoDeviceId
The identifier of the video device for which supported video profiles are queried. For information on getting the video device ID, see [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md).

## -returns
The list of video profiles supported by the specified video capture device that support concurrency.

## -remarks
Before calling this method, call [IsVideoProfileSupported](mediacapture_isvideoprofilesupported_190014579.md) to make sure that the capture device supports video profiles.

This method supports the scenario where you capture video from two capture devices at the same time, such as a device's front camera and rear camera. Call the [GetConcurrency](mediacapturevideoprofile_getconcurrency_2045494455.md) method of one of the [MediaCaptureVideoProfile](mediacapturevideoprofile.md) objects in the returned list to get a list of profiles that can be used concurrently with that profile.

For how-to guidance for working with camera profiles, see [Discover and select camera capabilities with camera profiles](/windows/uwp/audio-video-camera/camera-profiles).

## -examples

## -see-also
[MediaCaptureVideoProfile.GetConcurrency](mediacapturevideoprofile_getconcurrency_2045494455.md), [Discover and select camera capabilities with camera profiles](/windows/uwp/audio-video-camera/camera-profiles)
## -capabilities
backgroundMediaRecording
