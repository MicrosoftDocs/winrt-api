---
-api-id: P:Windows.UI.Input.Inking.InkModelerAttributes.PredictionTime
-api-type: winrt property
---

<!-- Property syntax.
public TimeSpan PredictionTime { get;  set; }
-->

# Windows.UI.Input.Inking.InkModelerAttributes.PredictionTime

## -description
Gets or sets the amount of time into the future used to predict the expected location of the input pointer.

## -property-value
The time in milliseconds. The default is 15 ms, with a valid range between 0 to 20 ms.

The InkPresenter attempts to use 15ms when conditions are most favorable. When conditions are less favorable, such as a period of high acceleration, some fraction of that time is used.

## -remarks

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)

## -examples

