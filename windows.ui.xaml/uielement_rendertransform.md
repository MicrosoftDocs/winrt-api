---
-api-id: P:Windows.UI.Xaml.UIElement.RenderTransform
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Transform RenderTransform { get;  set; }
-->

# Windows.UI.Xaml.UIElement.RenderTransform

## -description
Gets or sets transform information that affects the rendering position of a [UIElement](uielement.md).



## -xaml-syntax
```xaml
<uiElement>
  <uiElement.RenderTransform>
    singleTransform
  </uiElement.RenderTransform>
</uiElement>
```


## -xaml-values
<dl><dt>singleTransform</dt><dd>singleTransformExactly one object element for an object that derives from Transform. This is typically one of the transforms: RotateTransform, ScaleTransform, SkewTransform, TranslateTransform, MatrixTransform, or TransformGroup. By using TransformGroup here, you can apply multiple transforms by defining child object elements of the TransformGroup. See the "XAML Values" section for TransformGroup. Also, custom transforms might derive from MatrixTransform.</dd>
</dl>
## -property-value
Describes the specifics of the desired render transform. The default value is null.

## -remarks
You can animate a transform, if you target sub-properties of the specific transform being used that take **Double** values. Or you can use [ObjectAnimationUsingKeyFrames](../windows.ui.xaml.media.animation/objectanimationusingkeyframes.md) to cycle through distinct transforms. Classes such as [QuarticEase](../windows.ui.xaml.media.animation/quarticease.md) show some example XAML.

If you do animate RenderTransform, make sure there is an existing starting [Transform](../windows.ui.xaml.media/transform.md) value, even if it is all at default values. You can't animate a RenderTransform value that is initially null.

The value of RenderTransform is overridden by [PointerDownThemeAnimation](../windows.ui.xaml.media.animation/pointerdownthemeanimation.md) and [PointerUpThemeAnimation](../windows.ui.xaml.media.animation/pointerupthemeanimation.md).

## -examples
This XAML defines a [Matrix](../windows.ui.xaml.media/matrix.md) that provides data for a [MatrixTransform](../windows.ui.xaml.media/matrixtransform.md) applied to a rectangular shape as its RenderTransform. In this case, the matrix combines an offset ([OffsetX](/uwp/api/windows.ui.xaml.media.media3d.matrix3d.offsetx) and [OffsetY](/uwp/api/windows.ui.xaml.media.media3d.matrix3d.offsety)) and a skew ([M12](/uwp/api/windows.ui.xaml.media.media3d.matrix3d.m12)). Note that this same effect could have been produced by combining a [TranslateTransform](../windows.ui.xaml.media/translatetransform.md) and a [SkewTransform](../windows.ui.xaml.media/skewtransform.md); whether to use a single [Matrix](../windows.ui.xaml.media/matrix.md) or combinations of discrete transforms (with [TransformGroup](../windows.ui.xaml.media/transformgroup.md)) is a matter of coding style; the results are identical.



[!code-xaml[matrixtransform](../windows.ui.xaml/code/matrixtransform/csharp/Page.xaml#Snippetmatrixtransform)]

## -see-also
[TranslateTransform](../windows.ui.xaml.media/translatetransform.md), [XAML two-dimensional transforms sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20two-dimensional%20transforms%20sample)
