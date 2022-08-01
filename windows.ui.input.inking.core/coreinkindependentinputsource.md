---
-api-id: T:Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource
-api-type: winrt class
---

<!-- Class syntax.
public class CoreInkIndependentInputSource : Windows.UI.Input.Inking.Core.ICoreInkIndependentInputSource
-->

# Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource

## -description

Provides properties, methods, and events for handling pointer input prior to processing by an [InkPresenter](../windows.ui.input.inking/inkpresenter.md) object.

> [!IMPORTANT]
> These events occur on the ink background thread. For this reason, ensure any custom processing of ink input is as lightweight as possible to avoid degraded performance and to keep your app as responsive as possible.

## -remarks

Standard [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md) events occur after ink strokes have been rendered.

Use the [Windows.UI.Input.Inking.Core](windows_ui_input_inking_core.md) pointer events to intercept raw pointer data and suppress, or cancel, ink rendering at any point along a stroke. This can be useful when protecting existing ink strokes or providing custom gesture support, such as press and hold, without creating ink artifacts.

Input from various devices (including touch, pen, and mouse) is received, processed, and managed as pointer input. User interactions from any of these devices can produce the following events. For more info, see [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input).

## -examples

## -see-also

[Windows.UI.Input.Inking.Core classes](windows_ui_input_inking_core.md), [Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Ink sample](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620314)
