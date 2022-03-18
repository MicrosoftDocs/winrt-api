---
-api-id: M:Windows.Media.Devices.VideoDeviceController.TryGetPowerlineFrequency(Windows.Media.Capture.PowerlineFrequency@)
-api-type: winrt method
---

<!-- Method syntax
public bool TryGetPowerlineFrequency(Windows.Media.Capture.PowerlineFrequency value)
-->

# Windows.Media.Devices.VideoDeviceController.TryGetPowerlineFrequency

## -description
Gets the local power line frequency.

## -parameters
### -param value
The power line frequency.

## -returns
Returns true if the method succeeded, or false otherwise.

## -remarks
You can use this method if the camera supports anti-flicker processing for fluorescent lights.

For how-to guidance for handling powerline frequency, see [Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture).

## -examples

## -see-also
[Manual camera controls for photo and video capture](/windows/uwp/audio-video-camera/capture-device-controls-for-photo-and-video-capture)