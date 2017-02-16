---
-api-id: P:Windows.Media.Audio.AudioDeviceInputNode.Emitter
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Audio.AudioNodeEmitter Emitter { get; }
-->

# Windows.Media.Audio.AudioDeviceInputNode.Emitter

## -description
Gets the [AudioNodeEmitter](audionodeemitter.md) that describes the position and other physical characteristics of the emitter from which the [AudioDeviceInputNode](audiodeviceinputnode.md) audio is emitted when spatial audio processing is used.

## -property-value
The spatial audio emitter associated with the [AudioDeviceInputNode](audiodeviceinputnode.md).

## -remarks
Create an [AudioDeviceInputNode](audiodeviceinputnode.md) with an [AudioNodeEmitter](audionodeemitter.md) by calling the overload of [CreateDeviceInputNodeAsync](audiograph_createdeviceinputnodeasync_2137015807.md) that accepts an emitter as an argument.

## -examples

## -see-also
