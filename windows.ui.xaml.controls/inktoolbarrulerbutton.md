---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarRulerButton
-api-type: winrt class
---

<!-- Class syntax.
public class InkToolbarRulerButton : Windows.UI.Xaml.Controls.InkToolbarToggleButton, Windows.UI.Xaml.Controls.IInkToolbarRulerButton
-->

# Windows.UI.Xaml.Controls.InkToolbarRulerButton

## -description
Represents an [InkToolbar](inktoolbar.md) button that sets the state of the built-in ruler tool to on or off.


The [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ One group of "tool" buttons containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting ([InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)) buttons. Custom tools ([InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)) are added here.



> Feature selection is mutually exclusive.
+ A second group of "toggle" buttons containing the built-in ruler ([InkToolbarRulerButton](inktoolbarrulerbutton.md)) button. Custom toggles ([InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)) are added here.



> Features are not mutually exclusive and can be used concurrently with other active tools.


## -remarks

## -examples

## -see-also
[InkToolbarToggleButton](inktoolbartogglebutton.md), [IsRulerButtonChecked](inktoolbar_isrulerbuttonchecked.md), [IsRulerButtonCheckedChanged](inktoolbar_isrulerbuttoncheckedchanged.md)