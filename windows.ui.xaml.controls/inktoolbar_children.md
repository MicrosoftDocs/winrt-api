---
-api-id: P:Windows.UI.Xaml.Controls.InkToolbar.Children
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyObjectCollection Children { get; }
-->

# Windows.UI.Xaml.Controls.InkToolbar.Children

## -description
Gets the collection of custom buttons displayed on the [InkToolbar](inktoolbar.md).

## -property-value
A collection of [InkToolbar](inktoolbar.md) custom buttons.

## -remarks
Children returns only the number of buttons on the [InkToolbar](inktoolbar.md) that have been added manually (see [ActiveTool](inktoolbar_activetool.md) and [InitialControls](inktoolbar_initialcontrols.md)). The default [InkToolbar](inktoolbar.md) does not add any buttons to the value of this property.

Children does not include buttons declared in markup.


The [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ One group of "tool" buttons containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting ([InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)) buttons. Custom tools ([InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)) are added here.

> Feature selection is mutually exclusive.
+ A second group of "toggle" buttons containing the built-in stencil ([InkToolbarStencilButton](inktoolbarstencilbutton.md)) button (or the [InkToolbarRulerButton](inktoolbarrulerbutton.md) button). Custom toggles ([InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)) are added here.

> Features are not mutually exclusive and can be used concurrently with other active tools.


## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [ChildrenProperty](/uwp/api/windows.ui.xaml.controls.inktoolbar.ChildrenProperty), [Simple ink sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex ink sample (C++)](https://go.microsoft.com/fwlink/p/?LinkID=620314), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
