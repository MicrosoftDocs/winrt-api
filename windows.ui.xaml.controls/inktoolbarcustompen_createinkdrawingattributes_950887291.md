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
When providing a custom pen, it is possible to derive from [InkToolbarCustomPen](inktoolbarcustompen.md) and specify a custom [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md). The derived class overrides the [CreateInkDrawingAttributesCore](inktoolbarcustompen_createinkdrawingattributescore_257776854.md) method to change the default [InkDrawingAttributes](../windows.ui.input.inking/inkdrawingattributes.md) settings.

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [InkDrawingAttributes](inktoolbar_inkdrawingattributes.md), [InkDrawingAttributesChanged](inktoolbar_inkdrawingattributeschanged.md), [CreateInkDrawingAttributesCore](inktoolbarcustompen_createinkdrawingattributescore_257776854.md), [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)

## -ignore
<!--
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions)

[Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar)

[Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough)

### Reference
[InkDrawingAttributes](inktoolbar_inkdrawingattributes.md), [InkDrawingAttributesChanged](inktoolbar_inkdrawingattributeschanged.md), [CreateInkDrawingAttributesCore](inktoolbarcustompen_createinkdrawingattributescore_257776854.md)

### Samples
* [Simple ink sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk)
* [Complex ink sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk)
* [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink)
* [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink)
* [Coloring book sample](https://aka.ms/cpubsample-coloringbook)
* [Family notes sample](https://aka.ms/cpubsample-familynotessample)
-->
