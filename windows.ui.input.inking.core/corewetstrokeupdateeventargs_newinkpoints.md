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
[NewInkPoints](corewetstrokeupdateeventargs_newinkpoints.md) is always empty for the [WetStrokeCompleted](corewetstrokeupdatesource_wetstrokecompleted.md) and [WetStrokeCanceled](corewetstrokeupdatesource_wetstrokecanceled.md) events.

[NewInkPoints](corewetstrokeupdateeventargs_newinkpoints.md) might be empty for the [WetStrokeStopping](corewetstrokeupdatesource_wetstrokestopping.md) event.

## -examples

## -see-also
[Pen and stylus interactions](https://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](https://go.microsoft.com/fwlink/p/?LinkID=620314)
