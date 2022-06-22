---
-api-id: T:Windows.UI.Xaml.Media.Matrix3DProjection
-api-type: winrt class
---

<!-- Class syntax.
public class Matrix3DProjection : Windows.UI.Xaml.Media.Projection, Windows.UI.Xaml.Media.IMatrix3DProjection
-->

# Windows.UI.Xaml.Media.Matrix3DProjection

## -description
Applies a [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md) projection to an object.



## -xaml-syntax
```xaml
<Matrix3DProjection .../>
-or-
<!--xmlns:m3d="using:Windows.UI.Xaml.Media.Media3D"-->
<Matrix3DProjection>
  <m3d:Matrix3D>matrix3DInitializationString</m3d:Matrix3D>
</Matrix3DProjection>
```


## -remarks
You can use the Matrix3DProjection and [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md) types for more complex semi–3-D scenarios than are possible with the [PlaneProjection](planeprojection.md) type. Matrix3DProjection provides a complete 3-D transform matrix to apply to any [UIElement](../windows.ui.xaml/uielement.md) (you use this as a value for the [UIElement.Projection](../windows.ui.xaml/uielement_projection.md) property). The matrix lets you apply arbitrary model transform matrices and perspective matrices to visual elements.

## -examples
This example uses a simple [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md) matrix to transform the image in the **X** and **Y** directions when you click the image.



[!code-xaml[Matrix3DProjectionSimple](../windows.ui.xaml.media/code/Matrix3DProjectionSimple/csharp/MainPage.xaml#SnippetMatrix3DProjectionSimple)]

[!code-csharp[Matrix3DProjectionSimple_code](../windows.ui.xaml.media/code/Matrix3DProjectionSimple/csharp/MainPage.xaml.cs#SnippetMatrix3DProjectionSimple_code)]



[!code-xaml[Matrix3DProjectionXAML](../windows.ui.xaml.media/code/Matrix3DProjectionXAML/csharp/MainPage.xaml#SnippetMatrix3DProjectionXAML)]



[!code-xaml[Matrix3DProjectionSample](../windows.ui.xaml.media/code/Matrix3DProjectionSample/csharp/MainPage.xaml#SnippetMatrix3DProjectionSample)]

[!code-csharp[Matrix3DProjectionSample_code](../windows.ui.xaml.media/code/Matrix3DProjectionSample/csharp/MainPage.xaml.cs#SnippetMatrix3DProjectionSample_code)]

## -see-also
[Projection](projection.md), [UIElement.Projection](../windows.ui.xaml/uielement_projection.md), [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md), [3-D perspective effects for XAML UI](/windows/uwp/graphics/3-d-perspective-effects)
jection.md), [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md), [3-D perspective effects for XAML UI](/windows/uwp/graphics/3-d-perspective-effects)
