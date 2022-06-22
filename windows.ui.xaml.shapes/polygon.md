---
-api-id: T:Windows.UI.Xaml.Shapes.Polygon
-api-type: winrt class
---

<!-- Class syntax.
public class Polygon : Windows.UI.Xaml.Shapes.Shape, Windows.UI.Xaml.Shapes.IPolygon
-->

# Windows.UI.Xaml.Shapes.Polygon

## -description
Draws a polygon, which is a connected series of lines that form a closed shape.



## -xaml-syntax
```xaml
<Polygon .../>
```


## -remarks
The Polygon object is similar to the [Polyline](polyline.md) object, except that Polygon must be a closed shape.

You define the shape by adding vertices to the [Points](polygon_points.md) collection. For example, two points could form a line, three points could form a triangle, and four points could form a quadrilateral.

The [FillRule](polygon_fillrule.md) property specifies how the interior area of the shape is determined. See the [FillRule](../windows.ui.xaml.media/fillrule.md) enumeration for more info.

You can set the [Fill](shape_fill.md) property to give the shape a background fill, like a solid color, gradient, or image. You can set the [Stroke](shape_stroke.md) and other related stroke properties to specify the look of the shape's outline.

## -examples
This example shows how to use a Polygon to create a triangle.

```xaml
<Canvas>

  <!- - This polygon shape uses pre-defined color values for its Stroke and
       Fill properties.
       The SolidColorBrush's Opacity property affects the fill color in
       this case by making it slightly transparent (opacity of 0.4) so
       that it blends with any underlying color. - ->

  <Polygon
    Points="300,200 400,125 400,275"
    Stroke="Purple"
    StrokeThickness="2">
    <Polygon.Fill>
       <SolidColorBrush Color="Blue" Opacity="0.4"/>
    </Polygon.Fill>
  </Polygon> 
 
</Canvas>
```



## -see-also
[Shape](shape.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes)
