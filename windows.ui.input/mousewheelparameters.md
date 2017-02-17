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
The properties exposed through [MouseWheelParameters](mousewheelparameters.md) are used in conjunction with the **Wheel** settings in the **Mouse** control panel to define the UI experience when using the button wheel.

The mouse wheel button has discrete, evenly spaced notches or distance thresholds (also called detents). When you rotate or tilt the wheel, a wheel message is sent as each detent is encountered.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

## -see-also
[Windows.UI.Input Classes](windows_ui_input_classes.md), [Windows.UI.Input.GestureRecognizer.mouseWheelParameters](gesturerecognizer_mousewheelparameters.md), [Windows.Devices.Input](../windows.devices.input/windows_devices_input.md), [Windows.UI.Core](../windows.ui.core/windows_ui_core.md), [Windows.UI.Input](windows_ui_input.md), [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md), [Windows.UI.Xaml.Input](../windows.ui.xaml.input/windows_ui_xaml_input.md), [TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [Custom user interactions](http://msdn.microsoft.com/library/9403c46c-60da-4c13-a381-6fbd069dd9ce), [UX guidelines for custom user interactions](http://msdn.microsoft.com/library/52f9607d-e2d0-44e4-9e1c-f856f7072a1e), [Touch design guidelines](http://msdn.microsoft.com/library/3250f729-4fdd-4ad4-b856-b8ba575c3375), [User interaction mode sample](http://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](http://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](http://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](http://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](http://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](http://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](http://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](http://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](http://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](http://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](http://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](http://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](http://go.microsoft.com/fwlink/p/?LinkID=267915)