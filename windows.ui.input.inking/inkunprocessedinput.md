---
-api-id: T:Windows.UI.Input.Inking.InkUnprocessedInput
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class InkUnprocessedInput : Windows.UI.Input.Inking.IInkUnprocessedInput
-->

# Windows.UI.Input.Inking.InkUnprocessedInput

## -description
Provides properties and events for custom processing of ink data from an [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control. The data is not processed by the [InkPresenter](inkpresenter.md).

Use [InkInputProcessingConfiguration](inkinputprocessingconfiguration.md) to identify the data to pass through as [UnprocessedInput](inkpresenter_unprocessedinput.md).

## -remarks
Input from various devices (including touch, pen, and mouse) is received, processed, and managed as pointer input. User interactions based on any of these devices can produce a [PointerEntered](inkunprocessedinput_pointerentered.md), [PointerExited](inkunprocessedinput_pointerexited.md), [PointerReleased](inkunprocessedinput_pointerreleased.md), [PointerPressed](inkunprocessedinput_pointerpressed.md), [PointerMoved](inkunprocessedinput_pointermoved.md), [PointerLost](inkunprocessedinput_pointerlost.md), or [PointerHovered](inkunprocessedinput_pointerhovered.md), event. For more info, see [Handle pointer input](http://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82).

## -examples

## -see-also
[Windows.UI.Input.Inking Classes](windows_ui_input_inking_classes.md), [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)