---
-api-id: T:Windows.Media.Audio.SpatialAudioModel
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Audio.SpatialAudioModel : int
-->

# SpatialAudioModel

## -description
Specifies the spatial audio processing model used by an [AudioNodeEmitter](audionodeemitter.md).

## -enum-fields
### -field ObjectBased:0
Spatial audio is processed using the Microsoft head-relative transfer function (HRTF) algorithm. This provides a more realistic spatial sound that preserves X, Y, and Z coordinates of the emitter, but at a higher CPU and memory cost than fold-down processing.

### -field FoldDown:1
Spatial audio is processed using non-spatial methods, such as panning between stereo channels. This provides less realistic spatial sound that preserves the X and Z coordinates of the emitter, but effectively ignores the Y coordinate. This model has a lower CPU and memory cost than object-based processing.


## -remarks


## -examples

## -see-also