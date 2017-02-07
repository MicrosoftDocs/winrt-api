---
-api-id: T:Windows.UI.Xaml.Media.PolyLineSegment
-api-type: winrt class
---

<!-- Class syntax.
public class PolyLineSegment : Windows.UI.Xaml.Media.PathSegment, Windows.UI.Xaml.Media.IPolyLineSegment
-->

# Windows.UI.Xaml.Media.PolyLineSegment

## -description
Represents a set of line segments defined by a [Point](../windows.foundation/point.md) collection with each [Point](../windows.foundation/point.md) specifying the end point of a line segment.

## -xaml-syntax
```xaml
<PolyLineSegment .../>
```


## -remarks

## -examples
This example creates a [PathGeometry](pathgeometry.md) with two [PathFigure](pathfigure.md) objects, each of which contains multiple [PathSegment](pathsegment.md) objects.



[!code-xml[GeometryOvw7](../windows.ui.xaml/code/geometries_snip/csharp/GeometryOvw7.xaml#SnippetGeometryOvw7)]

<img src="Images/PolyLineSegment_curves.gif" alt="Various line shapes created by the example" />

## -see-also
[PathSegment](pathsegment.md), [PathFigure](pathfigure.md), [PathGeometry](pathgeometry.md), [Path](../windows.ui.xaml.shapes/path.md), [XAML vector-based drawing sample](http://go.microsoft.com/fwlink/p/?linkid=226866), [Draw shapes](http://msdn.microsoft.com/library/54cc0bd4-1961-44d7-ab40-6e8b58e42d65)
s.drawing_shapes)