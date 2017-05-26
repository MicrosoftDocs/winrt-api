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
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43)

[Add an InkToolbar to a Universal Windows Platform (UWP) app](https://docs.microsoft.com/windows/uwp/input-and-devices/ink-toolbar)

[Get Started Tutorial: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough)

### Reference
[InkDrawingAttributes](inktoolbar_inkdrawingattributes.md), [InkDrawingAttributesChanged](inktoolbar_inkdrawingattributeschanged.md), [CreateInkDrawingAttributes](inktoolbarcustompen_createinkdrawingattributes.md)

### Samples
* [Simple ink sample (C#/C++)](http://go.microsoft.com/fwlink/p/?LinkID=620312)
* [Complex ink sample (C++)](http://go.microsoft.com/fwlink/p/?LinkID=620314)
* [Ink sample (JavaScript)](http://go.microsoft.com/fwlink/p/?LinkID=620308)
* [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink)
* [Coloring book sample](https://aka.ms/cpubsample-coloringbook)
* [Family notes sample](https://aka.ms/cpubsample-familynotessample)

