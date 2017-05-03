---
-api-id: M:Windows.UI.Input.Inking.InkDrawingAttributes.#ctor
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public InkDrawingAttributes()
-->

# Windows.UI.Input.Inking.InkDrawingAttributes.InkDrawingAttributes

## -description
Creates a new [InkDrawingAttributes](inkdrawingattributes.md) object that is used to specify [InkStroke](inkstroke.md) attributes.

## -remarks

## -examples
The following example demonstrates how to create an [InkDrawingAttributes](inkdrawingattributes.md) object and set a default drawing attribute for all strokes managed by an [InkManager](inkmanager.md) object (`inkManager`).

```

var inkManager = new Windows.UI.Input.Inking.InkManager();
var drawingAttributes = new Windows.UI.Input.Inking.InkDrawingAttributes();
drawingAttributes.fitToCurve = true;
inkManager.setDefaultDrawingAttributes(drawingAttributes);

```



## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)