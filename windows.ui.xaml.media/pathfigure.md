---
-api-id: T:Windows.UI.Xaml.Media.PathFigure
-api-type: winrt class
---

<!-- Class syntax.
public class PathFigure : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.IPathFigure
-->

# Windows.UI.Xaml.Media.PathFigure

## -description
Represents a subsection of a geometry, a single connected series of two-dimensional geometric segments.

## -xaml-syntax
```xaml
<PathFigure .../>
-or-
<PathFigure ...>
  oneOrMorePathSegments
</PathFigure
```


## -remarks
[PathFigureCollection](pathfigurecollection.md) is a strongly typed collection for [PathFigure](pathfigure.md) items. [PathFigureCollection](pathfigurecollection.md) is the type used by the [PathGeometry.Figures](pathgeometry_figures.md) property. In XAML, specify one or more [PathFigure](pathfigure.md) elements for this property.

This class is relevant for setting the vector data for either a [Path](../windows.ui.xaml.shapes/path.md) or a [PathIcon](../windows.ui.xaml.controls/pathicon.md).

Rather than creating an instance or an object element, you can also define segments and a single [PathFigure](pathfigure.md) as part of a vector within the string for a [Move and draw commands syntax](http://msdn.microsoft.com/library/7772bc3e-a631-46ff-9940-3dd5b9d0e0d9).

## -examples
This example creates a simple [PathGeometry](pathgeometry.md) made up of a single **PathFigure** with a [LineSegment](linesegment.md) and displays it using a [Path](../windows.ui.xaml.shapes/path.md) element. The **PathFigure** object's [StartPoint](pathfigure_startpoint.md) is set to (10,20) and a **LineSegment** is defined with an end point of (100,130).



[!code-xml[GeometryOvw5](../windows.ui.xaml/code/geometries_snip/csharp/GeometryOvw5.xaml#SnippetGeometryOvw5)]



[!code-xml[GeometryOvw6](../windows.ui.xaml/code/geometries_snip/csharp/GeometryOvw6.xaml#SnippetGeometryOvw6)]

 

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [PathGeometry](pathgeometry.md), [PathSegment](pathsegment.md), [PathFigureCollection](pathfigurecollection.md), [XAML vector-based drawing sample](http://go.microsoft.com/fwlink/p/?linkid=226866), [Draw shapes](http://msdn.microsoft.com/library/54cc0bd4-1961-44d7-ab40-6e8b58e42d65), [Move and draw commands syntax](http://msdn.microsoft.com/library/7772bc3e-a631-46ff-9940-3dd5b9d0e0d9)
tax](http://msdn.microsoft.com/library/7772bc3e-a631-46ff-9940-3dd5b9d0e0d9)