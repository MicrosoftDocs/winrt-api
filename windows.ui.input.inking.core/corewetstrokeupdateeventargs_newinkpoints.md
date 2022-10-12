---
-api-id: P:Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs.NewInkPoints
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Input.Inking.InkPoint> NewInkPoints { get; }
-->

# Windows.UI.Input.Inking.Core.CoreWetStrokeUpdateEventArgs.NewInkPoints

## -description
Gets the collection of [InkPoint](../windows.ui.input.inking/inkpoint.md) objects processed since the last event.

## -property-value
The collection of [InkPoint](../windows.ui.input.inking/inkpoint.md) objects.

## -remarks
NewInkPoints is always empty for the [WetStrokeCompleted](corewetstrokeupdatesource_wetstrokecompleted.md) and [WetStrokeCanceled](corewetstrokeupdatesource_wetstrokecanceled.md) events.

NewInkPoints might be empty for the [WetStrokeStopping](corewetstrokeupdatesource_wetstrokestopping.md) event.

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Ink sample](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Simple ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620314)
