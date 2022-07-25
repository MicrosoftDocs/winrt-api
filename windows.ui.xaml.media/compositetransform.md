---
-api-id: T:Windows.UI.Xaml.Media.CompositeTransform
-api-type: winrt class
---

<!-- Class syntax.
public class CompositeTransform : Windows.UI.Xaml.Media.Transform, Windows.UI.Xaml.Media.ICompositeTransform
-->

# Windows.UI.Xaml.Media.CompositeTransform

## -description
Applies multiple transform operations to an object.



## -xaml-syntax
```xaml
<CompositeTransform .../>
```


## -remarks
CompositeTransform applies multiple transforms in this order:


1. Scale ([ScaleX](compositetransform_scalex.md), [ScaleY](compositetransform_scaley.md) )
1. Skew ([SkewX](compositetransform_skewx.md), [SkewY](compositetransform_skewy.md))
1. Rotate ([Rotation](compositetransform_rotation.md))
1. Translate ([TranslateX](compositetransform_translatex.md), [TranslateY](compositetransform_translatey.md))

If you want to apply multiple transforms to an object in a different order, you can create a [TransformGroup](transformgroup.md) and insert the transforms in your intended order.

CompositeTransform uses the same center point ([CenterX](compositetransform_centerx.md), [CenterY](compositetransform_centery.md)) for all transformations. If you want to specify different center points per transform, use [TransformGroup](transformgroup.md).

## -examples
This example shows how to apply the same transforms to an object by using either a CompositeTransform or a [TransformGroup](transformgroup.md).



[!code-xaml[CompositeTransform](../windows.ui.xaml/code/transforms/csharp/CompositeTransform.xaml#SnippetCompositeTransform)]

## -see-also
[Transform](transform.md), [XAML two-dimensional transforms sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20two-dimensional%20transforms%20sample), [TransformGroup](transformgroup.md)
