---
-api-id: E:Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource.WetStrokeStopping
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler WetStrokeStopping<Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource,  Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs>
-->

# Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateSource.WetStrokeStopping

## -description
Occurs when the [InkPresenter](../windows.ui.input.inking/inkpresenter.md) stops processing an ink stroke, but before the stroke is finalized ([WetStrokeCompleted](corewetstrokeupdatesource_wetstrokecompleted.md)).

## -remarks
[NewInkPoints](corewetstrokeupdateeventargs_newinkpoints.md) is always empty for the [WetStrokeCompleted](corewetstrokeupdatesource_wetstrokecompleted.md) and [WetStrokeCanceled](corewetstrokeupdatesource_wetstrokecanceled.md) events.

[NewInkPoints](corewetstrokeupdateeventargs_newinkpoints.md) might be empty for the WetStrokeStopping event.

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Ink sample](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620314)
