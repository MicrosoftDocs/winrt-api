---
-api-id: P:Windows.Media.Audio.AudioFileInputNode.Emitter
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Audio.AudioNodeEmitter Emitter { get; }
-->

# Windows.Media.Audio.AudioFileInputNode.Emitter

## -description
Gets the [AudioNodeEmitter](audionodeemitter.md) that describes the position and other physical characteristics of the emitter from which the [AudioFileInputNode](audiofileinputnode.md) audio is emitted when spatial audio processing is used.

## -property-value
The spatial audio emitter associated with the [AudioFileInputNode](audiofileinputnode.md).

## -remarks
Create an [AudioFileInputNode](audiofileinputnode.md) with an [AudioNodeEmitter](audionodeemitter.md) by calling the overload of [CreateFileInputNodeAsync](audiograph_createfileinputnodeasync_1569331208.md) that accepts an emitter as an argument.

## -examples

## -see-also
