---
-api-id: M:Windows.UI.Input.Inking.IInkStrokeContainer.AddStroke(Windows.UI.Input.Inking.InkStroke)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void AddStroke(Windows.UI.Input.Inking.InkStroke stroke)
-->

# Windows.UI.Input.Inking.IInkStrokeContainer.AddStroke

## -description
Adds an [InkStroke](inkstroke.md) object to the collection managed by the [InkStrokeContainer](inkstrokecontainer.md).

## -parameters
### -param stroke
The ink stroke to be added.

*stroke* must be created by using the [Clone](inkstroke_clone.md) method, or through a call to [EndStroke](inkstrokebuilder_endstroke.md) or [ProcessPointerUp](inkmanager_processpointerup.md). Empty or existing strokes are not valid.

## -remarks
The [StrokesCollected](inkpresenter_strokescollected.md) event is fired when ink strokes are processed ("wet" to "dry") on the UI thread.

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)