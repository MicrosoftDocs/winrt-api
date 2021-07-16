---
-api-id: T:Windows.Media.Audio.CreateAudioDeviceInputNodeResult
-api-type: winrt class
---

<!-- Class syntax.
public class CreateAudioDeviceInputNodeResult : Windows.Media.Audio.ICreateAudioDeviceInputNodeResult
-->

# Windows.Media.Audio.CreateAudioDeviceInputNodeResult

## -description
Represents the result of attempting to create an audio device input node.

## -remarks
Get an instance of this class by calling [AudioGraph.CreateDeviceInputNodeAsync](audiograph_createdeviceinputnodeasync_1285412965.md). Check the [Status](createaudiodeviceinputnoderesult_status.md) property to determine if the node was successfully created, and if so, get the instance of the node with the [DeviceInputNode](createaudiodeviceinputnoderesult_deviceinputnode.md) property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | ExtendedError |

## -examples

## -see-also
