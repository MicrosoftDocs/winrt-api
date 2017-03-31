---
-api-id: P:Windows.UI.Input.Inking.InkPresenter.StrokeContainer
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Input.Inking.InkStrokeContainer StrokeContainer { get;  set; }
-->

# Windows.UI.Input.Inking.InkPresenter.StrokeContainer

## -description
Gets or sets an [InkStrokeContainer](inkstrokecontainer.md) object to store and manage the collection of [InkStroke](inkstroke.md) objects rendered by the [InkPresenter](inkpresenter.md).

Modifications made to any of the ink strokes in the stroke container are immediately rendered to the drawing surface associated with the [InkPresenter](inkpresenter.md).

## -property-value
Stores and manages one or more [InkStroke](inkstroke.md) objects.

If custom dry mode is enabled ([ActivateCustomDrying](inkpresenter_activatecustomdrying.md)), [StrokeContainer](inkpresenter_strokecontainer.md) is null.

## -remarks
The [StrokesCollected](inkpresenter_strokescollected.md) event is fired when ink strokes are processed ("wet" to "dry") on the UI thread.

For ink recognition, use an [InkRecognizerContainer](inkrecognizercontainer.md) object.

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)