---
-api-id: M:Windows.UI.Input.Inking.IInkPointFactory.CreateInkPoint(Windows.Foundation.Point,System.Single)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.Inking.InkPoint CreateInkPoint(Windows.Foundation.Point position, System.Single pressure)
-->

# Windows.UI.Input.Inking.IInkPointFactory.CreateInkPoint

## -description
Generates an [InkPoint](inkpoint.md) object that includes position and pressure information used in the construction of an [InkStroke](inkstroke.md).

## -parameters
### -param position
The screen coordinates for the [InkPoint](inkpoint.md) object.

### -param pressure
The pressure of the contact on the digitizer surface. The default is 0.5.

## -returns
A single point.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)