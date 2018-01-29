---
-api-id: T:Windows.UI.Input.Inking.InkStrokesErasedEventArgs
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkStrokesErasedEventArgs : Windows.UI.Input.Inking.IInkStrokesErasedEventArgs
-->

# Windows.UI.Input.Inking.InkStrokesErasedEventArgs

## -description
Contains event data for the [StrokesErased](inkpresenter_strokeserased.md) event of the [InkPresenter](inkpresenter.md) associated with an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

By default, ink stroke data and rendering is managed entirely by the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control. However, this behavior can be overridden by calling the [ActivateCustomDrying](inkpresenter_activatecustomdrying.md) method prior to loading the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md).

## -remarks
The [StrokesErased](inkpresenter_strokeserased.md) event is not raised in custom dry mode ([ActivateCustomDrying](inkpresenter_activatecustomdrying.md)).

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)