---
-api-id: T:Windows.UI.Composition.InsetClip
-api-type: winrt class
---

<!-- Class syntax.
public class InsetClip : Windows.UI.Composition.CompositionClip, Windows.UI.Composition.IInsetClip
-->

# Windows.UI.Composition.InsetClip

## -description
Clips a portion of a visual. The visible portion of the visual is a rectangle defined as inset values from the edges of the visual. The portion of the visual outside the rectangle is clipped.

InsetClips are defined using offsets from the bottom, left, right and top of the Visual to be clipped in pixels. It is possible to fully clip the entire Visual. Negative values are allowed. InsetClips support all the same transforms as Visuals except the 4x4 matrix. Unlike Visuals, InsetClips are 2D and are defined, instead, with a 3x2 matrix. InsetClip properties are fully animatable.

## -remarks

## -examples

## -see-also
[CompositionClip](compositionclip.md), [IClosable](../windows.foundation/iclosable.md)