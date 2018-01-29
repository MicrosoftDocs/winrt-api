---
-api-id: P:Windows.Media.Audio.AudioFrameInputNode.OutgoingConnections
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Audio.AudioGraphConnection> OutgoingConnections { get; }
-->

# Windows.Media.Audio.AudioFrameInputNode.OutgoingConnections

## -description
Gets the list of outgoing connections from the audio frame input node to other nodes in the audio graph.

## -property-value
A collection of [AudioGraphConnection](audiographconnection.md) objects representing the supported connections.

## -remarks
This list of outgoing connections is read-only. Call [AddOutgoingConnection](audioframeinputnode_addoutgoingconnection_702981438.md) to connect this node to another node.

## -examples

## -see-also
