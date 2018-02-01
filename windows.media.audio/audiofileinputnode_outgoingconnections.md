---
-api-id: P:Windows.Media.Audio.AudioFileInputNode.OutgoingConnections
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Audio.AudioGraphConnection> OutgoingConnections { get; }
-->

# Windows.Media.Audio.AudioFileInputNode.OutgoingConnections

## -description
Gets the list of outgoing connections from the audio file input node to other nodes in the audio graph.

## -property-value
A collection of [AudioGraphConnection](audiographconnection.md) objects representing the supported connections.

## -remarks
This list of outgoing connections is read-only. Call [AddOutgoingConnection](audiofileinputnode_addoutgoingconnection_702981438.md) to connect this node to another node.

## -examples

## -see-also
