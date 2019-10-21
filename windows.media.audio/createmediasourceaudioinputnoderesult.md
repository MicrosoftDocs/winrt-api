---
-api-id: T:Windows.Media.Audio.CreateMediaSourceAudioInputNodeResult
-api-type: winrt class
---

<!-- Class syntax.
public class CreateMediaSourceAudioInputNodeResult 
-->

# Windows.Media.Audio.CreateMediaSourceAudioInputNodeResult

## -description
Represents the result of attempting to create a [MediaSourceAudioInputNode](mediasourceaudioinputnode.md).

## -remarks
Get an instance of this class by calling [AudioGraph.CreateMediaSourceAudioInputNodeAsync](audiograph_createmediasourceaudioinputnodeasync_989225096.md). Check the [Status](createmediasourceaudioinputnoderesult_status.md) property to determine if the node was successfully created, and if so, get the instance of the node with the [Node](createmediasourceaudioinputnoderesult_node.md) property.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | ExtendedError |

## -see-also

## -examples

