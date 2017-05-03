---
-api-id: M:Windows.UI.Input.Inking.InkStrokeBuilder.SetDefaultDrawingAttributes(Windows.UI.Input.Inking.InkDrawingAttributes)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetDefaultDrawingAttributes(Windows.UI.Input.Inking.InkDrawingAttributes drawingAttributes)
-->

# Windows.UI.Input.Inking.InkStrokeBuilder.SetDefaultDrawingAttributes

## -description
Sets the default [InkDrawingAttributes](inkdrawingattributes.md) for all new ink strokes created after the current stroke.

[SetDefaultDrawingAttributes](inkstrokebuilder_setdefaultdrawingattributes.md) does not affect the current stroke, or any existing strokes.

> [!NOTE]
> Use [SetDefaultDrawingAttributes](inkstrokebuilder_setdefaultdrawingattributes.md) when programmatically building strokes for both [InkPresenter](inkpresenter.md) and [InkManager](inkmanager.md) objects.

## -parameters
### -param drawingAttributes
The default attributes.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)