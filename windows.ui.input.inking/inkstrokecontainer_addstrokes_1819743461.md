---
-api-id: M:Windows.UI.Input.Inking.InkStrokeContainer.AddStrokes(Windows.Foundation.Collections.IIterable{Windows.UI.Input.Inking.InkStroke})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void AddStrokes(Windows.Foundation.Collections.IIterable<Windows.UI.Input.Inking.InkStroke> strokes)
-->

# Windows.UI.Input.Inking.InkStrokeContainer.AddStrokes

## -description
Adds one or more ink strokes to the collection managed by the [InkStrokeContainer](inkstrokecontainer.md).

> An [InkStroke](inkstroke.md) cannot exist in more than one [InkStrokeContainer](inkstrokecontainer.md). Call the [Clone](inkstroke_clone.md) method to duplicate a stroke in another container.

## -parameters
### -param strokes
The ink strokes to be added as a collection of [InkStroke](inkstroke.md) objects.Each *stroke* must be created using the [Clone](inkstroke_clone.md) method, or through a call to [EndStroke](inkstrokebuilder_endstroke.md) or [ProcessPointerUp](inkmanager_processpointerup.md). Empty or existing strokes are not valid.

## -remarks

## -examples

## -see-also
[InkStroke](inkstroke.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)