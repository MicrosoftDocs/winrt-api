---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarHighlighterButton
-api-type: winrt class
---

<!-- Class syntax.
public class InkToolbarHighlighterButton : Windows.UI.Xaml.Controls.InkToolbarPenButton, Windows.UI.Xaml.Controls.IInkToolbarHighlighterButton
-->

# Windows.UI.Xaml.Controls.InkToolbarHighlighterButton

## -description
Represents an [InkToolbar](inktoolbar.md) toggle button control that activates the built-in highlighter pen.

## -remarks

The highlighter draws a semi-transparent stroke with a [Rectangle](../windows.ui.input.inking/pentipshape.md) [PenTip](../windows.ui.input.inking/inkdrawingattributes_pentip.md).

The [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ One group of "tool" buttons containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting (InkToolbarHighlighterButton) buttons. Custom tools ([InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)) are added here.

    > Feature selection is mutually exclusive.

+ A second group of "toggle" buttons containing the built-in stencil ([InkToolbarStencilButton](inktoolbarstencilbutton.md)) button (or the [InkToolbarRulerButton](inktoolbarrulerbutton.md) button). Custom toggles ([InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)) are added here.

    > Features are not mutually exclusive and can be used concurrently with other active tools.

InkToolbarHighlighterButton inherits from [InkToolbarPenButton](inktoolbarpenbutton.md).

By default, the stroke height is 36 pixels and the width is 12 pixels.

The size (in [Device-Independent Pixels](/windows/desktop/LearnWin32/dpi-and-device-independent-pixels)) of the highlighter stroke is obtained from the [InkDrawingAttributes](inktoolbar_inkdrawingattributes.md) setting for [Size](../windows.ui.input.inking/inkdrawingattributes_size.md) —the stroke height is set to [Size.Width](../windows.foundation/size.md) and the stroke width is set to [Size.Width](../windows.foundation/size.md)/3.

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
