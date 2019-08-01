---
-api-id: T:Windows.UI.Input.MouseWheelParameters
-api-type: winrt class
---

<!-- Class syntax.
public class MouseWheelParameters : Windows.UI.Input.IMouseWheelParameters
-->

# Windows.UI.Input.MouseWheelParameters

## -description

Provides properties associated with the button wheel of a mouse device.

## -remarks

The properties exposed through MouseWheelParameters are used in conjunction with the **Wheel** settings in the **Mouse** control panel to define the UI experience when using the button wheel.

The mouse wheel button has discrete, evenly spaced notches or distance thresholds (also called detents). When you rotate or tilt the wheel, a wheel message is sent as each detent is encountered.

> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

## -see-also

[Windows.UI.Input Classes](windows_ui_input_classes.md), [Windows.UI.Input.GestureRecognizer.mouseWheelParameters](gesturerecognizer_mousewheelparameters.md), [Windows.Devices.Input](../windows.devices.input/windows_devices_input.md), [Windows.UI.Core](../windows.ui.core/windows_ui_core.md), [Windows.UI.Input](windows_ui_input.md), [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md), [Windows.UI.Xaml.Input](../windows.ui.xaml.input/windows_ui_xaml_input.md), [TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [Custom user interactions](https://docs.microsoft.com/windows/uwp/design/layout/index), [UX guidelines for custom user interactions](https://docs.microsoft.com/windows/uwp/design/layout/index), [Touch design guidelines](https://docs.microsoft.com/windows/uwp/input-and-devices/guidelines-for-user-interaction), [User interaction mode sample](https://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](https://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](https://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](https://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](https://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](https://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](https://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](https://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](https://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](https://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](https://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](https://go.microsoft.com/fwlink/p/?LinkID=267915)
