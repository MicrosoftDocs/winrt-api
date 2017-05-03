---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributes.Color
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Color Color { get;  set; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.Color

## -description
Gets or sets a value that indicates the color of an [InkStroke](inkstroke.md).

## -property-value
The ink color as an ARGB value. The default is black (0, 0, 0, 0).

## -remarks
The value of [Color](inkdrawingattributes_color.md) is an ARGB value. However, the value of the transparency component (A, or alpha channel) is ignored and the [InkStroke](inkstroke.md) is rendered at full opacity.

The value of the transparency component is not discarded. It is stored with all other stroke data in the Ink Serialized Format (ISF) file when the [InkStroke](inkstroke.md) is saved.

## -examples
The following example demonstrates how to set the [Color](inkdrawingattributes_color.md) property (`color`) of an [InkStroke](inkstroke.md) (`stroke`) using the [Windows.UI.ColorHelper.FromArgb](../windows.ui/colorhelper_fromargb.md) method.

```

var drawingAttributes = stroke.drawingAttributes;
drawingAttributes.color = 
     Windows.UI.ColorHelper.fromArgb(255, 255, 0, 0);
stroke.drawingAttributes = drawingAttributes;

```

The following alternative demonstrates how to set the [Color](inkdrawingattributes_color.md) property (`color`) of an [InkStroke](inkstroke.md) (`stroke`) without using the [Windows.UI.ColorHelper.FromArgb](../windows.ui/colorhelper_fromargb.md) method.

```
var drawingAttributes = stroke.drawingAttributes;
var color = drawingAttributes.color;
color.a = 255;
color.r = 255;
color.g = 0;
color.b = 0;
drawingAttributes.color = color;
stroke.drawingAttributes = drawingAttributes;

```

For the complete example, see [Ink App sample](http://go.microsoft.com/fwlink/p/?linkid=231622).

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)