---
-api-id: M:Windows.UI.Input.Inking.InkStrokeBuilder.CreateStroke(Windows.Foundation.Collections.IIterable{Windows.Foundation.Point})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Input.Inking.InkStroke CreateStroke(Windows.Foundation.Collections.IIterable<Windows.Foundation.Point> points)
-->

# Windows.UI.Input.Inking.InkStrokeBuilder.CreateStroke

## -description
Creates a stroke from an array of [Point](../windows.foundation/point.md) coordinates.

> [!NOTE]
> [CreateStroke](inkstrokebuilder_createstroke.md) is not supported by [InkPresenter](inkpresenter.md). Use [CreateStrokeFromInkPoints](inkstrokebuilder_createstrokefrominkpoints.md) and [SetDefaultDrawingAttributes](inkstrokebuilder_setdefaultdrawingattributes.md) to programmatically build strokes for an [InkPresenter](inkpresenter.md).

## -parameters
### -param points
An array of [Point](../windows.foundation/point.md) coordinates.

## -returns
The new stroke.

## -remarks

## -examples

## -see-also
[Point](../windows.foundation/point.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)