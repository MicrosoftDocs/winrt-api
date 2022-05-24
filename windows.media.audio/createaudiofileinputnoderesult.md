---
-api-id: T:Windows.Media.Audio.CreateAudioFileInputNodeResult
-api-type: winrt class
---

<!-- Class syntax.
public class CreateAudioFileInputNodeResult : Windows.Media.Audio.ICreateAudioFileInputNodeResult
-->

# Windows.Media.Audio.CreateAudioFileInputNodeResult

## -description
Represents the result of attempting to create an audio file input node.

## -remarks
Get an instance of this class by calling [AudioGraph.CreateFileInputNodeAsync](audiograph_createfileinputnodeasync_152724062.md). Check the [Status](createaudiofileinputnoderesult_status.md) property to determine if the node was successfully created, and if so, get the instance of the node with the [FileInputNode](createaudiofileinputnoderesult_fileinputnode.md) property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | ExtendedError |

## -examples

## -see-also
