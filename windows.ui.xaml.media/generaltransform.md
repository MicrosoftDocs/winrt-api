---
-api-id: T:Windows.UI.Xaml.Media.GeneralTransform
-api-type: winrt class
---

<!-- Class syntax.
public class GeneralTransform : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.IGeneralTransform, Windows.UI.Xaml.Media.IGeneralTransformOverrides
-->

# Windows.UI.Xaml.Media.GeneralTransform

## -description
Provides generalized transformation support for objects. GeneralTransform is a base class that's in the hierarchy of practical transform classes such as [TranslateTransform](translatetransform.md).



## -remarks
Transformation types include rotation ([RotateTransform](rotatetransform.md)), scale ([ScaleTransform](scaletransform.md)), skew/shear ([SkewTransform](skewtransform.md)), and translation ([TranslateTransform](translatetransform.md)).

[MatrixTransform](matrixtransform.md) is for transforms that don't use these conventions and instead use [Matrix](matrix.md) values for transform definition.

[CompositeTransform](compositetransform.md) and [TransformGroup](transformgroup.md) both support specifying multiple transforms for a combined transformation logic.

There's also an intermediate base class, [Transform](transform.md). Properties sometimes are typed as GeneralTransform or [Transform](transform.md) so that you can use any of the practical transforms to provide values.

You can animate properties of a transform. For XAML syntaxes that take a [Transform](transform.md), you need to specify a nonabstract derived type of [Transform](transform.md) as an object element. Typically, this is one of: [MatrixTransform](matrixtransform.md), [RotateTransform](rotatetransform.md), [ScaleTransform](scaletransform.md), [SkewTransform](skewtransform.md), or [TranslateTransform](translatetransform.md). See the syntax sections on the appropriate class.

Use the [MatrixTransform](matrixtransform.md) class to create custom transformations that are not provided by the other [Transform](transform.md) derived classes. A two-dimensional x-y plane uses a 3x3 matrix for transformations. 
<!--You can multiply affine transformation matrices to form linear transformations, such as rotation and skew (shear) that are followed by translation. 

An affine transformation matrix has its final column equal to (0, 0, 1); therefore, you only have to specify the members in the first two columns.

You cannot extract the matrix-specific information from the nonmatrix transformations. However you can adjust the nonmatrix transformations with their specific properties, or replace a transformation with a matrix transformation at run time.-->

### **GeneralTransform** derived classes

GeneralTransform is the parent class for [Transform](transform.md). [Transform](transform.md) is the parent class for the practical transforms.

## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [Transform](transform.md), [XAML two-dimensional transforms sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20two-dimensional%20transforms%20sample)
