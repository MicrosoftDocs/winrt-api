---
-api-id: M:Windows.UI.Xaml.UIElement.CapturePointer(Windows.UI.Xaml.Input.Pointer)
-api-type: winrt method
---

<!-- Method syntax
public bool CapturePointer(Windows.UI.Xaml.Input.Pointer value)
-->

# Windows.UI.Xaml.UIElement.CapturePointer

## -description
Sets pointer capture to a [UIElement](uielement.md). Once captured, only the element that has capture will fire pointer-related events.



## -parameters
### -param value
The pointer object reference.

## -returns
**true** if the object has pointer capture; otherwise, **false**.

## -remarks
You can only successfully capture the pointer if that pointer is in a pressed state ([Pointer.IsInContact](../windows.ui.xaml.input/pointer_isincontact.md) should be **true**). What physically constitutes being pressed will vary based on the pointer device type (mouse button pressed, touch point down, stylus in contact). If you attempt to capture a pointer that isn't pressed, or where the pointer was previously pressed but is now released, CapturePointer returns **false**. Existing captures aren't affected by a CapturePointer call that returned **false**.

You typically capture the pointer within a [PointerPressed](uielement_pointerpressed.md) event handler. The [Pointer](../windows.ui.xaml.input/pointer.md) instance you get from the [PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md) event data of your [PointerPressed](uielement_pointerpressed.md) handler is the value you should pass for the *value* parameter when you call CapturePointer from within your handler's code.

You typically capture the pointer because you want the current pointer action to initiate a behavior in your app. In this case you typically don't want other elements to handle any other events that come from that pointer's actions, until your behavior is either completed or is canceled by releasing the pointer capture. If a pointer is captured, only the element that has capture gets the pointer's input events, and other elements don't fire events even if the pointer moves into their bounds. For example, consider a UI that has two adjacent elements. Normally, if you moved the pointer from one element to the other, you'd first get [PointerMoved](uielement_pointermoved.md) events from the first element, and then from the second element. But if the first element has captured the pointer, then the first element continues to receive [PointerMoved](uielement_pointermoved.md) events even if the captured pointer leaves its bounds. Also, the second element doesn't fire [PointerEntered](uielement_pointerentered.md) events for a captured pointer when the captured pointer enters it.

The pointer capture state and generating the events that are related to pointer capture isn't entirely up to app code. If the user releases the pointer, that generates a [PointerReleased](uielement_pointerreleased.md) event, and pointer captures associated with that pointer are lost. This also fires [PointerCaptureLost](uielement_pointercapturelost.md) on the original capturing element.

In most cases the pointer capture will be released automatically when the user completes an input action that releases the previous pointer capture (lifting a touch point, releasing the left mouse button, taking the stylus out of range). Another condition that might release capture is any action that also fires a [PointerCanceled](uielement_pointercanceled.md) event. Your app can typically rely on the capture-release behavior associated with user input actions, without having to specifically cancel a pointer capture with [ReleasePointerCapture](uielement_releasepointercapture_962192786.md) or [ReleasePointerCaptures](uielement_releasepointercaptures_190109337.md). For more info, see [Mouse interactions](/windows/uwp/input-and-devices/mouse-interactions).

The CapturePointer method will return **false** if the pointer was already captured.


A [UIElement](uielement.md) can capture more than one pointer point at a time. Use the *value* parameter to indicate the [Pointer](../windows.ui.xaml.input/pointer.md) instance you want to capture.

The input events that represent gestures (such as [Tapped](uielement_tapped.md) or [DoubleTapped](uielement_doubletapped.md)) are usually only fired after a pointer is released, so you shouldn't attempt to capture a pointer in event handlers for gesture events. The [Pointer](../windows.ui.xaml.input/pointer.md) reference in event data for gesture events won't be permitted to initiate a pointer capture.



> [!TIP]
> Don't try to use CapturePointer outside the scope of pointer-relevant input event handlers. Unless you have a [Pointer](../windows.ui.xaml.input/pointer.md) that you're sure is associated with a pointer that's permitted to have pointer capture at that time, your CapturePointer call won't have any effect. There's no practical way to generate a new [Pointer](../windows.ui.xaml.input/pointer.md) and call CapturePointer using that new pointer. You should only use the [Pointer](../windows.ui.xaml.input/pointer.md) references the system is providing to you through the event data of the pointer-related input events.

## -examples
This example shows calling CapturePointer based on handling [PointerPressed](uielement_pointerpressed.md). It also shows a pattern for tracking and counting pointer references.



[!code-csharp[Scenario2Code](../windows.ui.xaml/code/input/csharp/Scenario2.xaml.cs#SnippetScenario2Code)]

[!code-vb[Scenario2Code](../windows.ui.xaml/code/input/vbnet/Scenario2.xaml.vb#SnippetScenario2Code)]

## -see-also
[Pointer](../windows.ui.xaml.input/pointer.md), [ReleasePointerCapture](uielement_releasepointercapture_962192786.md), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input), [Relative mouse movement and CoreWindow](/windows/uwp/gaming/relative-mouse-movement), [Input sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
