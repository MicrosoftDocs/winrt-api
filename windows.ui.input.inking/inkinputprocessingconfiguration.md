---
-api-id: T:Windows.UI.Input.Inking.InkInputProcessingConfiguration
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkInputProcessingConfiguration : Windows.UI.Input.Inking.IInkInputProcessingConfiguration
-->

# Windows.UI.Input.Inking.InkInputProcessingConfiguration

## -description
Provides properties for managing the input behavior (standard or modified) of the [InkPresenter](inkpresenter.md) object.

Standard ink input is not modified with a secondary affordance, such as a pen barrel button, right mouse button, or similar.

By default, modified input is processed as standard input and rendered as an [InkStroke](inkstroke.md). You must set [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) to [LeaveUnprocessed](inkinputrightdragaction.md) to pass the input through as [UnprocessedInput](inkpresenter_unprocessedinput.md) for custom processing by your app.

## -remarks
If [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md) is set to [None](inkinputprocessingmode.md), the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) is ignored and input is always passed as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

If [InkInputProcessingConfiguration.Mode](inkinputprocessingconfiguration_mode.md) is set to [Inking](inkinputprocessingmode.md) or [Erasing](inkinputprocessingmode.md), the value of [RightDragAction](inkinputprocessingconfiguration_rightdragaction.md) must be set to [LeaveUnprocessed](inkinputrightdragaction.md) to pass input as [UnprocessedInput](inkpresenter_unprocessedinput.md) through to your app for custom processing.

## -examples

## -see-also
[Windows.UI.Input.Inking Classes](windows_ui_input_inking_classes.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)