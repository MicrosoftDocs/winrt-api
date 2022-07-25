---
-api-id: P:Windows.UI.Xaml.Media.PolyQuadraticBezierSegment.Points
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.PointCollection Points { get;  set; }
-->

# Windows.UI.Xaml.Media.PolyQuadraticBezierSegment.Points

## -description
Gets or sets the [Point](../windows.foundation/point.md) collection that defines this [PolyQuadraticBezierSegment](polyquadraticbeziersegment.md) object.



## -xaml-syntax
```xaml
<PolyQuadraticBezierSegment Points="pointSet"/>
```


## -xaml-values
<dl><dt>pointSet</dt><dd>pointSetOne or more Point values with each x-y pair delimited by a single comma and/or one or more spaces. Either space or comma can be the delimiter and they can be used interchangeably. For example, 0,0 100,100, 0,0,100,100, and 0 0 100 100 are all valid and equivalent. The convention is generally to use comma between the X and Y of a Point, and spaces between the x,y pairs.</dd>
</dl>
## -property-value
A collection of points that defines the shape of this [PolyQuadraticBezierSegment](polyquadraticbeziersegment.md) object. The default value is an empty collection.

## -remarks

## -examples
This example creates two curves using a [PolyQuadraticBezierSegment](polyquadraticbeziersegment.md) to specify the coordinates.



[!code-xaml[PolyQuadraticBezierSegment](../windows.ui.xaml/code/geometries_snip/csharp/PolyQuadraticBezierSegment.xaml#SnippetPolyQuadraticBezierSegment)]

## -see-also
