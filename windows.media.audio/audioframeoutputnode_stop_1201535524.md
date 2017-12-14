---
-api-id: M:Windows.Media.Audio.AudioFrameOutputNode.Stop
-api-type: winrt method
---

<!-- Method syntax
public void Stop()
-->

# Windows.Media.Audio.AudioFrameOutputNode.Stop

## -description
Stops the audio frame output node.

## -remarks
To mute the input of the node, while allowing audio processing to continue, set the [ConsumeInput](audioframeoutputnode_consumeinput.md) property to false. This is useful when effects with decay, such as reverb or delay, are applied to the node because effect processing will continue after the input is muted. Calling **Stop** immediately stops all processing for the node, including effects.

To stop all processing for all nodes of the graph, call [AudioGraph.Stop](audiograph_stop_1201535524.md).

## -examples

## -see-also
