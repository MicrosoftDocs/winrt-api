---
-api-id: T:Windows.UI.Composition.InsetClip
-api-type: winrt class
---

<!-- Class syntax.
public class InsetClip : Windows.UI.Composition.CompositionClip, Windows.UI.Composition.IInsetClip
-->

# Windows.UI.Composition.InsetClip

## -description

Represents a rectangle that clips a portion of a visual. The portion of the visual inside the rectangle is visible; the portion of the visual outside the rectangle is clipped.



## -remarks

`InsetClip` is functionally similar to [RectangleClip](rectangleclip.md), but `RectangleClip` allows you to round the corners of the clipping rectangle.

An `InsetClip` is defined using offsets in pixels from the bottom, left, right, and top of the [Visual](visual.md) to be clipped.

To clip a `Visual`, you assign the `InsetClip` to the [Clip](visual_clip.md) property of the `Visual`.

It is possible to fully clip the entire `Visual`. Negative values are allowed. `InsetClip` supports all the same transforms as `Visual` except the 4x4 matrix. Unlike `Visual`, `InsetClip` is 2D and is defined, instead, with a 3x2 matrix. `InsetClip` properties are fully animatable.

## -examples

## -see-also

[Visual.Clip](visual_clip.md), [CompositionClip](compositionclip.md), [IClosable](../windows.foundation/iclosable.md)
