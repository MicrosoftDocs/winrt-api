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
Gets or sets how the [InkPresenter](inkpresenter.md) object handles input (standard and modified) on its associated [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

> [!NOTE]
> Standard input is not modified with a secondary affordance, such as a pen barrel button, right mouse button, or similar.

Input can be handled as standard ink or erase strokes, or it can be passed as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

## -property-value
The input behavior.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)