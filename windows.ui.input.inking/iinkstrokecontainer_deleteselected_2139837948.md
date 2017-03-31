---
-api-id: M:Windows.UI.Input.Inking.IInkStrokeContainer.DeleteSelected
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Rect DeleteSelected()
-->

# Windows.UI.Input.Inking.IInkStrokeContainer.DeleteSelected

## -description
Deletes the selected [InkStroke](inkstroke.md) objects from the [InkStroke](inkstroke.md) collection managed by the [InkStrokeContainer](inkstrokecontainer.md).

## -returns
The bounding rectangle of the selected ink strokes, or the invalidated rectangle (0, 0, 0, 0) if no strokes were removed (no selected strokes).

## -remarks
This method does not cause the [StrokesErased](inkpresenter_strokeserased.md) event to fire.

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)