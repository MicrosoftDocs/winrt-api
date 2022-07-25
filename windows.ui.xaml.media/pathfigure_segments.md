---
-api-id: P:Windows.UI.Xaml.Media.PathFigure.Segments
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.PathSegmentCollection Segments { get;  set; }
-->

# Windows.UI.Xaml.Media.PathFigure.Segments

## -description
Gets or sets the collection of segments that define the shape of this [PathFigure](pathfigure.md) object.



## -xaml-syntax
```xaml
<PathFigure>
  oneOrMorePathSegments
</PathFigure>
```


## -xaml-values
<dl><dt>oneOrMorePathSegments</dt><dd>oneOrMorePathSegmentsOne or more object elements that derive from PathSegment. Typically these are ArcSegment, BezierSegment, LineSegment, PolyBezierSegment, PolyQuadraticBezierSegment, or QuadraticBezierSegment. Object elements defined here become members of the collection when code accesses the Segments property at run time.</dd>
</dl>
## -property-value
The collection of segments that define the shape of this [PathFigure](pathfigure.md) object. The default is an empty collection.

## -remarks

## -examples

## -see-also
