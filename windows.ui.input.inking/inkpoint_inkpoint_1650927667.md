---
-api-id: M:Windows.UI.Input.Inking.InkPoint.#ctor(Windows.Foundation.Point,System.Single,System.Single,System.Single,System.UInt64)
-api-type: winrt method
---

<!-- Method syntax
public InkPoint(Windows.Foundation.Point position, System.Single pressure, System.Single tiltX, System.Single tiltY, System.UInt64 timestamp)
-->

# Windows.UI.Input.Inking.InkPoint.InkPoint

## -description
Creates a complex [InkPoint](inkpoint.md) object used in the construction of an [InkStroke](inkstroke.md).

## -parameters
### -param position
The screen coordinates for the [InkPoint](inkpoint.md) object.

### -param pressure
The pressure of the contact on the digitizer surface. The default is 0.5.

### -param tiltX
The plane angle between the Y-Z plane and the plane containing the Y axis and the axis of the input device. The default is 0.

### -param tiltY
The plane angle between the X-Z plane and the plane containing the X axis and the axis of the input device. The default is 0.

### -param timestamp
The timestamp for the first [InkPoint](inkpoint.md) of an InkStroke, or when an entire InkStroke is pasted or loaded. 

## -remarks

## -examples

## -see-also
- [InkPoint(Windows.Foundation.Point position, System.Single pressure)](inkpoint_inkpoint_1903734527.md)
- [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43)
- [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)