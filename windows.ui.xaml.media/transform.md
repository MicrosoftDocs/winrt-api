---
-api-id: T:Windows.UI.Xaml.Media.Transform
-api-type: winrt class
---

<!-- Class syntax.
public class Transform : Windows.UI.Xaml.Media.GeneralTransform, Windows.UI.Xaml.Media.ITransform
-->

# Windows.UI.Xaml.Media.Transform

## -description
Defines functionality that enables transformations in a two-dimensional plane.



## -remarks
Transformation types include rotation ([RotateTransform](rotatetransform.md)), scale ([ScaleTransform](scaletransform.md)), skew/shear ([SkewTransform](skewtransform.md)), and translation ([TranslateTransform](translatetransform.md)).

[MatrixTransform](matrixtransform.md) is for transforms that don't use these conventions and instead use [Matrix](matrix.md) values for transform definition.

[CompositeTransform](compositetransform.md) and [TransformGroup](transformgroup.md) both support specifying multiple transforms for a combined transformation logic.

You can animate properties of a transform. For XAML syntaxes that take a Transform, you need to specify a nonabstract derived type of Transform as an object element. Typically, this is one of: [MatrixTransform](matrixtransform.md), [RotateTransform](rotatetransform.md), [ScaleTransform](scaletransform.md), [SkewTransform](skewtransform.md), or [TranslateTransform](translatetransform.md). See the syntax sections on the appropriate class.

Use the [MatrixTransform](matrixtransform.md) class to create custom transformations that are not provided by the other Transform derived classes. A two-dimensional x-y plane uses a 3x3 matrix for transformations. 
<!--You can multiply affine transformation matrices to form linear transformations, such as rotation and skew (shear) that are followed by translation. 

An affine transformation matrix has its final column equal to (0, 0, 1); therefore, you only have to specify the members in the first two columns.

You cannot extract the matrix-specific information from the nonmatrix transformations. However you can adjust the nonmatrix transformations with their specific properties, or replace a transformation with a matrix transformation at run time.-->


Transform is the property type for [UIElement.RenderTransform](../windows.ui.xaml/uielement_rendertransform.md). With this property, you can apply any of the practical transforms to a [UIElement](../windows.ui.xaml/uielement.md) when it renders. Other less commonly used properties that take a Transform are: [Brush.RelativeTransform](brush_relativetransform.md), [Brush.Transform](brush_transform.md), [Geometry.Transform](geometry_transform.md).

### **Transform** derived classes

Transform is the parent class for several derived classes that define different categories of transformations:

+ [CompositeTransform](compositetransform.md)
+ [MatrixTransform](matrixtransform.md)
+ [RotateTransform](rotatetransform.md)
+ [ScaleTransform](scaletransform.md)
+ [SkewTransform](skewtransform.md)
+ [TransformGroup](transformgroup.md)
+ [TranslateTransform](translatetransform.md)


## -examples

## -see-also
[GeneralTransform](generaltransform.md), [MatrixTransform](matrixtransform.md), [RotateTransform](rotatetransform.md), [SkewTransform](skewtransform.md), [TransformGroup](transformgroup.md), [TranslateTransform](translatetransform.md), [XAML two-dimensional transforms sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20two-dimensional%20transforms%20sample)
