---
-api-id: E:Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource.WetStrokeCompleted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler WetStrokeCompleted<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource,  Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>
-->

# Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource.WetStrokeCompleted

## -description
Occurs after the [InkPresenter](../windows.ui.input.inking/inkpresenter.md) stops processing an ink stroke ([WetStrokeStopping](corewetstrokeupdatesource_wetstrokestopping.md)) or [CoreWetStrokeDisposition](corewetstrokedisposition.md) is set to [Completed](corewetstrokedisposition.md), indicating the stroke is complete.

Subsequent ink input is considered a new stroke.

## -remarks
An ink stroke always triggers either a WetStrokeCompleted or a [WetStrokeCanceled](corewetstrokeupdatesource_wetstrokecanceled.md) event.

[NewInkPoints](corewetstrokeupdateeventargs_newinkpoints.md) is always empty for the WetStrokeCompleted and [WetStrokeCanceled](corewetstrokeupdatesource_wetstrokecanceled.md) events.

[NewInkPoints](corewetstrokeupdateeventargs_newinkpoints.md) might be empty for the [WetStrokeStopping](corewetstrokeupdatesource_wetstrokestopping.md) event.

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Ink sample](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620314)
