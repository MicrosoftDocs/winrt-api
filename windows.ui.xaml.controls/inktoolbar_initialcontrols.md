---
-api-id: P:Windows.UI.Xaml.Controls.InkToolbar.InitialControls
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.InkToolbarInitialControls InitialControls { get;  set; }
-->

# Windows.UI.Xaml.Controls.InkToolbar.InitialControls

## -description
Gets or sets the collection of built-in buttons added to the [InkToolbar](inktoolbar.md) at initialization.

This property overrides the default collection of built-in buttons.


By default, the [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ A [RadioButton](radiobutton.md) group containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting ([InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)) buttons. This group is where [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md) objects are added.

> Feature selection is mutually exclusive.
+ A second group of "toggle" buttons containing the built-in stencil ([InkToolbarStencilButton](inktoolbarstencilbutton.md)) button (or the [InkToolbarRulerButton](inktoolbarrulerbutton.md) button). Custom toggles ([InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)) are added here.

> Features are not mutually exclusive and can be used concurrently with other active tools.


## -property-value
The collection of built-in buttons to add to the [InkToolbar](inktoolbar.md).

## -remarks
Default built-in buttons, or those specified through InitialControls, are not added to the [Children](inktoolbar_children.md) property.

Built-in or custom buttons added programmatically or declared in XAML, are added to the [Children](inktoolbar_children.md) property.

Built-in buttons are displayed in a pre-determined order within their respective control groups. Custom buttons are added to the appropriate control group in the order specified, after all built-in buttons.

## -examples

To specify which built-in buttons are displayed at initialization:

1. Set InitialControls to [None](inktoolbarinitialcontrols.md).
1. Add the individual buttons.
1. Specify the [InkToolbar](inktoolbar.md) UI experience, such as the default button.
The following examples (both XAML and code-behind) show how to clear the default buttons from the InkToolber, add ballpoint pen, pencil, and eraser buttons, and set the default button to pencil.

XAML



[!code-xaml[UI](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage.xaml#SnippetUI)]



[!code-xaml[UI_CB](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage_CodeBehind.xaml#SnippetUI_CB)]

[!code-csharp[InkToolbarMainPageCB](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage_CodeBehind.xaml.cs#SnippetInkToolbarMainPageCB)]

[!code-csharp[InkToolbarLoadingCB](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage_CodeBehind.xaml.cs#SnippetInkToolbarLoadingCB)]

[!code-csharp[InkToolbarLoadedCB](../windows.ui.input.inking/code/Ink_Basic_InkToolbar/csharp/MainPage_CodeBehind.xaml.cs#SnippetInkToolbarLoadedCB)]

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [**InitialControlsProperty**](/uwp/api/windows.ui.xaml.controls.inktoolbar.InitialControlsProperty), [Simple ink sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex ink sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)

<!--
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions)

[Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar)

[Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough)

### Reference
[InitialControlsProperty](/uwp/api/windows.ui.xaml.controls.inktoolbar#Windows_UI_Xaml_Controls_InkToolbar_InitialControlsProperty)

### Samples
* [Simple ink sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk)
* [Complex ink sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk)
* [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink)
* [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink)
* [Coloring book sample](https://aka.ms/cpubsample-coloringbook)
* [Family notes sample](https://aka.ms/cpubsample-familynotessample)
-->
