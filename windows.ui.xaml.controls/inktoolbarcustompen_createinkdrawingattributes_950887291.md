---
-api-id: M:Windows.UI.Xaml.Controls.InkToolbarCustomPen.CreateInkDrawingAttributes(Windows.UI.Xaml.Media.Brush,System.Double)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Input.Inking.InkDrawingAttributes CreateInkDrawingAttributes(Windows.UI.Xaml.Media.Brush brush, System.Double strokeWidth)
-->

# Windows.UI.Xaml.Controls.InkToolbarCustomPen.CreateInkDrawingAttributes

## -description
Retrieves the [InkToolbarCustomPen](inktoolbarcustompen.md) attributes used for an [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md).

## -parameters
### -param brush
The brush used to draw the stroke. The default is 0 ([Black](../windows.ui/colors_black.md)).

### -param strokeWidth
The width of the stroke. The default is 0.

## -returns
The attributes applied to the [InkStroke](../windows.ui.input.inking/inkstroke.md) when it is drawn.

## -remarks
When providing a custom pen, it is possible to derive from [InkToolbarCustomPen](inktoolbarcustompen.md) and specify a custom [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md). The derived class overrides the [CreateInkDrawingAttributesCore](inktoolbarcustompen_createinkdrawingattributescore.md) method to change the default [InkDrawingAttributes](../windows.ui.input.inking/inkdrawingattributes.md) settings.

## -examples

## -see-also
[InkDrawingAttributes](inktoolbar_inkdrawingattributes.md), [InkDrawingAttributesChanged](inktoolbar_inkdrawingattributeschanged.md), [CreateInkDrawingAttributesCore](inktoolbarcustompen_createinkdrawingattributescore.md)