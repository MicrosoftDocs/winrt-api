---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton
-api-type: winrt class
---

<!-- Class syntax.
public class InkToolbarCustomToggleButton : Windows.UI.Xaml.Controls.InkToolbarToggleButton, Windows.UI.Xaml.Controls.IInkToolbarCustomToggleButton
-->

# Windows.UI.Xaml.Controls.InkToolbarCustomToggleButton

## -description
Represents an [InkToolbar](inktoolbar.md) button that sets the state of an app-defined feature to on or off. When turned on, the feature works in conjunction with the active tool.

## -remarks

The [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ One group of "tool" buttons containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting ([InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)) buttons. Custom tools ([InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)) are added here.

    > Feature selection is mutually exclusive.

+ A second group of "toggle" buttons containing the built-in ruler ([InkToolbarRulerButton](inktoolbarrulerbutton.md)) button. Custom toggles ([InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)) are added here.

    > Features are not mutually exclusive and can be used concurrently with other active tools.

## -examples
In this example, we define a custom toggle button that enables inking with touch input. By default, touch inking is not enabled.

Typically, touch input is used for direct manipulation of an object or the app UI. To demonstrate the differences in behavior when touch inking is enabled, we place the [InkCanvas](inkcanvas.md) within a [ScrollViewer](scrollviewer.md) container and set the dimensions of the [ScrollViewer](scrollviewer.md) to be smaller than the [InkCanvas](inkcanvas.md).

When the app starts, only pen inking is supported, with touch used for panning or zooming of the inking surface. When touch inking is enabled, the inking surface cannot be panned or zoomed through touch input.

> [!NOTE]
> See [Inking controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/inking-controls) for both [InkCanvas](inkcanvas.md) and [InkToolbar](inktoolbar.md) UX guidelines. The following recommendations are relevant to this example:
+ The [InkToolbar](inktoolbar.md), and inking in general, is best experienced through an active pen. However, inking with mouse and touch can be supported if required by your app.
+ If supporting inking with touch input, we recommend using the "ED5F" icon from the "Segoe MLD2 Assets" font for the toggle button, with a "Touch writing" tooltip.


Here, we declare a [InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md) element (`toggleButton`) with a [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event listener that specifies the event handler (`Toggle_Custom`).



[!code-xml[UI_AddCustomToggle](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage_AddCustomToggle.xaml#SnippetUI_AddCustomToggle)]

In the previous snippet, we declared a [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event listener and handler (`Toggle_Custom`) on the custom toggle button for touch inking (`toggleButton`). This handler simply toggles support for [CoreInputDeviceTypes.Touch](../windows.ui.core/coreinputdevicetypes.md) through the [InputDeviceTypes](../windows.ui.input.inking/inkpresenter_inputdevicetypes.md) property of the [InkPresenter](inkcanvas_inkpresenter.md).

We also specified an icon for the button using the [SymbolIcon](symbolicon.md) element and the [{x:Bind} markup extension](https://msdn.microsoft.com/library/529fbeb5-e589-486f-a204-b310acdc5c06) that binds it to a field defined in the code-behind file (`TouchWritingIcon`).

The following snippet includes both the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event handler and the definition of `TouchWritingIcon` for this example.



[!code-csharp[CustomToggleMain](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage_AddCustomToggle.xaml.cs#SnippetCustomToggleMain)]

## -see-also
[Pen and stylus interactions](https://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Add an InkToolbar to a Universal Windows Platform (UWP) app](https://docs.microsoft.com/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Windows.UI.Xaml.Controls classes](windows_ui_xaml_controls_classes.md), [InkToolbarToggleButton](inktoolbartogglebutton.md) , [InkToolbarToggle](inktoolbartoggle.md), [Ink sample (JavaScript)](https://go.microsoft.com/fwlink/p/?LinkID=620308), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)

<!--
[Windows.UI.Xaml.Controls classes](windows_ui_xaml_controls_classes.md)

## -see-also
[Pen and stylus interactions](https://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43)

[Add an InkToolbar to a Universal Windows Platform (UWP) app](https://docs.microsoft.com/windows/uwp/input-and-devices/ink-toolbar)

[Get Started Tutorial: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough)

### Reference
[Windows.UI.Xaml.Controls classes](windows_ui_xaml_controls_classes.md), [InkToolbarToggleButton](inktoolbartogglebutton.md) , [InkToolbarToggle](inktoolbartoggle.md)

### Samples
* [Simple ink sample (C#/C++)](https://go.microsoft.com/fwlink/p/?LinkID=620312)
* [Complex ink sample (C++)](https://go.microsoft.com/fwlink/p/?LinkID=620314)
* [Ink sample (JavaScript)](https://go.microsoft.com/fwlink/p/?LinkID=620308)
* [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink)
* [Coloring book sample](https://aka.ms/cpubsample-coloringbook)
* [Family notes sample](https://aka.ms/cpubsample-familynotessample)
-->
