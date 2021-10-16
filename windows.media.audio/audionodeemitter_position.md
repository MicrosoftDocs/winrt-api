---
-api-id: P:Windows.Media.Audio.AudioNodeEmitter.Position
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector3 Position { get;  set; }
-->

# Windows.Media.Audio.AudioNodeEmitter.Position

## -description
Gets or sets a vector representing the position of the emitter in 3D space, expressed in meters.

## -property-value
A vector representing the position of the emitter in 3D space

## -remarks

The positions of all of the emitters in the graph are relative to the position and orientation of the [AudioNodeListener](audionodelistener.md) object assigned to the [AudioDeviceOutputNode](audiodeviceoutputnode.md) for the audio graph. By default, the listener is located at the origin (0,0,0) facing forward along the Z axis, but you can set its position and orientation with the [Position](audionodelistener_position.md) and [Orientation](audionodelistener_orientation.md) properties.



## -examples

## -see-also
