---
-api-id: T:Windows.Media.Audio.MediaSourceAudioInputNodeCreationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum MediaSourceAudioInputNodeCreationStatus : int 
-->

# Windows.Media.Audio.MediaSourceAudioInputNodeCreationStatus

## -description
Specifies the result status of a call to [AudioGraph.CreateMediaSourceAudioInputNode](audiograph_createmediasourceaudioinputnodeasync_989225096.md).

## -enum-fields
### -field UnknownFailure:3
The [MediaSourceAudioInputNode](mediasourceaudioinputnode.md) could not be created because of an unknown failure.

### -field Success:0
The **MediaSourceAudioInputNode** was created successfully.

### -field NetworkError:2
The **MediaSourceAudioInputNode** could not be created because of a network error.

### -field FormatNotSupported:1
The **MediaSourceAudioInputNode** could not be created because the media content associated with the **MediaSource** is in a format that is not supported by the [AudioGraph](audiograph.md) API.

## -remarks
[AudioGraph.CreateMediaSourceAudioInputNode](audiograph_createmediasourceaudioinputnodeasync_989225096.md) returns an [IAsyncOperation](../windows.foundation/iasyncoperation_1.md) object that returns a [CreateMediaSourceAudioInputNodeResult](createmediasourceaudioinputnoderesult.md) on completion. This object exposes a [Status](createmediasourceaudioinputnoderesult_status.md) property, containing a value from this enumeration, that indicates either that the operation was successful or the reason why the operation failed. The  [Node](createmediasourceaudioinputnoderesult_node.md) property provides a reference to the created [MediaSourceAudioInputNode](mediasourceaudioinputnode.md) on success.

## -see-also

## -examples

