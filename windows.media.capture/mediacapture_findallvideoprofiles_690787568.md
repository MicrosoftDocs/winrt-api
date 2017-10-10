---
-api-id: M:Windows.Media.Capture.MediaCapture.FindAllVideoProfiles(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Capture.MediaCaptureVideoProfile> FindAllVideoProfiles(System.String videoDeviceId)
-->

# Windows.Media.Capture.MediaCapture.FindAllVideoProfiles

## -description
Retrieves the list of all video profiles supported by the specified video capture device.

## -parameters
### -param videoDeviceId
The identifier of the video device for which supported video profiles are queried. For information on getting the video device ID, see [DeviceInformation::FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md).

## -returns
The list of video profiles supported by the specified video capture device.

## -remarks
Before calling this method, call [IsVideoProfileSupported](mediacapture_isvideoprofilesupported.md) to make sure that the capture device supports video profiles.

Use [FindKnownVideoProfiles](mediacapture_findknownvideoprofiles.md) to request profiles with specific functionality using one of the [KnownVideoProfile](knownvideoprofile.md) values.

For how-to guidance for working with camera profiles, see [Discover and select camera capabilities with camera profiles](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/camera-profiles).

## -examples

## -see-also
[FindKnownVideoProfiles](mediacapture_findknownvideoprofiles.md), [FindConcurrentProfiles](mediacapture_findconcurrentprofiles.md), [Discover and select camera capabilities with camera profiles](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/camera-profiles)
## -capabilities
backgroundMediaRecording
