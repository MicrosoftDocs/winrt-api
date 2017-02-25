---
-api-id: M:Windows.UI.Xaml.Controls.InkToolbarCustomPen.CreateInkDrawingAttributesCore(Windows.UI.Xaml.Media.Brush,System.Double)
-api-type: winrt method
---

<!-- Method syntax
virtual protected Windows.UI.Input.Inking.InkDrawingAttributes CreateInkDrawingAttributesCore(Windows.UI.Xaml.Media.Brush brush, System.Double strokeWidth)
-->

# Windows.UI.Xaml.Controls.InkToolbarCustomPen.CreateInkDrawingAttributesCore

## -description
When overridden in a derived class, retrieves an [InkDrawingAttributes](../windows.ui.input.inking/inkdrawingattributes.md) object used to specify the [ConfigurationContent](inktoolbarcustompenbutton_configurationcontent.md) for an [InkToolbarCustomPen](inktoolbarcustompen.md).

This method is not called by application code.

## -parameters
### -param brush
The brush used to draw the stroke. The default is 0 ([Black](../windows.ui/colors_black.md)).

### -param strokeWidth
The width of the stroke. The default is 0.

## -returns
The attributes applied to the [InkStroke](../windows.ui.input.inking/inkstroke.md) when it is drawn.

## -remarks
An [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) can reuse the standard [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md) object to configure an optional settings flyout for the custom pen. An "extension glyph" is displayed on the button to indicate the existence of the flyout.

Derive from [InkToolbarCustomPen](inktoolbarcustompen.md) and specify a custom [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md). Override the [CreateInkDrawingAttributesCore](inktoolbarcustompen_createinkdrawingattributescore.md) method to change the default [InkDrawingAttributes](../windows.ui.input.inking/inkdrawingattributes.md) settings.

## -examples

## -see-also
[InkDrawingAttributes](inktoolbar_inkdrawingattributes.md), [InkDrawingAttributesChanged](inktoolbar_inkdrawingattributeschanged.md), [CreateInkDrawingAttributes](inktoolbarcustompen_createinkdrawingattributes.md)