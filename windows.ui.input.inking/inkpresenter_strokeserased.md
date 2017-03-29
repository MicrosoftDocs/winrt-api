---
-api-id: E:Windows.UI.Input.Inking.InkPresenter.StrokesErased
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler StrokesErased<Windows.UI.Input.Inking.InkPresenter,  Windows.UI.Input.Inking.InkStrokesErasedEventArgs>
-->

# Windows.UI.Input.Inking.InkPresenter.StrokesErased

## -description
Occurs when an [InkStroke](inkstroke.md) object is removed from an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control using the pen eraser or the pen tip when [Mode](inkinputprocessingconfiguration_mode.md) is set to [Erasing](inkinputprocessingmode.md).

## -remarks
[InkStrokeContainer.DeleteSelected](inkstrokecontainer_deleteselected.md) does not cause this event to fire.

This event is not raised in custom dry mode ([ActivateCustomDrying](inkpresenter_activatecustomdrying.md)).



> **Custom drying and the InkToolbar**
> By default, ink input is processed on a low-latency background thread and rendered "wet" as it is drawn. When the stroke is completed (pen or finger lifted, or mouse button released), the stroke is processed on the UI thread and rendered "dry" to the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) layer (above the application content and replacing the wet ink). The ink platform enables you to override this behavior and completely customize the inking experience by custom drying the ink input.

If your app overrides the default ink rendering behavior of the [InkPresenter](inkpresenter.md) with a custom drying implementation, the rendered ink strokes are no longer available to the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md) and the built-in erase commands of the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md) do not work as expected. To provide erase functionality, you must handle all pointer events, perform hit-testing on each stroke, and override the built-in "Erase all ink" command.

For more info on custom drying, see [Pen interactions and Windows Ink in UWP apps](https://msdn.microsoft.com/en-us/windows/uwp/input-and-devices/pen-and-stylus-interactions#custom-ink-rendering).

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)