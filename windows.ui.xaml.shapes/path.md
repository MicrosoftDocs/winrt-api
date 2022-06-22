---
-api-id: T:Windows.UI.Xaml.Shapes.Path
-api-type: winrt class
---

<!-- Class syntax.
public class Path : Windows.UI.Xaml.Shapes.Shape, Windows.UI.Xaml.Shapes.IPath
-->

# Windows.UI.Xaml.Shapes.Path

## -description
Draws a series of connected lines and curves. The line and curve dimensions are declared through the [Data](path_data.md) property, and can be specified either with [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax), or with an object model.



## -xaml-syntax
```xaml
<Path .../>
```


## -remarks

## -examples
This XAML example uses a **Path** with a [GeometryGroup](../windows.ui.xaml.media/geometrygroup.md) value as [Data](path_data.md) to draw a superimposed ellipse and rectangle shape.

```xaml
<Canvas> 
  <Path Fill="Gold" Stroke="Black" StrokeThickness="1">
    <Path.Data>
      <GeometryGroup>
        <EllipseGeometry Center="50,50" RadiusX="50" RadiusY="50"/>
        <RectangleGeometry Rect="0,0,100,100" />
      </GeometryGroup>
    </Path.Data>
  </Path> 
</Canvas>
```



## -see-also
[Shape](shape.md), [Data](path_data.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes), [Move and draw commands syntax](/windows/uwp/xaml-platform/move-draw-commands-syntax), [Windows.UI.Xaml.Media namespace](../windows.ui.xaml.media/windows_ui_xaml_media.md)
