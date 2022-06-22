---
-api-id: T:Windows.UI.Xaml.Shapes.Line
-api-type: winrt class
---

<!-- Class syntax.
public class Line : Windows.UI.Xaml.Shapes.Shape, Windows.UI.Xaml.Shapes.ILine
-->

# Windows.UI.Xaml.Shapes.Line

## -description
Draws a straight line between two points.



## -xaml-syntax
```xaml
<Line .../>
```


## -remarks
Set the [Stroke](shape_stroke.md) to specify the color of the line. Set the [StrokeThickness](shape_strokethickness.md) property to specify the thickness of the line.

## -examples
This example shows how to use the Line class to create three lines.

```xaml
<Canvas Height="300" Width="300">
  <!- - Draws a diagonal line from (10,10) to (50,50). - ->
  <Line
    X1="10" Y1="10"
    X2="50" Y2="50"
    Stroke="Black"
    StrokeThickness="4" />

  <!- - Draws a diagonal line from (10,10) to (50,50)
       and moves it 100 pixels to the right. - ->
  <Line
    X1="10" Y1="10"
    X2="50" Y2="50"
    Stroke="Blue"
    StrokeThickness="4"
    Canvas.Left="100"/>

  <!- - Draws a horizontal line from (10,60) to (150,60). - ->
  <Line
     X1="10" Y1="60"
     X2="150" Y2="60"
     Stroke="Black"
     StrokeThickness="4"/>

</Canvas>
```



## -see-also
[Shape](shape.md), [XAML vector-based drawing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20vector-based%20drawing%20sample), [Draw shapes](/windows/uwp/graphics/drawing-shapes)
