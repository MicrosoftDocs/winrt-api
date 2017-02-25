---
-api-id: P:Windows.UI.Xaml.UIElement.Projection
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Projection Projection { get;  set; }
-->

# Windows.UI.Xaml.UIElement.Projection

## -description
Gets or sets the perspective projection (3-D effect) to apply when rendering this element.

## -xaml-syntax
```xaml
<uiElement>
  <uiElement.Projection>
    singleProjection
  </uiElement.Projection>
</uiElement>
```


## -xaml-values
<dl><dt>singleProjection</dt><dd>singleProjectionA single object element that defines a specific projection. Typically this is a Matrix3DProjection or PlaneProjection.</dd>
</dl>
## -property-value
A 3-D projection effect applied to the element.
## -remarks
[Projection](uielement_projection.md) and [RenderTransform](uielement_rendertransform.md) with a [SkewTransform](../windows.ui.xaml.media/skewtransform.md) can achieve similar results, a [Projection](uielement_projection.md) is probably more versatile, especially if you want a sense of perspective change applied to the element.

[Projection](uielement_projection.md) is the base class type that this property uses, but [Projection](uielement_projection.md) does not implement a practical behavior. Use either [Matrix3DProjection](../windows.ui.xaml.media/matrix3dprojection.md) or [PlaneProjection](../windows.ui.xaml.media/planeprojection.md).

The value of [Projection](uielement_projection.md) is overridden by [PointerDownThemeAnimation](../windows.ui.xaml.media.animation/pointerdownthemeanimation.md) and [PointerUpThemeAnimation](../windows.ui.xaml.media.animation/pointerupthemeanimation.md).

<!--TODO go or no go on animating a projection?-->

## -examples
This example shows how to apply a basic [PlaneProjection](../windows.ui.xaml.media/planeprojection.md) in the initial page XAML.



[!code-xml[BasicPerspectiveTransforms](../windows.ui.xaml/code/BasicPerspectiveTransforms/csharp/MainPage.xaml#SnippetBasicPerspectiveTransforms)]

## -see-also
[Matrix3DProjection](../windows.ui.xaml.media/matrix3dprojection.md), [Matrix3D](../windows.ui.xaml.media.media3d/matrix3d.md), [3-D effects for  using XAML](http://msdn.microsoft.com/library/abcbbdb6-02a5-4e4e-a8dc-ceacedb91913), [XAML two-dimensional transforms sample](http://go.microsoft.com/fwlink/p/?linkid=238580)
