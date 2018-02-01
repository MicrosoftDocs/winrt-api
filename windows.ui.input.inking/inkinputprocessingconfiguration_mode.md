---
-api-id: P:Windows.UI.Input.Inking.InkInputProcessingConfiguration.Mode
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Input.Inking.InkInputProcessingMode Mode { get;  set; }
-->

# Windows.UI.Input.Inking.InkInputProcessingConfiguration.Mode

## -description
Gets or sets how the [InkPresenter](inkpresenter.md) object renders secondrary input from a pen barrel button, pen eraser tip, right mouse button, or similar on its associated [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

By default, this secondary input is processed as primary input and rendered as an [InkStroke](inkstroke.md) (see remarks).

## -property-value
The input behavior.

## -remarks
To pass input as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing, set [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) to [LeaveUnprocessed](inkinputrightdragaction.md).

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)