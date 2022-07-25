---
-api-id: P:Windows.UI.Composition.CompositionRadialGradientBrush.GradientOriginOffset
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public Vector2 GradientOriginOffset { get;  set; }
-->

# Windows.UI.Composition.CompositionRadialGradientBrush.GradientOriginOffset

## -description

Gets or sets the two-dimensional coordinates of the origin of the gradient.



## -property-value

The two-dimensional coordinates of the origin of the gradient. The default is a Vector2 with values (0, 0).

## -remarks

When [MappingMode](compositiongradientbrush_mappingmode.md) is set to [Relative](compositionmappingmode.md), the coordinates are relative to the object being painted and have values from 0.0 to 1.0. The upper left corner of the object's bounding rectangle has coordinates (0.0, 0.0) and the lower right corner has coordinates (1.0, 1.0).

When `MappingMode` is set to `Absolute`, the numbers change to be pixels rather than a ratio, and are relative to the size of the brush.

## -see-also

## -examples

