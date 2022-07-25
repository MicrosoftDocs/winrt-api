---
-api-id: P:Windows.UI.Composition.CompositionClip.AnchorPoint
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Numerics.Vector2 AnchorPoint { get;  set; }
-->

# Windows.UI.Composition.CompositionClip.AnchorPoint

## -description
The point on the clip to be positioned at the clip's offset. Value is normalized with respect to the size of the clip.



## -property-value
The point on the clip to be positioned at the clip's offset. Value is normalized with respect to the size of the clip. An AnchorPoint value of (0, 0) refers to the top-left corner of the untransformed clip and a value of (1, 1) refers to the bottom-right corner. Negative values and values greater than one are accepted but will result in an AnchorPoint that is outside the boundaries of the original, untransformed clip.

By default, the AnchorPoint value on a clip is (0, 0).

## -remarks

## -examples

## -see-also
[AnchorPoint](visual_anchorpoint.md)
