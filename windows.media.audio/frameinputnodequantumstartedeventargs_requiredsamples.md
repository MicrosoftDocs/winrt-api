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
Pass an [AudioFrame](audioframecompletedeventargs.md) into the [AddFrame](audioframeinputnode_addframe_561479871.md) method to provide the required audio samples. It is recommended that you only submit the number of samples requested by the audio graph. Submitting extra samples can result in latency in the audio graph.

If the amount of data currently in the node is more than enough to fill one quantum, **RequiredSamples** will be 0.

Note that the count returned by this property represents the required number of audio frames to fill the quantum. The number of samples required depends on the number of channels in the audio encoding settings. For example, for 2-channel audio the required number of samples is actually twice the value returned by this property.

## -examples

## -see-also
