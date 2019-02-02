---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarToggle
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.InkToolbarToggle : int
-->

# InkToolbarToggle

## -description

Defines constants that specify the button types exposed in the toggle button group of an [InkToolbar](inktoolbar.md).

## -enum-fields
### -field Ruler:0
A toggle button for a stencil tool.

### -field Custom:1
A toggle button for a custom tool.


## -remarks

The [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ A [RadioButton](radiobutton.md) group containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting ([InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)) buttons. This group is where [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md) objects are added.

    > Feature selection is mutually exclusive.

+ A toggle button group containing the built-in ruler ([InkToolbarRulerButton](inktoolbarrulerbutton.md)) button. This group is where [InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md) objects are added.

    > Features are not mutually exclusive and can be used concurrently with other active tools.

## -examples

## -see-also
[Pen and stylus interactions](https://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Add an InkToolbar to a Universal Windows Platform (UWP) app](https://docs.microsoft.com/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Ink sample (JavaScript)](https://go.microsoft.com/fwlink/p/?LinkID=620308), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
