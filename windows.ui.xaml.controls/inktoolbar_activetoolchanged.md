---
-api-id: E:Windows.UI.Xaml.Controls.InkToolbar.ActiveToolChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ActiveToolChanged<Windows.UI.Xaml.Controls.InkToolbar,  object>
-->

# Windows.UI.Xaml.Controls.InkToolbar.ActiveToolChanged

## -description
Occurs when the currently selected feature in the [RadioButton](radiobutton.md) group of the [InkToolbar](inktoolbar.md) is changed.
This event provides access to the following objects:

+ [InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md)
+ [InkToolbarPencilButton](inktoolbarpencilbutton.md)
+ [InkToolbarEraserButton](inktoolbareraserbutton.md)
+ [InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)
+ [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md)
+ [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)


Features in this group are mutually exclusive: selecting a feature deselects the currently active feature.

> [!NOTE]
> [InkToolbarRulerButton](inktoolbarrulerbutton.md) and [InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md) objects work in conjunction with the active feature and are not exposed to the ActiveToolChanged event.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [ActiveTool](/uwp/api/windows.ui.xaml.controls.inktoolbar.ActiveTool), [Simple ink sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex ink sample (C++)](https://go.microsoft.com/fwlink/p/?LinkID=620314), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
