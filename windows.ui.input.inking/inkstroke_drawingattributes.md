---
-api-id: P:Windows.UI.Input.Inking.InkStroke.DrawingAttributes
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Input.Inking.InkDrawingAttributes DrawingAttributes { get;  set; }
-->

# Windows.UI.Input.Inking.InkStroke.DrawingAttributes

## -description
Gets or sets the properties associated with an [InkStroke](inkstroke.md).

## -property-value
The drawing attributes.

## -remarks

## -examples
The following example demonstrates how to set a drawing attribute for a specific stroke.

> [!NOTE]
> You cannot set the [DrawingAttributes](inkstroke_drawingattributes.md) property of the stroke directly. You must create a copy of the [InkDrawingAttributes](inkdrawingattributes.md) of the stroke, set the desired values for that [InkDrawingAttributes](inkdrawingattributes.md) object, and then assign the new [InkDrawingAttributes](inkdrawingattributes.md) to the [DrawingAttributes](inkstroke_drawingattributes.md) of the stroke, as shown here.

```javascript
inkManager.getStrokes().forEach(function (stroke)
{
  var drawingAttributes = stroke.drawingAttributes;
  drawingAttributes.penTip = 
       Windows.UI.Input.Inking.PenTipShape.rectangle;
  stroke.drawingAttributes = drawingAttributes;
}
```

```csharp

// Get the InkStroke objects.
IReadOnlyList<InkStroke> inkStrokes = inkManager.GetStrokes();
Windows.UI.Input.Inking.InkStroke cloneStroke = 
  inkStrokes.GetAt(index).Clone();
Windows.UI.Input.Inking.InkDrawingAttributes drawingAttributes = 
  cloneStroke.DrawingAttributes;
drawingAttributes.PenTip = Windows.UI.Input.Inking.PenTipShape.Rectangle;
cloneStroke.DrawingAttributes = drawingAttributes;
```

For the complete example, see [Ink App sample](http://go.microsoft.com/fwlink/p/?linkid=231622).

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)