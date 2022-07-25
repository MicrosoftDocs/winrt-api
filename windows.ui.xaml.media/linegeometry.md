---
-api-id: T:Windows.UI.Xaml.Media.LineGeometry
-api-type: winrt class
---

<!-- Class syntax.
public class LineGeometry : Windows.UI.Xaml.Media.Geometry, Windows.UI.Xaml.Media.ILineGeometry
-->

# Windows.UI.Xaml.Media.LineGeometry

## -description
Represents the geometry of a line.



## -xaml-syntax
```xaml
<LineGeometry .../>
```


## -remarks

## -examples
This example shows how to create and render a LineGeometry object. A [Geometry](geometry.md) object only defines the geometry of the object—it does not render anything directly—so the example uses a [Path](../windows.ui.xaml.shapes/path.md) shape to render the line. Because a line has no area, setting the [Fill](../windows.ui.xaml.shapes/shape_fill.md) property of the [Path](../windows.ui.xaml.shapes/path.md) would have no effect; instead, only the [Stroke](../windows.ui.xaml.shapes/shape_stroke.md) and [StrokeThickness](../windows.ui.xaml.shapes/shape_strokethickness.md) properties are specified.



[!code-xaml[GeometryOvw1](../windows.ui.xaml/code/geometries_snip/csharp/GeometryOvw1.xaml#SnippetGeometryOvw1)]

## -see-also
[Geometry](geometry.md), [LineSegment](linesegment.md), [PolyLineSegment](polylinesegment.md)
