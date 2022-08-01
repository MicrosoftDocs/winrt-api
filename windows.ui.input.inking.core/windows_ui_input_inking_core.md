---
-api-id: N:Windows.UI.Input.Inking.Core
-api-type: winrt namespace
---

# Windows.UI.Input.Inking.Core

## -description
Overrides default [InkPresenter](../windows.ui.input.inking/inkpresenter.md) run-time behavior to provide advanced input, processing, and management support for Windows Ink apps.

The Windows.UI.Input.Inking.Core APIs enable you to:
+ Handle ink stroke events and pointer events before standard [InkPresenter](../windows.ui.input.inking/inkpresenter.md) events, which occur after ink strokes have been rendered.
+ Intercept raw pointer data and suppress, or cancel, ink rendering at any point along a stroke. This can be useful when protecting existing ink strokes or providing custom gesture support, such as press and hold, without creating ink artifacts. 
+ Control the rendering path of an ink stroke. This can be useful for auto-correcting a user's stroke or masking areas of the drawing surface.
+ Draw ink strokes incrementally using individual [InkPoint](../windows.ui.input.inking/inkpoint.md) objects.

> [!IMPORTANT]
> Windows.UI.Input.Inking.Core processing occurs on the ink background thread. For this reason, ensure any custom processing of ink input is as lightweight as possible to avoid degraded performance and to keep your app as responsive as possible.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Ink sample](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620314)
