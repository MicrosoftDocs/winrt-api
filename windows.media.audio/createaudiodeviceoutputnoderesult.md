---
-api-id: T:Windows.Media.Audio.CreateAudioDeviceOutputNodeResult
-api-type: winrt class
---

<!-- Class syntax.
public class CreateAudioDeviceOutputNodeResult : Windows.Media.Audio.ICreateAudioDeviceOutputNodeResult
-->

# Windows.Media.Audio.CreateAudioDeviceOutputNodeResult

## -description
Represents the result of attempting to create an audio device output node.

## -remarks
Get an instance of this class by calling [AudioGraph.CreateDeviceOutputNodeAsync](audiograph_createdeviceoutputnodeasync_954542725.md). Check the [Status](createaudiodeviceoutputnoderesult_status.md) property to determine if the node was successfully created, and if so, get the instance of the node with the [DeviceOutputNode](createaudiodeviceoutputnoderesult_deviceoutputnode.md) property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | ExtendedError |

## -examples

## -see-also
