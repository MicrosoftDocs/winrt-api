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

## -remarks

The InkToolbarPenConfigurationControl is configured by default for built-in pen buttons derived from [InkToolbarPenButton](inktoolbarpenbutton.md). Custom pen buttons can use these default settings or fully customize them (see examples).

## -examples
Here's an example of a custom pen that reuses the default InkToolbarPenConfigurationControl.



[!code-xaml[UI_AddCustom](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage_AddCustom.xaml#SnippetUI_AddCustom)]

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough),  [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
