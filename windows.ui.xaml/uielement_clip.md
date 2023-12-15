---
-api-id: P:Windows.UI.Xaml.UIElement.Clip
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.RectangleGeometry Clip { get;  set; }
-->

# Windows.UI.Xaml.UIElement.Clip

## -description
Gets or sets the [RectangleGeometry](../windows.ui.xaml.media/rectanglegeometry.md) used to define the outline of the contents of a [UIElement](uielement.md).



## -xaml-syntax
```xaml
<uiElement>
  <uiElement.Clip>
    rectangleGeometry
  </uiElement.Clip>
</uiElement>
```


## -property-value
The rectangle geometry to be used for clipping area sizing. The default value is **null** (no clipping).

## -remarks
The clipping geometry for UIElement.Clip in the Windows Runtime  API must be a [RectangleGeometry](../windows.ui.xaml.media/rectanglegeometry.md). You can't specify a non-rectangular geometry.

The clipped area is the "outside" of the geometry. In other words, the content that is shown (not clipped) is the area of the rectangle that is drawn with [Fill](../windows.ui.xaml.shapes/shape_fill.md) if the geometry were used as data for a [Path](../windows.ui.xaml.shapes/path.md) rather than for clipping. The clipped area is any area that falls outside the rectangle. The clipped area isn't hit-testable.

## -examples
This example is simple XAML markup that specifies a Clip using an inline [RectangleGeometry](../windows.ui.xaml.media/rectanglegeometry.md) that specifies its dimensions through an attribute syntax.



[!code-xaml[GeometryOvw4](../windows.ui.xaml/code/geometries_snip/csharp/GeometryOvw4.xaml#SnippetGeometryOvw4)]

## -see-also
