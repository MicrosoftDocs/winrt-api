---
-api-id: P:Windows.UI.Input.Inking.InkDrawingAttributes.FitToCurve
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool FitToCurve { get;  set; }
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.FitToCurve

## -description
Gets or sets a value that indicates whether a Bezier curve or a collection of straight line segments is used to draw an [InkStroke](inkstroke.md).

## -property-value
**true** if a Bezier curve is used; otherwise **false**. The default value is **true**.

## -remarks

## -examples
The following example demonstrates how to set the [FitToCurve](inkdrawingattributes_fittocurve.md) attribute for all strokes managed by this [InkManager](inkmanager.md) object (`inkManager`) that are created after the [SetDefaultDrawingAttributes](inkmanager_setdefaultdrawingattributes.md) method call.

```

var inkManager = new Windows.UI.Input.Inking.InkManager();
var drawingAttributes = 
     new Windows.UI.Input.Inking.InkDrawingAttributes();
// True is the Default value for fitToCurve.
drawingAttributes.fitToCurve = false;
inkManager.setDefaultDrawingAttributes(drawingAttributes);

```

For the complete example, see [Ink App sample](http://go.microsoft.com/fwlink/p/?linkid=231622).

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)
