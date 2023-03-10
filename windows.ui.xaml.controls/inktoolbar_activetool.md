---
-api-id: P:Windows.UI.Xaml.Controls.InkToolbar.ActiveTool
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.InkToolbarToolButton ActiveTool { get;  set; }
-->

# Windows.UI.Xaml.Controls.InkToolbar.ActiveTool

## -description
Gets or sets the currently selected feature in the "tools" group of the [InkToolbar](inktoolbar.md) (see remarks).
This property provides access to the following objects:

+ [InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md)
+ [InkToolbarPencilButton](inktoolbarpencilbutton.md)
+ [InkToolbarEraserButton](inktoolbareraserbutton.md)
+ [InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)
+ [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md)
+ [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)


Features in this group are mutually exclusive: selecting a feature deselects the currently active feature.

> [!NOTE]
> [InkToolbarRulerButton](inktoolbarrulerbutton.md) and [InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md) objects work in conjunction with the active feature and are not exposed to the ActiveTool property.

## -property-value
The currently selected feature. By default, this is the first button on the [InkToolbar](inktoolbar.md).

## -remarks

The [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ One group of "tool" buttons containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting ([InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)) buttons. Custom tools ([InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)) are added here.

> Feature selection is mutually exclusive.

+ A second group of "toggle" buttons containing the built-in stencil ([InkToolbarStencilButton](inktoolbarstencilbutton.md)) button (or the [InkToolbarRulerButton](inktoolbarrulerbutton.md) button). Custom toggles ([InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)) are added here.


> Features are not mutually exclusive and can be used concurrently with other active tools.


## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [ActiveToolProperty](/uwp/api/windows.ui.xaml.controls.inktoolbar.ActiveToolProperty), [Simple ink sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex ink sample (C++)](https://go.microsoft.com/fwlink/p/?LinkID=620314), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
