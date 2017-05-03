---
-api-id: P:Windows.UI.Input.Inking.InkPresenter.UnprocessedInput
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Input.Inking.InkUnprocessedInput UnprocessedInput { get; }
-->

# Windows.UI.Input.Inking.InkPresenter.UnprocessedInput

## -description
Gets input (standard or modified) from the associated [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control and passes the data through for custom processing by the app. The data is not processed by the [InkPresenter](inkpresenter.md).

> [!NOTE]
> Standard input is not modified with a secondary affordance, such as a pen barrel button, right mouse button, or similar.

Use [InkInputProcessingConfiguration](inkinputprocessingconfiguration.md) to indicate the input to be passed as [InkUnprocessedInput](inkunprocessedinput.md) through to your app for custom processing.

## -property-value
The input from the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)