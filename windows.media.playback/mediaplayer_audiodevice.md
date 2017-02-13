---
-api-id: P:Windows.Media.Playback.MediaPlayer.AudioDevice
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Enumeration.DeviceInformation AudioDevice { get;  set; }
-->

# Windows.Media.Playback.MediaPlayer.AudioDevice

## -description
Gets or sets the [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object representing audio device used by the [MediaPlayer](mediaplayer.md) to render audio.

## -property-value
The [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object representing audio device used by the [MediaPlayer](mediaplayer.md) to render audio.

## -remarks
To enumerate the currently available audio devices, call [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md), passing in the device selector string returned from [MediaDevice.GetAudioRenderSelector](../windows.media.devices/mediadevice_getaudiorenderselector.md).

## -examples

## -see-also
