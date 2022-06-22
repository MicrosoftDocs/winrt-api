---
-api-id: P:Windows.UI.Xaml.Controls.PathIcon.Data
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Geometry Data { get;  set; }
-->

# Windows.UI.Xaml.Controls.PathIcon.Data

## -description
Gets or sets a [Geometry](../windows.ui.xaml.media/geometry.md) that specifies the shape to be drawn. In XAML. this can also be set using a string that describes [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax).


## -xaml-syntax
```xaml
<PathIcon>
  <PathIcon.Data>
    singleGeometry
  </PathIcon.Data>
</PathIcon>
- or -
<PathIcon Data="moveAndDrawCommands"/>
```


## -xaml-values
<dl><dt>singleGeometry</dt><dd>singleGeometryA single object element that derives from Geometry. This can be one of the following: One of the simple geometries EllipseGeometry, LineGeometry, or RectangleGeometry.A single GeometryGroup, which supports other geometries as child elements. A PathGeometry, which supports child object elements that establish a path geometry object model of figures and segments. See the "XAML Values" section of PathGeometry.</dd>
<dt>moveAndDrawCommands</dt><dd>moveAndDrawCommandsThis is a complex syntax that cannot be adequately summarized here. See Move and draw commands syntax.</dd>
</dl>
## -property-value
A description of the shape to be drawn.

## -remarks

## -examples
This example shows an [AppBarButton](appbarbutton.md) with a [PathIcon](pathicon.md).

```xaml
<!-- App bar button with path icon. -->
<AppBarButton Label="PathIcon" Click="AppBarButton_Click">
    <AppBarButton.Icon>
        <PathIcon Data="F1 M 16,12 20,2L 20,16 1,16" HorizontalAlignment="Center"/>
    </AppBarButton.Icon>
</AppBarButton>
```



## -see-also
[Path.Data](../windows.ui.xaml.shapes/path_data.md), [AppBar](appbar.md), [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax)
