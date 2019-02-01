---
-api-id: T:Windows.UI.Xaml.Shapes.Path
-api-type: winrt class
---

<!-- Class syntax.
public class Path : Windows.UI.Xaml.Shapes.Shape, Windows.UI.Xaml.Shapes.IPath
-->

# Windows.UI.Xaml.Shapes.Path

## -description
Draws a series of connected lines and curves. The line and curve dimensions are declared through the [Data](path_data.md) property, and can be specified either with [Move and draw commands syntax](https://msdn.microsoft.com/library/7772bc3e-a631-46ff-9940-3dd5b9d0e0d9), or with an object model.

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
[Shape](shape.md), [Data](path_data.md), [XAML vector-based drawing sample](https://go.microsoft.com/fwlink/p/?linkid=226866), [Draw shapes](https://msdn.microsoft.com/library/54cc0bd4-1961-44d7-ab40-6e8b58e42d65), [Move and draw commands syntax](https://msdn.microsoft.com/library/7772bc3e-a631-46ff-9940-3dd5b9d0e0d9), [Windows.UI.Xaml.Media namespace](../windows.ui.xaml.media/windows_ui_xaml_media.md)
