---
-api-id: T:Windows.UI.Input.Inking.InkInputRightDragAction
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkInputRightDragAction : int
-->

# InkInputRightDragAction

## -description
Specifies how the [InkPresenter](inkpresenter.md) object handles input (standard and modified) from the associated [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control, when the input is modified with a secondary affordance, such as a pen barrel button, right mouse button, or similar.

By default, modified input is processed as standard input and rendered as an [InkStroke](inkstroke.md) (see remarks).

## -enum-fields
### -field LeaveUnprocessed:0
All input is [UnprocessedInput](inkpresenter_unprocessedinput.md). This passes all input through to the app for custom processing.

### -field AllowProcessing:1
All input is unmodified by a secondary affordance and is processed as standard ink input by the [InkPresenter](inkpresenter.md).


## -remarks
To pass input as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing, set [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) to **LeaveUnprocessed**.

If [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md) is set to [Inking](inkinputprocessingmode.md) or [Erasing](inkinputprocessingmode.md), the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) must be set to **LeaveUnprocessed** to pass input as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

If [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md) is set to [None](inkinputprocessingmode.md), the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) is ignored and input is always passed as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

## -examples

## -see-also
[Windows.UI.Input.Inking Enumerations](windows_ui_input_inking_enumerations.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)