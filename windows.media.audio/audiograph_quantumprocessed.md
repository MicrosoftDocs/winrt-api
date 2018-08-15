---
-api-id: E:Windows.Media.Audio.AudioGraph.QuantumProcessed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler QuantumProcessed<Windows.Media.Audio.AudioGraph,  object>
-->

# Windows.Media.Audio.AudioGraph.QuantumProcessed

## -description
Notifies that the audio graph has processed the specified quantum.

## -remarks
The **QuantumProcessed** event is asynchronous, which means that you can update the properties and state of the [AudioGraph](audiograph.md) and individual audio nodes in the handler for this event. However, because this event is asynchronous and raised only after the audio engine has completed processing, it is not raised on a regular cadence and it should not be used for synchronized processing of audio data such as that obtained from the [AudioFrameOutputNode.GetFrame](audioframeoutputnode_getframe_21670008.md) method. Instead, it is recommended that you use the [QuantumStarted](audiograph_quantumstarted.md) event for synchronized audio processing.

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
