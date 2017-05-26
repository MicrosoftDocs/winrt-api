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
> [InkToolbarRulerButton](inktoolbarrulerbutton.md) and [InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md) objects work in conjunction with the active feature and are not exposed to the [ActiveToolChanged](inktoolbar_activetoolchanged.md) event.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43)

[Add an InkToolbar to a Universal Windows Platform (UWP) app](https://docs.microsoft.com/windows/uwp/input-and-devices/ink-toolbar)

[Get Started Tutorial: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough)

### Reference
[**ActiveTool**](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.inktoolbar#Windows_UI_Xaml_Controls_InkToolbar_ActiveTool)

### Samples
* [Simple ink sample (C#/C++)](http://go.microsoft.com/fwlink/p/?LinkID=620312)
* [Complex ink sample (C++)](http://go.microsoft.com/fwlink/p/?LinkID=620314)
* [Ink sample (JavaScript)](http://go.microsoft.com/fwlink/p/?LinkID=620308)
* [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink)
* [Coloring book sample](https://aka.ms/cpubsample-coloringbook)
* [Family notes sample](https://aka.ms/cpubsample-familynotessample)
