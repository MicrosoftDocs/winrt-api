---
-api-id: T:Windows.UI.Composition.RectangleClip
-api-type: winrt class
---

# Windows.UI.Composition.RectangleClip

<!--
public sealed class RectangleClip : Windows.UI.Composition.CompositionClip
-->

## -description

Represents a rectangle with optional rounded corners that clips a portion of a visual. The portion of the visual inside the rectangle is visible; the portion of the visual outside the rectangle is clipped.

## -remarks

`RectangleClip` is functionally similar to [InsetClip](insetclip.md), but allows you to round the corners of the clipping rectangle.

A `RectangleClip` is defined using the bottom, left, right, and top of the clip itself. Unlike `InsetClip`, it's not relative to the Visual it's attached to. You can round the corners of the rectangle by setting the various _Radius_ properties.

To clip a `Visual`, you assign the `RectangleClip` to the [Clip](visual_clip.md) property of the `Visual`.

It is possible to fully clip the entire `Visual`. Negative values are allowed. `RectangleClip` supports all the same transforms as `Visual` except the 4x4 matrix. Unlike `Visual`, `RectangleClip` is 2D and is defined, instead, with a 3x2 matrix. `RectangleClip` properties are fully animatable.

## -see-also

[Visual.Clip](visual_clip.md)

## -examples


