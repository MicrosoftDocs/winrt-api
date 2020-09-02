---
-api-id: M:Windows.Media.Capture.MediaCapture.FindKnownVideoProfiles(System.String,Windows.Media.Capture.KnownVideoProfile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Capture.MediaCaptureVideoProfile> FindKnownVideoProfiles(System.String videoDeviceId, Windows.Media.Capture.KnownVideoProfile name)
-->

# Windows.Media.Capture.MediaCapture.FindKnownVideoProfiles

## -description
Retrieves the list of all video profiles supported by the specified video capture device that match the specified [KnownVideoProfile](knownvideoprofile.md) value.

## -parameters
### -param videoDeviceId
The identifier of the video device for which supported video profiles are queried. For information on getting the video device ID, see [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md).

### -param name
A value specifying one of the profile names known by the system.

## -returns
The list of video profiles supported by the specified video capture device that match the specified known profile name.

## -remarks
Before calling this method, call [IsVideoProfileSupported](mediacapture_isvideoprofilesupported_190014579.md) to make sure that the capture device supports video profiles.

This method allows you to request profiles with specific functionality by using one of the [KnownVideoProfile](knownvideoprofile.md) values. Some hardware may support additional profiles that do not correspond to any of the known profile names. Use [FindAllVideoProfiles](mediacapture_findallvideoprofiles_690787568.md) to retrieve all video profiles supported by the video capture device.

For how-to guidance for working with camera profiles, see [Discover and select camera capabilities with camera profiles](/windows/uwp/audio-video-camera/camera-profiles).

## -examples

## -see-also
[KnownVideoProfile](knownvideoprofile.md), [FindAllVideoProfiles](mediacapture_findallvideoprofiles_690787568.md), [FindConcurrentProfiles](mediacapture_findconcurrentprofiles_834250833.md), [Discover and select camera capabilities with camera profiles](/windows/uwp/audio-video-camera/camera-profiles)
## -capabilities
backgroundMediaRecording
