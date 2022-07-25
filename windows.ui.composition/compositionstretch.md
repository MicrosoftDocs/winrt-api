---
-api-id: T:Windows.UI.Composition.CompositionStretch
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Composition.CompositionStretch : int
-->

# CompositionStretch

## -description
Specifies how content is scaled when mapped from its source to a destination space.



## -enum-fields
### -field None:0
No Scaling. If the size of the content is greater than size of destination, the content is clipped to the bounds of the destination space.

### -field Fill:1
Scale content such that its size is equal to the size of the destination. The aspect ratio of the content is not preserved.

### -field Uniform:2
Scale content such that its aspect ratio is preserved and it fits entirely within the bounds of the destination space. If the content’s aspect ratio does not match that of the destination, the content will not cover some of the area bound by the destination space. This is the default value for CompositionSurfaceBrush.[Stretch](compositionsurfacebrush_stretch.md).

### -field UniformToFill:3
Scale content such that its aspect ratio is preserved and it fills the entirety of the destination’s bounds. If the content’s aspect ratio does not match that of the destination, the content will be clipped to the bounds of the destination.


## -remarks
For stretching the contents of a [CompositionSurfaceBrush](compositionsurfacebrush.md) onto a [SpriteVisual](spritevisual.md), refer to the CompositionSurfaceBrush.[Stretch](compositionsurfacebrush_stretch.md) property.

## -examples

## -see-also
