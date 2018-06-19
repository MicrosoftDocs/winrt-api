---
-api-id: M:Windows.UI.Input.Inking.InkDrawingAttributes.CreateForPencil
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Input.Inking.InkDrawingAttributes CreateForPencil()
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.CreateForPencil

## -description

Creates an [InkDrawingAttributes](inkdrawingattributes.md) object for rendering an ink stroke with pencil characteristics.

## -returns

An [InkDrawingAttributes](inkdrawingattributes.md) object that supports the following properties:

+ [Color](inkdrawingattributes_color.md)
+ [FitToCurve](inkdrawingattributes_fittocurve.md)
+ [IgnorePressure](inkdrawingattributes_ignorepressure.md)
+ [Size](inkdrawingattributes_size.md)

> Setting other [InkDrawingAttributes](inkdrawingattributes.md) properties results in an exception.

## -remarks

By default, a pencil draws a soft-edged, textured, and semi-transparent stroke (useful for layered shading effects) with a Circle PenTip. The stroke color (darkness) is dependent on the pen pressure detected.

## -examples

## -see-also
[InkToolbar](../windows.ui.xaml.controls/inktoolbar.md), [InkToolbarPencilButton](../windows.ui.xaml.controls/inktoolbarpencilbutton.md)