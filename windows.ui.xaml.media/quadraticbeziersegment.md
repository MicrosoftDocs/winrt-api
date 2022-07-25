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

Rather than creating an instance or an object element, you can also define a QuadraticBezierSegment as part of a vector within the string for a [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax).

## -examples
This example creates a [PathGeometry](pathgeometry.md) with two [PathFigure](pathfigure.md) objects, each of which contains multiple [PathSegment](pathsegment.md) objects.



[!code-xaml[GeometryOvw7](../windows.ui.xaml/code/geometries_snip/csharp/GeometryOvw7.xaml#SnippetGeometryOvw7)]

## -see-also
[PathSegment](pathsegment.md), [Path](../windows.ui.xaml.shapes/path.md), [PathGeometry](pathgeometry.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes), [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax)
