---
-api-id: T:Windows.UI.Xaml.Media.QuadraticBezierSegment
-api-type: winrt class
---

<!-- Class syntax.
public class QuadraticBezierSegment : Windows.UI.Xaml.Media.PathSegment, Windows.UI.Xaml.Media.IQuadraticBezierSegment
-->

# Windows.UI.Xaml.Media.QuadraticBezierSegment

## -description
Creates a quadratic Bezier curve between two points in a [PathFigure](pathfigure.md).

## -xaml-syntax
```xaml
<QuadraticBezierSegment .../>
```


## -remarks
This class is relevant for setting the vector data for either a [Path](../windows.ui.xaml.shapes/path.md) or a [PathIcon](../windows.ui.xaml.controls/pathicon.md).

Rather than creating an instance or an object element, you can also define a [QuadraticBezierSegment](quadraticbeziersegment.md) as part of a vector within the string for a [Move and draw commands syntax](http://msdn.microsoft.com/library/7772bc3e-a631-46ff-9940-3dd5b9d0e0d9).

## -examples
This example creates a [PathGeometry](pathgeometry.md) with two [PathFigure](pathfigure.md) objects, each of which contains multiple [PathSegment](pathsegment.md) objects.



[!code-xml[GeometryOvw7](../windows.ui.xaml/code/geometries_snip/csharp/GeometryOvw7.xaml#SnippetGeometryOvw7)]

## -see-also
[PathSegment](pathsegment.md), [Path](../windows.ui.xaml.shapes/path.md), [PathGeometry](pathgeometry.md), [XAML vector-based drawing sample](http://go.microsoft.com/fwlink/p/?linkid=226866), [Draw shapes](http://msdn.microsoft.com/library/54cc0bd4-1961-44d7-ab40-6e8b58e42d65), [Move and draw commands syntax](http://msdn.microsoft.com/library/7772bc3e-a631-46ff-9940-3dd5b9d0e0d9)
