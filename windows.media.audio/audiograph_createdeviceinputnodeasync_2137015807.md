---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateDeviceInputNodeAsync(Windows.Media.Capture.MediaCategory,Windows.Media.MediaProperties.AudioEncodingProperties,Windows.Devices.Enumeration.DeviceInformation,Windows.Media.Audio.AudioNodeEmitter)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Audio.CreateAudioDeviceInputNodeResult> CreateDeviceInputNodeAsync(Windows.Media.Capture.MediaCategory category, Windows.Media.MediaProperties.AudioEncodingProperties encodingProperties, Windows.Devices.Enumeration.DeviceInformation device, Windows.Media.Audio.AudioNodeEmitter emitter)
-->

# Windows.Media.Audio.AudioGraph.CreateDeviceInputNodeAsync

## -description
Creates a spatial audio-enabled [AudioDeviceInputNode](audiodeviceinputnode.md) that inputs audio data into the audio graph from the specified audio input device such as a microphone or audio card.

## -parameters
### -param category
A value from the [MediaCategory](../windows.media.capture/mediacategory.md) enumeration value indicating the category of the media processed by this node, allowing the system to perform content-appropriate processing and prioritization of the media.

### -param encodingProperties
An object representing the audio encoding properties for the device input node which specifies the sample rate at which the created node will operate. Only uncompressed PCM and float formats are allowed.

### -param device
A [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object representing the device from which the device input node will get audio data.

### -param emitter
An object that describes the position and other physical characteristics of the emitter from which the node's audio is emitted when spatial audio processing is used.

## -returns
An asynchronous operation that returns a [CreateAudioDeviceInputNodeResult](createaudiodeviceinputnoderesult.md) on completion. This object exposes a [Status](createaudiodeviceinputnoderesult_status.md) property, that indicates either that the operation was successful or the reason why the operation failed. The [DeviceInputNode](createaudiodeviceinputnoderesult_deviceinputnode.md) property provides a reference to the created input node on success.

## -remarks
Call [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_326280522.md), passing in the value returned by [GetAudioCaptureSelector](../windows.media.devices/mediadevice_getaudiocaptureselector_829052994.md), to get the list of  [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects representing the available capture devices. For more information, see [Audio graphs](/windows/uwp/audio-video-camera/audio-graphs).

## -examples

## -see-also
[CreateDeviceInputNodeAsync(MediaCategory)](audiograph_createdeviceinputnodeasync_420106269.md), [CreateDeviceInputNodeAsync(MediaCategory, AudioEncodingProperties)](audiograph_createdeviceinputnodeasync_1285412965.md), [CreateDeviceInputNodeAsync(MediaCategory, AudioEncodingProperties, DeviceInformation)](audiograph_createdeviceinputnodeasync_757181607.md)
## -capabilities
backgroundMediaRecording
