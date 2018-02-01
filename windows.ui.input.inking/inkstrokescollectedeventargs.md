---
-api-id: T:Windows.UI.Input.Inking.InkStrokesCollectedEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkStrokesCollectedEventArgs : Windows.UI.Input.Inking.IInkStrokesCollectedEventArgs
-->

# Windows.UI.Input.Inking.InkStrokesCollectedEventArgs

## -description
Contains event data for the [StrokesCollected](inkpresenter_strokescollected.md) event of the [InkPresenter](inkpresenter.md) associated with an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

By default, an ink stroke is processed on a low-latency background thread and rendered wet as it is drawn. When the stroke is completed (pen or finger lifted, or mouse button released), the stroke is processed on the UI thread and rendered dry to the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) layer (above the application content). If the UI thread is busy, more than one ink stroke might be processed (collected) when the thread becomes available.

This behavior can be overridden by calling the [ActivateCustomDrying](inkpresenter_activatecustomdrying.md) method prior to loading the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)