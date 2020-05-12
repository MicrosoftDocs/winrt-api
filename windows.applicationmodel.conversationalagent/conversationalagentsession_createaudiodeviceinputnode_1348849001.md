---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.CreateAudioDeviceInputNode(Windows.Media.Audio.AudioGraph)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public AudioDeviceInputNode ConversationalAgentSession.CreateAudioDeviceInputNode(AudioGraph graph)
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.CreateAudioDeviceInputNode

## -description

Synchronously creates an audio graph input node.

> [!Important]
> To avoid possible concurrency issues, we recommend using [CreateAudioDeviceInputNodeAsync](conversationalagentsession_createaudiodeviceinputnodeasync_1477409751.md) instead.

## -parameters

### -param graph

An audio graph that represents the connected input, output, and submix nodes for manipulating and routing audio.

## -returns

The [AudioDeviceInputNode](../windows.media.audio/audiodeviceinputnode.md).

## -remarks

## -see-also

[CreateAudioDeviceInputNodeAsync](conversationalagentsession_createaudiodeviceinputnodeasync_1477409751.md)

## -examples
