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
The PointerPointProperties class implements IPointerPointProperties.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

The core of the Microsoft interactive input device architecture is based on the Universal Serial Bus (USB) standard Device Class Definition for Human Interface Device (HID), which is defined by the [ Implementers Forum, Inc.](https://www.usb.org/home)

The Universal Serial Bus (USB) Human Interface Device (HID) standard defines the configuration and communication protocols for Human Interface Device (HID), such as keyboards, mouse devices, joysticks, and virtual reality devices, that humans use to enter data directly into a computer. (For detailed information about the USB HID standard, see the [USB Implementers Forum](https://www.usb.org/home) website.)

Although the core of the Windows input architecture is based on the Universal Serial Bus (USB) Human Interface Device (HID) standard, the architecture is not limited to Universal Serial Bus (USB) devices. The input architecture also supports serial port devices, i8042 port devices, and proprietary input devices.



## -examples
In the following example, we query various extended pointer properties using a [PointerPoint](pointerpoint.md) object.

[!code-csharp[QueryPointer](../windows.ui.input.inking/code/PointerInput/csharp/MainPage.xaml.cs#SnippetQueryPointer)]

[!code-csharp[QueryPointer](../windows.ui.input.inking/code/PointerInput_UWP/csharp/MainPage.xaml.cs#SnippetQueryPointer)]

## -see-also
[Windows.UI.Input Classes](windows_ui_input_classes.md), [Windows.UI.Input.PointerPoint.properties](pointerpoint_properties.md), [Windows.Devices.Input](../windows.devices.input/windows_devices_input.md), [Windows.UI.Core](../windows.ui.core/windows_ui_core.md), [Windows.UI.Input](windows_ui_input.md), [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md), [Windows.UI.Xaml.Input](../windows.ui.xaml.input/windows_ui_xaml_input.md), [TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [Custom user interactions](/windows/uwp/design/layout/index), [UX guidelines for custom user interactions](/windows/uwp/design/layout/index), [Touch design guidelines](/windows/uwp/input-and-devices/guidelines-for-user-interaction), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Input%20Device%20capabilities%20sample), [Input: Simplified ink  sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Input%20Simplified%20ink%20sample), [Input: Windows 8 gestures sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%23%5D-Windows%208%20app%20samples/C%23/Windows%208%20app%20samples/Input%20Windows%208%20gestures%20sample%20(Windows%208)/C%23), [Input: XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample), [XAML scrolling, panning, and zooming sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/XAML%20scrolling%2C%20panning%2C%20and%20zooming%20sample), [DirectX touch input sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/DirectX%20touch%20input%20sample%20(Windows%208)/C%2B%2B), [Input: Manipulations and gestures (C++) sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Input%20Manipulations%20and%20gestures%20(C%2B%2B)%20sample%20(Windows%208)/C%2B%2B), [Input: Touch hit testing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Input%20Touch%20hit%20testing%20sample%20(Windows%208)/C%2B%2B), [Input source identification sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20desktop%20samples/%5BC%2B%2B%5D-Windows%208%20desktop%20samples/C%2B%2B/Windows%208%20desktop%20samples/Input%20Source%20identification%20sample/C%2B%2B), [Touch injection sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Input%20Touch%20injection%20sample), [Win32 touch hit-testing sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/21cb9b6bc0da3b234c5854ecac449cb3bd261f29/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Input%20Touch%20hit%20testing%20sample%20(Windows%208)/C%2B%2B)
