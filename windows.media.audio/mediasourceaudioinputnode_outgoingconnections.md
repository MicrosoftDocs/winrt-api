---
-api-id: P:Windows.Media.Audio.MediaSourceAudioInputNode.OutgoingConnections
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<AudioGraphConnection> OutgoingConnections { get; }
-->

# Windows.Media.Audio.MediaSourceAudioInputNode.OutgoingConnections

## -description
Gets the list of outgoing connections from the **MediaSource** input node to other nodes in the audio graph.

## -property-value
A collection of [AudioGraphConnection](audiographconnection.md) objects representing the supported connections.

## -remarks
This list of outgoing connections is read-only. Call AddOutgoingConnection to connect this node to another node.

## -see-also

## -examples

