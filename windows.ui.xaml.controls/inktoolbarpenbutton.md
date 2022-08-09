---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarPenButton
-api-type: winrt class
---

<!-- Class syntax.
public class InkToolbarPenButton : Windows.UI.Xaml.Controls.InkToolbarToolButton, Windows.UI.Xaml.Controls.IInkToolbarPenButton
-->

# Windows.UI.Xaml.Controls.InkToolbarPenButton

## -description
Provides a base class for all built-in and custom pen buttons on an [InkToolbar](inktoolbar.md).

## -remarks

The InkToolbarPenButton class cannot be instantiated directly. Use the various built-in and custom [InkToolbar](inktoolbar.md) pen buttons instead.

You must create an [InkDrawingAttributes](inktoolbar_inkdrawingattributes.md) object based on the current stroke [Size](../windows.ui.input.inking/inkdrawingattributes_size.md) and [Brush](../windows.ui.xaml.media/brush.md).

The size of the pen stroke is obtained from the [InkDrawingAttributes](inktoolbar_inkdrawingattributes.md) setting for [Size](../windows.ui.input.inking/inkdrawingattributes_size.md). By default, the stroke height and width are set to [Width](../windows.foundation/size.md).

By default, the [InkToolbar](inktoolbar.md) contains the following built-in pen buttons:

Radio group toggle buttons

+ [InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md)
+ [InkToolbarPencilButton](inktoolbarpencilbutton.md)
+ [InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)


### **InkToolbarPenButton** derived classes

InkToolbarPenButton is the base class for:

Pen buttons

+ InkToolbarPenButton

Custom pen buttons

+ [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md)

Radio group toggle buttons (built-in)

+ [InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md)
+ [InkToolbarPencilButton](inktoolbarpencilbutton.md)
+ [InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)


## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
