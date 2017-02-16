---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateDeviceInputNodeAsync(Windows.Media.Capture.MediaCategory,Windows.Media.MediaProperties.AudioEncodingProperties,Windows.Devices.Enumeration.DeviceInformation,Windows.Media.Audio.AudioNodeEmitter)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Audio.CreateAudioDeviceInputNodeResult> CreateDeviceInputNodeAsync(Windows.Media.Capture.MediaCategory category, Windows.Media.MediaProperties.AudioEncodingProperties encodingProperties, Windows.Devices.Enumeration.DeviceInformation device, Windows.Media.Audio.AudioNodeEmitter emitter)
-->

# Windows.Media.Audio.AudioGraph.CreateDeviceInputNodeAsync

## -description
Creates a device input node that supports spatial audio for the indicated media, audio encoding properties, and device information.

## -parameters
### -param category
An enumeration value indicating the category of the media processed by this node.

### -param encodingProperties
An object representing the audio encoding properties for the device input node.

### -param device
An object representing the device associated with the device input node.

### -param emitter
An object that describes the position and other physical characteristics of the emitter from which the node's audio is emitted when spatial audio processing is used.

## -returns
An asynchronous operation that returns a [CreateAudioDeviceInputNodeResult](createaudiodeviceinputnoderesult.md) on completion. This object exposes a [Status](createaudiodeviceinputnoderesult_status.md) property, that indicates either that the operation was successful or the reason why the operation failed. The [DeviceInputNode](createaudiodeviceinputnoderesult_deviceinputnode.md) property provides a reference to the created input node on success.

## -remarks

## -examples

## -see-also
[CreateDeviceInputNodeAsync(MediaCategory)](audiograph_createdeviceinputnodeasync_420106269.md), [CreateDeviceInputNodeAsync(MediaCategory, AudioEncodingProperties)](audiograph_createdeviceinputnodeasync_1285412965.md), [CreateDeviceInputNodeAsync(MediaCategory, AudioEncodingProperties, DeviceInformation)](audiograph_createdeviceinputnodeasync_757181607.md)