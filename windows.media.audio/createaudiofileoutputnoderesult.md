---
-api-id: T:Windows.Media.Audio.CreateAudioFileOutputNodeResult
-api-type: winrt class
---

<!-- Class syntax.
public class CreateAudioFileOutputNodeResult : Windows.Media.Audio.ICreateAudioFileOutputNodeResult
-->

# Windows.Media.Audio.CreateAudioFileOutputNodeResult

## -description
Represents the result of attempting to create an audio file output node.

## -remarks
Get an instance of this class by calling [AudioGraph.CreateFileOutputNodeAsync](audiograph_createfileoutputnodeasync_1127853521.md). Check the [Status](createaudiofileoutputnoderesult_status.md) property to determine if the node was successfully created, and if so, get the instance of the node with the [FileOutputNode](createaudiofileoutputnoderesult_fileoutputnode.md) property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | ExtendedError |

## -examples

## -see-also
