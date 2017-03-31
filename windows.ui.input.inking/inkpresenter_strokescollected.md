---
-api-id: E:Windows.UI.Input.Inking.InkPresenter.StrokesCollected
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler StrokesCollected<Windows.UI.Input.Inking.InkPresenter,  Windows.UI.Input.Inking.InkStrokesCollectedEventArgs>
-->

# Windows.UI.Input.Inking.InkPresenter.StrokesCollected

## -description
Occurs when one or more ink strokes are processed ("wet" to "dry") by the application thread.

By default, an ink stroke is processed on a low-latency background thread and rendered wet as it is drawn. When the stroke is completed (pen or finger lifted, or mouse button released), the stroke is processed on the UI thread and rendered dry to the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) layer (above the application content). If the UI thread is busy, more than one ink stroke might be processed (collected) when the thread becomes available.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)