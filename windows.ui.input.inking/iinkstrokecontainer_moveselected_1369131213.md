---
-api-id: M:Windows.UI.Input.Inking.IInkStrokeContainer.MoveSelected(Windows.Foundation.Point)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Rect MoveSelected(Windows.Foundation.Point translation)
-->

# Windows.UI.Input.Inking.IInkStrokeContainer.MoveSelected

## -description
Moves the selected strokes. All affected strokes are re-rendered.

## -parameters
### -param translation
The destination screen coordinates for the upper-left corner of the bounding rectangle of the selected strokes.

## -returns
The bounding rectangle of the selected ink strokes.

## -remarks
The following can result from a call to [MoveSelected](inkstrokecontainer_moveselected.md):
+ Moving one or more strokes that make up part of a word results in the reprocessing of existing ink recognition results.
+ Moving all strokes that make up a word results in the recalculation of the [BoundingRect](inkrecognitionresult_boundingrect.md) of the [InkRecognitionResult](inkrecognitionresult.md). Ink recognition is not reprocessed.
+ Moving one or more strokes results in the recalculation of the [BoundingRect](inkstroke_boundingrect.md) for each stroke.
+ Moving one or more strokes results in the recalculation of the [BoundingRect](inkstrokecontainer_boundingrect.md) of the [InkStrokeContainer](inkstrokecontainer.md).


## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)