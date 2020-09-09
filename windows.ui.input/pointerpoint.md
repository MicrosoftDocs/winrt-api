---
-api-id: T:Windows.UI.Input.PointerPoint
-api-type: winrt class
---

<!-- Class syntax.
public class PointerPoint : Windows.UI.Input.IPointerPoint
-->

# Windows.UI.Input.PointerPoint

## -description

Provides basic properties for the input pointer associated with a single mouse, pen/stylus, or touch contact.

## -remarks

The PointerPoint class implements IPointerPoint.

See [PointerPointProperties](pointerpointproperties.md) for extended properties accessible through [Properties](pointerpoint_properties.md).

In most cases, we recommend that you get pointer info through the event argument of the pointer event handlers in your chosen language framework (Windows app using JavaScript, UWP app using C++, C#, or Visual Basic, or UWP app using DirectX with C++).

If the event argument doesn't intrinsically expose the pointer details required by your app, you can get access to extended pointer data through the [GetCurrentPoint](../windows.ui.xaml/input/pointerroutedeventargs_getcurrentpoint_1761708789.md) and [GetIntermediatePoints](../windows.ui.xaml/input/pointerroutedeventargs_getintermediatepoints_1716242609.md) methods of [PointerRoutedEventArgs](../windows.ui.xaml/input/pointerroutedeventargs.md). Use these methods to specify the context of the pointer data.

The static PointerPoint methods, [GetCurrentPoint](pointerpoint_getcurrentpoint_131721878.md) and [GetIntermediatePoints](pointerpoint_getintermediatepoints_143894736.md), always use the app context.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

In the following example, we query various pointer properties using a PointerPoint object.

[!code-js[QueryPointer](../windows.ui.input/code/PointerInput_JS_DOM/js/js/default.js#SnippetQueryPointer)]

[!code-js[QueryPointer](../windows.ui.input/code/PointerInput_JS_DOM/js/js/default.js#SnippetQueryPointer)]

[!code-js[QueryPointer](../windows.ui.input/code/PointerInput_Universal.Shared/js/default.js#SnippetQueryPointer)]

[!code-csharp[QueryPointer](../windows.ui.input.inking/code/PointerInput/csharp/MainPage.xaml.cs#SnippetQueryPointer)]

[!code-csharp[QueryPointer](../windows.ui.input.inking/code/PointerInput_UWP/csharp/MainPage.xaml.cs#SnippetQueryPointer)]

## -see-also

[Windows.UI.Input Classes](windows_ui_input_classes.md), [Windows.Devices.Input](../windows.devices.input/windows_devices_input.md), [Windows.UI.Core](../windows.ui.core/windows_ui_core.md), [Windows.UI.Input](windows_ui_input.md), [Windows.UI.Input.Inking](../windows.ui.input.inking/windows_ui_input_inking.md), [Windows.UI.Xaml.Input](../windows.ui.xaml.input/windows_ui_xaml_input.md), [TypedEventHandler](../windows.foundation/typedeventhandler_2.md), [Custom user interactions](/windows/uwp/design/layout/index), [UX guidelines for custom user interactions](/windows/uwp/design/layout/index), [Touch design guidelines](/windows/uwp/input-and-devices/guidelines-for-user-interaction), [User interaction mode sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/UserInteractionMode), [Focus visuals sample](https://go.microsoft.com/fwlink/p/?LinkID=619895), [Input: Device capabilities sample](https://go.microsoft.com/fwlink/p/?linkid=231530), [Input: Ink sample](https://go.microsoft.com/fwlink/p/?linkid=231622), [Input: Manipulations and gestures (JavaScript) sample](https://go.microsoft.com/fwlink/p/?linkid=231638), [Input: Simplified ink  sample](https://go.microsoft.com/fwlink/p/?linkid=246570), [Input: Windows 8 gestures sample](https://go.microsoft.com/fwlink/p/?LinkId=264995), [Input: XAML user input events sample](https://go.microsoft.com/fwlink/p/?linkid=226855), [XAML scrolling, panning, and zooming sample](https://go.microsoft.com/fwlink/p/?linkid=251717), [DirectX touch input sample](https://go.microsoft.com/fwlink/p/?LinkID=231627), [Input: Manipulations and gestures (C++) sample](https://go.microsoft.com/fwlink/p/?linkid=231605), [Input: Touch hit testing sample](https://go.microsoft.com/fwlink/p/?linkid=231590), [Input source identification sample](https://go.microsoft.com/fwlink/p/?LinkID=267908), [Touch injection sample](https://go.microsoft.com/fwlink/p/?LinkID=267906), [Win32 touch hit-testing sample](https://go.microsoft.com/fwlink/p/?LinkID=267915), [Basic input sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620514)
soft.com/fwlink/p/?LinkId=620514)
