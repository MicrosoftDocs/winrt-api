---
-api-id: E:Windows.UI.Xaml.Controls.InkToolbar.EraseAllClicked
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler EraseAllClicked<Windows.UI.Xaml.Controls.InkToolbar,  object>
-->

# Windows.UI.Xaml.Controls.InkToolbar.EraseAllClicked

## -description
Occurs when "Erase All  Ink" is selected from the flyout for the [InkToolbarEraserButton](inktoolbareraserbutton.md) on the [InkToolbar](inktoolbar.md).

## -remarks
Each feature on the [InkToolbar](inktoolbar.md) can support supplementary functionality in a flyout (an "extension glyph" on the feature button indicates to the user that the functionality is available). "Erase All  Ink" is the built-in flyout for the Eraser button.

To access the functionality, the feature button must be selected already, and the user must select the button again.



> **Custom drying and the InkToolbar**
> By default, ink input is processed on a low-latency background thread and rendered "wet" as it is drawn. When the stroke is completed (pen or finger lifted, or mouse button released), the stroke is processed on the UI thread and rendered "dry" to the [InkCanvas](inkcanvas.md) layer (above the application content and replacing the wet ink). The ink platform enables you to override this behavior and completely customize the inking experience by custom drying the ink input.

If your app overrides the default ink rendering behavior of the [InkPresenter](../windows.ui.input.inking/inkpresenter.md) with a custom drying implementation, the rendered ink strokes are no longer available to the [InkToolbar](inktoolbar.md) and the built-in erase commands of the [InkToolbar](inktoolbar.md) do not work as expected. To provide erase functionality, you must handle all pointer events, perform hit-testing on each stroke, and override the built-in "Erase all ink" command.

For more info on custom drying, see [Pen interactions and Windows Ink in UWP apps](https://msdn.microsoft.com/windows/uwp/input-and-devices/pen-and-stylus-interactions#custom-ink-rendering).

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Add an InkToolbar to a Universal Windows Platform (UWP) app](https://docs.microsoft.com/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [**InkToolbarEraserButton**](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.inktoolbar#Windows_UI_Xaml_Controls_InkToolbar_inktoolbareraserbutton), [Simple ink sample (C#/C++)](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample (C++)](http://go.microsoft.com/fwlink/p/?LinkID=620314), [Ink sample (JavaScript)](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)

<!--
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43)

[Add an InkToolbar to a Universal Windows Platform (UWP) app](https://docs.microsoft.com/windows/uwp/input-and-devices/ink-toolbar)

[Get Started Tutorial: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough)

### Reference
[InkToolbarEraserButton](https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.inktoolbar#Windows_UI_Xaml_Controls_InkToolbar_inktoolbareraserbutton)

### Samples
* [Simple ink sample (C#/C++)](http://go.microsoft.com/fwlink/p/?LinkID=620312)
* [Complex ink sample (C++)](http://go.microsoft.com/fwlink/p/?LinkID=620314)
* [Ink sample (JavaScript)](http://go.microsoft.com/fwlink/p/?LinkID=620308)
* [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink)
* [Coloring book sample](https://aka.ms/cpubsample-coloringbook)
* [Family notes sample](https://aka.ms/cpubsample-familynotessample)
-->
