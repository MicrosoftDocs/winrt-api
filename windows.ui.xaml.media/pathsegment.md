---
-api-id: T:Windows.UI.Xaml.Media.PathSegment
-api-type: winrt class
---

<!-- Class syntax.
public class PathSegment : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.IPathSegment
-->

# Windows.UI.Xaml.Media.PathSegment

## -description
Represents a segment of a [PathFigure](pathfigure.md) object. Derived classes of [PathFigure](pathfigure.md) describe different types of segments.



## -remarks
[PathSegmentCollection](pathsegmentcollection.md) is a strongly typed collection for PathSegment items. [PathSegmentCollection](pathsegmentcollection.md) is the type used by the [PathFigure.Segments](pathfigure_segments.md) property. In XAML, specify one or more of the element types that derive from PathSegment for this property.

### **PathSegment** derived classes

[PathSegment](pathfigure.md) is the parent class for several derived classes that define different categories of geometry segments in a [PathFigure](pathfigure.md):

+ [ArcSegment](arcsegment.md)
+ [BezierSegment](beziersegment.md)
+ [LineSegment](linesegment.md)
+ [PolyBezierSegment](polybeziersegment.md)
+ [PolyQuadraticBezierSegment](polyquadraticbeziersegment.md)
+ [QuadraticBezierSegment](quadraticbeziersegment.md)


## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [ArcSegment](arcsegment.md), [BezierSegment](beziersegment.md), [LineSegment](linesegment.md), [PolyBezierSegment](polybeziersegment.md), [PolyQuadraticBezierSegment](polyquadraticbeziersegment.md), [QuadraticBezierSegment](quadraticbeziersegment.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes)
