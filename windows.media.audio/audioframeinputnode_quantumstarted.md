---
-api-id: E:Windows.Media.Audio.AudioFrameInputNode.QuantumStarted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler QuantumStarted<Windows.Media.Audio.AudioFrameInputNode,  Windows.Media.Audio.FrameInputNodeQuantumStartedEventArgs>
-->

# Windows.Media.Audio.AudioFrameInputNode.QuantumStarted

## -description
Raised when the audio graph is ready to begin processing a new quantum of data.

## -remarks
Use the [FrameInputNodeQuantumStartedEventArgs.RequiredSamples](frameinputnodequantumstartedeventargs_requiredsamples.md) property to determine how many samples are required to fill the quantum with data. Pass an [AudioFrame](audioframecompletedeventargs.md) into the [AddFrame](audioframeinputnode_addframe_561479871.md) method to provide the required audio samples.

## -examples

## -see-also
