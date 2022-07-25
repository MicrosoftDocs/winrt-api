---
-api-id: P:Windows.UI.Xaml.Shapes.Path.Data
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Geometry Data { get;  set; }
-->

# Windows.UI.Xaml.Shapes.Path.Data

## -description
Gets or sets a [Geometry](../windows.ui.xaml.media/geometry.md) that specifies the shape to be drawn.



## -xaml-syntax
```xaml
<Path>
  <Path.Data>
    singleGeometry
  </Path.Data>
</Path>
- or -
<Path Data="moveAndDrawCommands"/>
```


## -xaml-values
<dl><dt>singleGeometry</dt><dd>singleGeometryA single object element that derives from Geometry. This can be one of the following: One of the simple geometries EllipseGeometry, LineGeometry, or RectangleGeometry.A single GeometryGroup, which supports other geometries as child elements. A PathGeometry, which supports child object elements that establish a path geometry object model of figures and segments. See the "XAML Values" section of PathGeometry.</dd>
<dt>moveAndDrawCommands</dt><dd>moveAndDrawCommandsThis is a complex syntax that cannot be adequately summarized here. See Move and draw commands syntax.</dd>
</dl>
## -property-value
A description of the shape to be drawn.

## -remarks

## -examples
The following example uses a [Path](path.md) to draw an ellipse.

```xaml
<Canvas> 
  <Path Fill="Gold" Stroke="Black" StrokeThickness="1">
    <Path.Data>
      <EllipseGeometry Center="50,50" RadiusX="50" RadiusY="50" />
    </Path.Data>
  </Path> 
</Canvas>
```


<!--<desc>
      <p xml:space="preserve">The following illustration shows the rendered <xref targtype="class_winrt" rid="w_ui_xaml_shp.path">Path</xref>. </p>
      
      ge p8:href="F7350D28-90E9-4423-9027-0A1C013D8381" xmlns:p8="http://www.w3.org/1999/xlink" />
-->
In XAML, you can also use [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax) as the value for the Data property. This example uses this syntax to specify the shape of a [Path](path.md).

```xaml
<Canvas>
  <Path Stroke="DarkGoldenRod" StrokeThickness="3"
    Data="M 100,200 C 100,25 400,350 400,175 H 280"/>
</Canvas>
```

The **Data** attribute string begins with the *move to* command, indicated by "M", which establishes a start point for the path in the coordinate system of the [Canvas](../windows.ui.xaml.controls/canvas.md). Strings in the [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax) are case-sensitive and determine whether commands use relative (offset) or absolute coordinates. The first segment is a cubic Bezier curve beginning at (100,200) and ending at (400,175), drawn using the two control points (100,25) and (400,350).

The second segment begins with an absolute horizontal *line to* command "H", which specifies a line drawn from the preceding subpath's endpoint (400,175) to a new endpoint (280,175). Because it is a horizontal *line to* command, the value specified is an x-coordinate.

## -see-also
[Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax)
