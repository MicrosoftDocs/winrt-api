---
-api-id: P:Windows.UI.Xaml.Media.GeometryGroup.Children
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.GeometryCollection Children { get;  set; }
-->

# Windows.UI.Xaml.Media.GeometryGroup.Children

## -description
Gets or sets the [GeometryCollection](geometrycollection.md) that contains the objects that define this [GeometryGroup](geometrygroup.md).



## -xaml-syntax
```xaml
<GeometryGroup>
  oneOrMoreGeometries
</GeometryGroup>
```


## -xaml-values
<dl><dt>oneOrMoreGeometries</dt><dd>oneOrMoreGeometriesOne or more object elements that derive from Geometry. Typically, these are any combination of the classes EllipseGeometry, GeometryGroup, LineGeometry, PathGeometry, and RectangleGeometry. Object elements defined here become members of the Children collection when code accesses the Children property at run time.</dd>
</dl>
## -property-value
A collection containing the children of this [GeometryGroup](geometrygroup.md).

## -remarks

## -examples

## -see-also
