---
-api-id: T:Windows.UI.Xaml.Media.Projection
-api-type: winrt class
---

<!-- Class syntax.
public class Projection : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.IProjection
-->

# Windows.UI.Xaml.Media.Projection

## -description
Provides a base class for projections, which describe how to transform an object in 3-D space using perspective transforms.

Equivalent WinUI class: [Microsoft.UI.Xaml.Media.Projection](/windows/winui/api/microsoft.ui.xaml.media.projection).

## -remarks
A Projection is the property type used by the [UIElement.Projection](../windows.ui.xaml/uielement_projection.md) property. Use either a [Matrix3DProjection](matrix3dprojection.md) or [PlaneProjection](planeprojection.md) to supply this property value.

### **Projection** derived classes

Projection is the parent class for several derived classes that define different categories of projection effects:

+ [Matrix3DProjection](matrix3dprojection.md)
+ [PlaneProjection](planeprojection.md)


## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [Matrix3DProjection](matrix3dprojection.md), [PlaneProjection](planeprojection.md)
