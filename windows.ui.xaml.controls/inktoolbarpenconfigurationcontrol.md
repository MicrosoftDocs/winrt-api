---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarPenConfigurationControl
-api-type: winrt class
---

<!-- Class syntax.
public class InkToolbarPenConfigurationControl : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IInkToolbarPenConfigurationControl
-->

# Windows.UI.Xaml.Controls.InkToolbarPenConfigurationControl

## -description
Represents an object used to configure an optional flyout associated with an [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md). An "extension glyph" is displayed on the button to indicate the existence of the flyout.

The [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md) is configured by default for built-in pen buttons derived from [InkToolbarPenButton](inktoolbarpenbutton.md). Custom pen buttons can use these default settings or fully customize them (see examples).

## -remarks

## -examples
Here's an example of a custom pen that reuses the default [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md).



[!code-xml[UI_AddCustom](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage_AddCustom.xaml#SnippetUI_AddCustom)]

## -see-also
[Windows.UI.Xaml.Controls classes](windows_ui_xaml_controls_classes.md), [Control](control.md)
