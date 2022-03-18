---
-api-id: P:Windows.UI.Core.AnimationMetrics.AnimationDescription.ZOrder
-api-type: winrt property
---

<!-- Property syntax
public int ZOrder { get; }
-->

# Windows.UI.Core.AnimationMetrics.AnimationDescription.ZOrder

## -description
 Gets the z-order position of an [AnimationDescription](animationdescription.md) object relative to other [AnimationDescription](animationdescription.md) objects in the same animation effect.     [AnimationDescription](animationdescription.md) objects with a higher z-order cover transitions with a lower z-order.

## -property-value
The z-order value.

## -remarks
The z-order value is used only for arranging [AnimationDescription](animationdescription.md) objects within the same overall animation. It has no effect on [AnimationDescription](animationdescription.md) objects from different transitions.

## -examples

## -see-also
[Animation metrics sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/AnimationMetrics)
