---
-api-id: M:Windows.UI.Input.Inking.InkStrokeBuilder.CreateStrokeFromInkPoints(Windows.Foundation.Collections.IIterable{Windows.UI.Input.Inking.InkPoint},Windows.Foundation.Numerics.Matrix3x2,Windows.Foundation.IReference{Windows.Foundation.DateTime},Windows.Foundation.IReference{Windows.Foundation.TimeSpan})
-api-type: winrt method
---

<!-- Method syntax.
public InkStroke InkStrokeBuilder.CreateStrokeFromInkPoints(IIterable<InkPoint> inkPoints, Matrix3x2 transform, IReference<DateTime> strokeStartedTime, IReference<TimeSpan> strokeDuration)
-->

# Windows.UI.Input.Inking.InkStrokeBuilder.CreateStrokeFromInkPoints

## -description
Creates a rich ink stroke from collection of [InkPoint](inkpoint.md) objects.

> [!NOTE]
> Use [CreateStrokeFromInkPoints](inkstrokebuilder_createstrokefrominkpoints.md) and [SetDefaultDrawingAttributes](inkstrokebuilder_setdefaultdrawingattributes.md) to programmatically build strokes for an [InkPresenter](inkpresenter.md).

## -parameters

### -param inkPoints
The collection of [InkPoint](inkpoint.md) objects.

### -param transform
A 2-D transformation matrix. Typically, this is just the [identity matrix](https://msdn.microsoft.com/en-us/library/system.numerics.matrix3x2.identity(v=vs.110).aspx).

### -param strokeStartedTime
The date and time when the InkStroke was started. 

### -param strokeDuration
Gets or sets the time taken by the user to draw a single ink stroke.

## -returns
The ink stroke, including the Bézier curve parameters used for final rendering of the stroke.

## -remarks

## -see-also
- [CreateStrokeFromInkPoints(Windows.Foundation.Collections.IIterable<Windows.UI.Input.Inking.InkPoint> inkPoints, Windows.Foundation.Numerics.Matrix3x2 transform)](inkstrokebuilder_createstrokefrominkpoints_712638281.md)
- [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43)
- [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308)
- [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312)
- [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)
## -examples

