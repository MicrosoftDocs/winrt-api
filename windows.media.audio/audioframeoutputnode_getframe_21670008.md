---
-api-id: M:Windows.Media.Audio.AudioFrameOutputNode.GetFrame
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.AudioFrame GetFrame()
-->

# Windows.Media.Audio.AudioFrameOutputNode.GetFrame

## -description
Gets an audio frame containing all of the data accumulated by this node since the previous call to **GetFrame**. If **GetFrame** has not yet been called, the audio frame will contain all of the data accumulated since the node was created.

## -returns
An [AudioFrame](../windows.media/audioframe.md) object representing the frame.

## -remarks
If you want to retrieve audio frames on a regular cadence, synchronized with the audio graph, you can call this method from within the synchronous [QuantumStarted](audiograph_quantumstarted.md) event handler. The [QuantumProcessed](audiograph_quantumprocessed.md) event is raised asynchronously after the audio engine has completed audio processing, which means its cadence may be irregular. Therefore you should not use the **QuantumProcessed** event for synchronized processing of audio frame data.

## -examples

## -see-also
