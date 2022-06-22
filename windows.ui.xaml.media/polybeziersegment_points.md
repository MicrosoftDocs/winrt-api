---
-api-id: P:Windows.UI.Xaml.Media.PolyBezierSegment.Points
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.PointCollection Points { get;  set; }
-->

# Windows.UI.Xaml.Media.PolyBezierSegment.Points

## -description
Gets or sets the [Point](../windows.foundation/point.md) collection that defines this [PolyBezierSegment](polybeziersegment.md) object.



## -xaml-syntax
```xaml
<PolyBezierSegment Points="pointSet"/>
```


## -xaml-values
<dl><dt>pointSet</dt><dd>pointSetOne or more Point values with each x-y pair delimited by a single comma and/or one or more spaces. Either space or comma can be the delimiter and they can be used interchangeably. For example, 0,0 100,100, 0,0,100,100, and 0 0 100 100 are all valid and equivalent. The convention is generally to use comma between the X and Y of a Point, and spaces between the x,y pairs.</dd>
</dl>
## -property-value
The collection of points that defines this [PolyBezierSegment](polybeziersegment.md) object.

## -remarks

## -examples
This example shows how to use a [PolyBezierSegment](polybeziersegment.md) to create a series of curves.



[!code-xaml[PolyBezierSegment](../windows.ui.xaml/code/geometries_snip/csharp/PolyBezierSegment.xaml#SnippetPolyBezierSegment)]

## -see-also
