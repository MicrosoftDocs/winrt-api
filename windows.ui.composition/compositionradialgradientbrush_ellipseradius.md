---
-api-id: P:Windows.UI.Composition.CompositionRadialGradientBrush.EllipseRadius
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public Vector2 EllipseRadius { get;  set; }
-->

# Windows.UI.Composition.CompositionRadialGradientBrush.EllipseRadius

## -description

Gets or sets the radii of the ellipse that contains the gradient.



## -property-value

The radii of the ellipse that contains the gradient. The default is a Vector2 with values (0.5, 0.5).

## -remarks

This property describes the radii of the ellipse that the radial gradient is drawn in. The first value of the Vector2 describes the x-axis radius and the second value describes the y-axis radius.

When [MappingMode](compositiongradientbrush_mappingmode.md) is set to [Relative](compositionmappingmode.md), each radius is a value from 0.0 to 1.0, which represents a percentage of the size of the object being painted.

When `MappingMode` is set to `Absolute`, the numbers change to be pixels rather than a ratio, and are relative to the size of the brush.



## -see-also

## -examples
