---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributesPencilProperties.Opacity
-api-type: winrt property
---

<!-- Property syntax
public double Opacity { get;  set; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributesPencilProperties.Opacity

## -description

Gets or sets the level of transparency used for rendering a pencil stroke on an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

[Opacity](inkdrawingattributespencilproperties_opacity.md) is a static property of [InkDrawingAttributes](inkdrawingattributes.md).

Get an instance of this class by calling [InkDrawingAttributes.CreateForPencil](inkdrawingattributes_createforpencil_181700669.md) and accessing [InkDrawingAttributes.PencilProperties](inkdrawingattributes_pencilproperties.md).

## -property-value

A value between 0.01 and 5.0 that specifies the opacity factor, with 5.0 indicating full opacity. The default value is 1.0.

## -remarks

## -examples

## -see-also

[InkToolbar](../windows.ui.xaml.controls/inktoolbar.md), [InkToolbarPencilButton](../windows.ui.xaml.controls/inktoolbarpencilbutton.md)