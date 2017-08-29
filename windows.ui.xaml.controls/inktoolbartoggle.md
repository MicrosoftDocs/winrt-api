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
[Windows.UI.Xaml.Controls enumerations](windows_ui_xaml_controls_enumerations.md)