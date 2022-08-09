---
-api-id: E:Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource.WetStrokeCanceled
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler WetStrokeCanceled<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource,  Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>
-->

# Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource.WetStrokeCanceled

## -description
Occurs when the [InkPresenter](../windows.ui.input.inking/inkpresenter.md) stops processing an ink stroke in an unexpected way, [CoreWetStrokeDisposition](corewetstrokedisposition.md) is set to [Canceled](corewetstrokedisposition.md), or the input is invalid, indicating the stroke was not completed.

For example, when ink input bubbles up to another system event handler, such as a context menu.

## -remarks
An ink stroke always triggers either a [WetStrokeCompleted](corewetstrokeupdatesource_wetstrokecompleted.md) or a WetStrokeCanceled event.

[NewInkPoints](corewetstrokeupdateeventargs_newinkpoints.md) is always empty for the [WetStrokeCompleted](corewetstrokeupdatesource_wetstrokecompleted.md) and WetStrokeCanceled events.

[NewInkPoints](corewetstrokeupdateeventargs_newinkpoints.md) might be empty for the [WetStrokeStopping](corewetstrokeupdatesource_wetstrokestopping.md) event.

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Ink sample](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620314)
