---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbar
-api-type: winrt class
---

<!-- Class syntax.
public class InkToolbar : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IInkToolbar, Windows.UI.Xaml.Controls.IInkToolbar2
-->

# Windows.UI.Xaml.Controls.InkToolbar

## -description
Represents a Universal Windows app control containing a customizable and extensible collection of buttons that activate ink-related features in an associated [InkCanvas](inkcanvas.md).

## -remarks

Associate an [InkToolbar](inktoolbar.md) with an [InkCanvas](inkcanvas.md) control through the [TargetInkCanvas](inktoolbar_targetinkcanvas.md) property.

By default, the toolbar includes buttons for drawing, erasing, highlighting, and displaying a ruler. Depending on the feature, other settings and commands, such as ink color, stroke thickness, erase all, are provided in a flyout. An "extension glyph" is displayed on the button to indicate the existence of the flyout.

The [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ One group of "tool" buttons containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting ([InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)) buttons. Custom tools ([InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)) are added here.

    > Feature selection is mutually exclusive.

+ A second group of "toggle" buttons containing the built-in ruler ([InkToolbarRulerButton](inktoolbarrulerbutton.md)) button. Custom toggles ([InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)) are added here.

    > Features are not mutually exclusive and can be used concurrently with other active tools.

Built-in buttons can be displayed by default, or you can specify which should be displayed by your app. See [InitialControls](inktoolbar_initialcontrols.md).

You cannot change the display order of the built-in buttons. The default display order is: [InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md), [InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md), [InkToolbarEraserButton](inktoolbareraserbutton.md), and [InkToolbarRulerButton](inktoolbarrulerbutton.md). Custom tool buttons are added between the highlighter button and the eraser button and custom toggle buttons are added after the ruler button. (Custom buttons are added in the order they are specified.)

**Custom drying and the InkToolbar**

By default, ink input is processed on a low-latency background thread and rendered "wet" as it is drawn. When the stroke is completed (pen or finger lifted, or mouse button released), the stroke is processed on the UI thread and rendered "dry" to the [InkCanvas](inkcanvas.md) layer (above the application content and replacing the wet ink). The ink platform enables you to override this behavior and completely customize the inking experience by custom drying the ink input.

If your app overrides the default ink rendering behavior of the [InkPresenter](../windows.ui.input.inking/inkpresenter.md) with a custom drying implementation, the rendered ink strokes are no longer available to the [InkToolbar](inktoolbar.md) and the built-in erase commands of the [InkToolbar](inktoolbar.md) do not work as expected. To provide erase functionality, you must handle all pointer events, perform hit-testing on each stroke, and override the built-in "Erase all ink" command.

For more info on custom drying, see [Pen interactions and Windows Ink in UWP apps](https://msdn.microsoft.com/en-us/windows/uwp/input-and-devices/pen-and-stylus-interactions#custom-ink-rendering).

## -examples
Here, we show a typical [InkToolbar](inktoolbar.md) declaration and binding to an [InkCanvas](inkcanvas.md).



[!code-xml[UI_CB](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage_CodeBehind.xaml#SnippetUI_CB)]

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Add an InkToolbar to a Universal Windows Platform (UWP) app](https://docs.microsoft.com/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [Control](control.md), [Windows.UI.Xaml.Controls classes](windows_ui_xaml_controls_classes.md), [InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarCustomPen](inktoolbarcustompen.md), [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md), [InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md), [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md), [InkToolbarEraserButton](inktoolbareraserbutton.md), [InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md), [InkToolbarPenButton](inktoolbarpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md), [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md), [InkToolbarRulerButton](inktoolbarrulerbutton.md), [InkToolbarToggleButton](inktoolbartogglebutton.md), [InkToolbarToolButton](inktoolbartoolbutton.md), [Ink sample (JavaScript)](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)

<!--
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43)

[Add an InkToolbar to a Universal Windows Platform (UWP) app](https://docs.microsoft.com/windows/uwp/input-and-devices/ink-toolbar)

[Get Started Tutorial: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough)

### Reference
[Control](control.md), [Windows.UI.Xaml.Controls classes](windows_ui_xaml_controls_classes.md), [InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarCustomPen](inktoolbarcustompen.md), [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md), [InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md), [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md), [InkToolbarEraserButton](inktoolbareraserbutton.md), [InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md), [InkToolbarPenButton](inktoolbarpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md), [InkToolbarPenConfigurationControl](inktoolbarpenconfigurationcontrol.md), [InkToolbarRulerButton](inktoolbarrulerbutton.md), [InkToolbarToggleButton](inktoolbartogglebutton.md), [InkToolbarToolButton](inktoolbartoolbutton.md)

### Samples
* [Simple ink sample (C#/C++)](http://go.microsoft.com/fwlink/p/?LinkID=620312)
* [Complex ink sample (C++)](http://go.microsoft.com/fwlink/p/?LinkID=620314)
* [Ink sample (JavaScript)](http://go.microsoft.com/fwlink/p/?LinkID=620308)
* [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink)
* [Coloring book sample](https://aka.ms/cpubsample-coloringbook)
* [Family notes sample](https://aka.ms/cpubsample-familynotessample)
-->
