---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarPencilButton
-api-type: winrt class
---

<!-- Class syntax.
public class InkToolbarPencilButton : Windows.UI.Xaml.Controls.InkToolbarPenButton, Windows.UI.Xaml.Controls.IInkToolbarPencilButton
-->

# Windows.UI.Xaml.Controls.InkToolbarPencilButton

## -description
Represents an [InkToolbar](inktoolbar.md) toggle button control that activates the built-in pencil.

The pencil draws a soft-edged, textured, and semi-transparent stroke (useful for layered shading effects) with a [Circle](../windows.ui.input.inking/pentipshape.md) [PenTip](../windows.ui.input.inking/inkdrawingattributes_pentip.md). The stroke color (darkness) is dependent on the pen pressure detected.


The [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ One group of "tool" buttons containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting ([InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)) buttons. Custom tools ([InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)) are added here.



> Feature selection is mutually exclusive.
+ A second group of "toggle" buttons containing the built-in ruler ([InkToolbarRulerButton](inktoolbarrulerbutton.md)) button. Custom toggles ([InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)) are added here.



> Features are not mutually exclusive and can be used concurrently with other active tools.


## -remarks
[InkToolbarPencilButton](inktoolbarpencilbutton.md) inherits from [InkToolbarPenButton](inktoolbarpenbutton.md).

## -examples

## -see-also
[Windows.UI.Xaml.Controls classes](windows_ui_xaml_controls_classes.md), [InkToolbarPenButton](inktoolbarpenbutton.md)