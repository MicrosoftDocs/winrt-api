---
-api-id: M:Windows.UI.Input.Inking.IInkStrokeContainer.PasteFromClipboard(Windows.Foundation.Point)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Rect PasteFromClipboard(Windows.Foundation.Point position)
-->

# Windows.UI.Input.Inking.IInkStrokeContainer.PasteFromClipboard

## -description
Adds the [InkStroke](inkstroke.md) content from the clipboard to the [InkStroke](inkstroke.md) collection that is managed by the [InkStrokeContainer](inkstrokecontainer.md) and renders the new strokes.

## -parameters
### -param position
The screen coordinates for the upper-left corner of the bounding rectangle of the clipboard content.

## -returns
The invalidated bounding rectangle of the [InkStroke](inkstroke.md) collection.

## -remarks
The content of the clipboard must be in Ink Serialized Format (ISF) format.

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)