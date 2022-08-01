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

For more info on custom drying, see [Pen interactions and Windows Ink in UWP apps](/windows/uwp/input-and-devices/pen-and-stylus-interactions).

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [**InkToolbarEraserButton**](inktoolbareraserbutton.md), [Simple ink sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex ink sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk), [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)

<!--
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions)

[Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar)

[Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough)

### Reference
[InkToolbarEraserButton](/uwp/api/windows.ui.xaml.controls.inktoolbar#Windows_UI_Xaml_Controls_InkToolbar_inktoolbareraserbutton)

### Samples
* [Simple ink sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk)
* [Complex ink sample (C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ComplexInk)
* [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink)
* [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink)
* [Coloring book sample](https://aka.ms/cpubsample-coloringbook)
* [Family notes sample](https://aka.ms/cpubsample-familynotessample)
-->
