---
-api-id: T:Windows.UI.Xaml.Media.BezierSegment
-api-type: winrt class
---

<!-- Class syntax.
public class BezierSegment : Windows.UI.Xaml.Media.PathSegment, Windows.UI.Xaml.Media.IBezierSegment
-->

# Windows.UI.Xaml.Media.BezierSegment

## -description
Represents a cubic Bezier curve drawn between two points.

## -xaml-syntax
```xaml
<BezierSegment .../>
```


## -remarks
This class is relevant for setting the vector data for either a [Path](../windows.ui.xaml.shapes/path.md) or a [PathIcon](../windows.ui.xaml.controls/pathicon.md).

Rather than creating an instance or an object element, you can also define a [BezierSegment](beziersegment.md) as part of a vector within the string for a [Move and draw commands syntax](https://msdn.microsoft.com/library/7772bc3e-a631-46ff-9940-3dd5b9d0e0d9).

## -examples
This example uses a [BezierSegment](beziersegment.md) as one of the [PathSegment](pathsegment.md) items in a [PathGeometry](pathgeometry.md).



[!code-xml[GeometryOvw6](../windows.ui.xaml/code/geometries_snip/csharp/GeometryOvw6.xaml#SnippetGeometryOvw6)]

## -see-also
[PathSegment](pathsegment.md), [PolyBezierSegment](polybeziersegment.md), [Path](../windows.ui.xaml.shapes/path.md), [PathGeometry](pathgeometry.md), [XAML vector-based drawing sample](https://go.microsoft.com/fwlink/p/?linkid=226866), [Draw shapes](https://msdn.microsoft.com/library/54cc0bd4-1961-44d7-ab40-6e8b58e42d65), [Move and draw commands syntax](https://msdn.microsoft.com/library/7772bc3e-a631-46ff-9940-3dd5b9d0e0d9)
