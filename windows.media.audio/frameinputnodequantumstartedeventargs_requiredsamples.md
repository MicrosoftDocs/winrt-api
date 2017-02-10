---
-api-id: P:Windows.Media.Audio.FrameInputNodeQuantumStartedEventArgs.RequiredSamples
-api-type: winrt property
---

<!-- Property syntax
public int RequiredSamples { get; }
-->

# Windows.Media.Audio.FrameInputNodeQuantumStartedEventArgs.RequiredSamples

## -description
Gets the number of samples that the audio graph requires to fill the quantum with data.

## -property-value
The number of samples that the audio graph requires to fill the quantum with data.

## -remarks
Pass an [AudioFrame](audioframecompletedeventargs.md) into the [AddFrame](audioframeinputnode_addframe.md) method to provide the required audio samples. It is recommended that you only submit the number of samples requested by the audio graph. Submitting extra samples can result in latency in the audio graph.

If the amount of data currently in the node is more than enough to fill one quantum, **RequiredSamples** will be 0.

## -examples

## -see-also
