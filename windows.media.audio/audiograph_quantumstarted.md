---
-api-id: E:Windows.Media.Audio.AudioGraph.QuantumStarted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler QuantumStarted<Windows.Media.Audio.AudioGraph,  object>
-->

# Windows.Media.Audio.AudioGraph.QuantumStarted

## -description
Notifies that the audio graph has started processing a new quantum.

## -remarks
The **QuantumStarted** event is synchronous, which means that you can't update the properties or state of the [AudioGraph](audiograph.md) or the individual audio nodes in the handler for this event. Attempting perform an operation such as stopping the audio graph or adding, removing, or starting an individual audio node will result in an exception being thrown. You can change the state of the graph and its nodes from within the asynchronous [QuantumProcessed](audiograph_quantumprocessed.md) event handler.

Because this event is synchronous and fires regularly on the processing cadence of the audio graph, the event handler can be used for synchronized processing of audio data, such as that obtained from the [AudioFrameOutputNode.GetFrame](audioframeoutputnode_getframe.md) method.

## -examples

## -see-also
