---
-api-id: T:Windows.UI.Input.Inking.InkInputProcessingMode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkInputProcessingMode : int
-->

# InkInputProcessingMode

## -description
Specifies how the [InkPresenter](inkpresenter.md) object handles input (standard and modified) from the associated [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control.

> [!NOTE]
> Standard input is not modified with a secondary affordance, such as a pen barrel button, right mouse button, or similar.

Input can be handled as standard ink or erase strokes, or it can be passed as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

## -enum-fields
### -field None:0
All input events (standard and modified) are passed to the app and are not processed by the [InkPresenter](inkpresenter.md).

### -field Inking:1
Input is treated as ink.

### -field Erasing:2
Input is treated as erase.


## -remarks
If [Mode](inkinputprocessingconfiguration_mode.md) is set to **None**, the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) is ignored and input is always passed as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

If [Mode](inkinputprocessingconfiguration_mode.md) is set to **Inking** or **Erasing**, the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) must be set to [LeaveUnprocessed](inkinputrightdragaction.md) to pass input as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

## -examples

## -see-also
[Windows.UI.Input.Inking Enumerations](windows_ui_input_inking_enumerations.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)