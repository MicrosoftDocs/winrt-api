---
-api-id: T:Windows.UI.Input.PointerPointProperties
-api-type: winrt class
---

<!-- Class syntax.
public class PointerPointProperties : Windows.UI.Input.IPointerPointProperties, Windows.UI.Input.IPointerPointProperties2
-->

# Windows.UI.Input.PointerPointProperties

## -description
Provides extended properties for a [PointerPoint](pointerpoint.md) object.

In most cases, we recommend that you obtain pointer info through the pointer event handlers of your chosen Windows 8 language framework (Windows app using JavaScript, UWP app using C++, C#, or Visual Basic, or UWP app using DirectX with C++).

If the event argument doesn't expose the pointer details required by your app, you can get access to extended pointer data from the event argument through the [getCurrentPoint](XREF:TODO:wwa.MSPointerEvent_getCurrentPoint) and [getIntermediatePoints](XREF:TODO:wwa.MSPointerEvent_getIntermediatePoints) methods or [currentPoint](XREF:TODO:wwa.MSPointerEvent_currentPoint) and [intermediatePoints](XREF:TODO:ie.MSPointerEvent_intermediatePoints) properties. We recommend using the [getCurrentPoint](XREF:TODO:wwa.MSPointerEvent_getCurrentPoint) and [getIntermediatePoints](XREF:TODO:wwa.MSPointerEvent_getIntermediatePoints) methods as you can specify the context of the pointer data.

The static [PointerPoint](pointerpoint.md) methods, [GetCurrentPoint](pointerpoint_getcurrentpoint_131721878.md) and [GetIntermediatePoints](pointerpoint_getintermediatepoints_143894736.md), always use the context of the app.

## -remarks
The [PointerPointProperties](pointerpointproperties.md) class implements IPointerPointProperties.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

The core of the Microsoft interactive input device architecture is based on the Universal Serial Bus (USB) standard Device Class Definition for Human Interface Device (HID), which is defined by the [ Implementers Forum, Inc.](http://go.microsoft.com/fwlink/p/?linkid=233171)

The Universal Serial Bus (USB) Human Interface Device (HID) standard defines the configuration and communication protocols for Human Interface Device (HID), such as keyboards, mouse devices, joysticks, and virtual reality devices, that humans use to enter data directly into a computer. (For detailed information about the USB HID standard, see the [USB Implementers Forum](http://go.microsoft.com/fwlink/p/?linkid=233171) website.)

Although the core of the Windows input architecture is based on the Universal Serial Bus (USB) Human Interface Device (HID) standard, the architecture is not limited to Universal Serial Bus (USB) devices. The input architecture also supports serial port devices, i8042 port devices, and proprietary input devices.



## -examples
In the following example, we query various extended pointer properties using a [PointerPoint](pointerpoint.md) object.



[!code-js[QueryPointer](../windows.ui.input/code/PointerInput_JS_DOM/js/js/default.js#SnippetQueryPointer)]

[!code-js[QueryPointer](../windows.ui.input/code/PointerInput_JS_DOM/js/js/default.js#SnippetQueryPointer)]

[!code-js[QueryPointer](../windows.ui.input/code/PointerInput_Universal.Shared/js/default.js#SnippetQueryPointer)]

[!code-csharp[QueryPointer](../windows.ui.input.inking/code/PointerInput/csharp/MainPage.xaml.cs#SnippetQueryPointer)]

[!code-csharp[QueryPointer](../windows.ui.input.inking/code/PointerInput_UWP/csharp/MainPage.xaml.cs#SnippetQueryPointer)]

## -see-also
[Windows.UI.Input Classes](windows_ui_input_classes.md), [Windows.UI.Input.PointerPoint.properties](pointerpoint_properties.md), [Windows.Devices.Input](../windows.devices.input/windows_devices_input.md), [Windows.UI.Core](../windows.ui.core/windows_ui_core.md), [Windows.UI.Input](windows_ui_input.md), [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md), [Windows.UI.Xaml.Input](../windows.ui.xaml.input/windows_ui_xaml_input.md), [TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [Custom user interactions](http://msdn.microsoft.com/library/9403c46c-60da-4c13-a381-6fbd069dd9ce), [UX guidelines for custom user interactions](http://msdn.microsoft.com/library/52f9607d-e2d0-44e4-9e1c-f856f7072a1e), [Touch design guidelines](http://msdn.microsoft.com/library/3250f729-4fdd-4ad4-b856-b8ba575c3375), [User interaction mode sample](http://go.microsoft.com/fwlink/p/?LinkID=619894), [Focus visuals sample](http://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](http://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](http://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](http://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](http://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](http://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](http://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](http://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](http://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](http://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](http://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](http://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](http://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](http://go.microsoft.com/fwlink/p/?LinkID=267915)
soft.com/fwlink/p/?LinkID=267915)
