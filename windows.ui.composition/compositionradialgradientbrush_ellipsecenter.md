---
-api-id: P:Windows.UI.Composition.CompositionRadialGradientBrush.EllipseCenter
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public Vector2 EllipseCenter { get;  set; }
-->

# Windows.UI.Composition.CompositionRadialGradientBrush.EllipseCenter

## -description

Gets or sets the two-dimensional coordinates of the center of the ellipse that contains the gradient.

Equivalent WinUI property: [Microsoft.UI.Composition.CompositionRadialGradientBrush.EllipseCenter](/windows/winui/api/microsoft.ui.composition.compositionradialgradientbrush.ellipsecenter).

## -property-value

The two-dimensional coordinates of the center of the ellipse the gradient is housed in. The default is a Vector2 with values (0.5, 0.5).

## -remarks

This property describes coordinates of the center of the ellipse that the radial gradient is drawn in. The coordinates are relative to the object being painted and have values from 0.0 to 1.0. The upper left corner of the object's bounding rectangle has coordinates (0.0, 0.0) and the lower right corner has coordinates (1.0, 1.0).

## -see-also

## -examples
