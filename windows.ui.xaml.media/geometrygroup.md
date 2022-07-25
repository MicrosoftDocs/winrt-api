---
-api-id: T:Windows.UI.Xaml.Media.GeometryGroup
-api-type: winrt class
---

<!-- Class syntax.
public class GeometryGroup : Windows.UI.Xaml.Media.Geometry, Windows.UI.Xaml.Media.IGeometryGroup
-->

# Windows.UI.Xaml.Media.GeometryGroup

## -description
Represents a composite geometry, composed of other [Geometry](geometry.md) objects.



## -xaml-syntax
```xaml
<GeometryGroup>
  oneOrMoreGeometries
</GeometryGroup>
```


## -remarks

## -examples
Composite geometry objects can be created using a GeometryGroup. The GeometryGroup object creates an amalgamation of the [Geometry](geometry.md) objects it contains without combining their area. Any number of [Geometry](geometry.md) objects can be added to a GeometryGroup. This example uses a GeometryGroup to create a composite geometry.



[!code-xaml[GeometryOvw8](../windows.ui.xaml/code/geometries_snip/csharp/GeometryOvw8.xaml#SnippetGeometryOvw8)]

## -see-also
[Geometry](geometry.md)
