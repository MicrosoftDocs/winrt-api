---
-api-id: T:Windows.UI.Xaml.Input.PointerRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class PointerRoutedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Input.IPointerRoutedEventArgs
-->

# Windows.UI.Xaml.Input.PointerRoutedEventArgs

## -description
Contains the arguments returned by the last pointer event message.

In most cases, we recommend that you get pointer info through the event argument of the pointer event handlers in your chosen Windows 8 language framework (Windows app using JavaScript, Windows Store app using C++, C#, or Visual Basic, or Windows Store app using DirectX with C++).

If the event argument doesn't intrinsically expose the pointer details required by your app, you can get access to extended pointer data through the [GetCurrentPoint](pointerroutedeventargs_getcurrentpoint.md) and [GetIntermediatePoints](pointerroutedeventargs_getintermediatepoints.md) methods of [PointerRoutedEventArgs](pointerroutedeventargs.md). Use these methods to specify the context of the pointer data.

The static [PointerPoint](../windows.ui.input/pointerpoint.md) methods, [GetCurrentPoint](../windows.ui.input/pointerpoint_getcurrentpoint.md) and [GetIntermediatePoints](../windows.ui.input/pointerpoint_getintermediatepoints.md), always use the context of the app.

## -remarks
The [PointerRoutedEventArgs](pointerroutedeventargs.md) event data class is used for these events:


+ [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md)
+ [PointerCanceled](../windows.ui.xaml/uielement_pointercanceled.md)
+ [PointerCaptureLost](../windows.ui.xaml/uielement_pointercapturelost.md)
+ [PointerEntered](../windows.ui.xaml/uielement_pointerentered.md)
+ [PointerExited](../windows.ui.xaml/uielement_pointerexited.md)
+ [PointerMoved](../windows.ui.xaml/uielement_pointermoved.md)
+ [PointerReleased](../windows.ui.xaml/uielement_pointerreleased.md)
+ [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md)
> [!IMPORTANT]
> Mouse input is associated with a single pointer assigned when mouse input is first detected. Clicking a mouse button (left, wheel, or right) creates a secondary association between the pointer and that button through the [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) event. The [PointerReleased](../windows.ui.xaml/uielement_pointerreleased.md) event is fired only when that same mouse button is released (no other button can be associated with the pointer until this event is complete). Because of this exclusive association, other mouse button clicks are routed through the [PointerMoved](../windows.ui.xaml/uielement_pointermoved.md) event. You can test the mouse button state when handling this event, as shown in the following example.





[!code-csharp[PointerMoved](../windows.ui.input.inking/code/PointerInput/csharp/MainPage.xaml.cs#SnippetPointerMoved)]

[!code-csharp[PointerMoved](../windows.ui.input.inking/code/PointerInput_UWP/csharp/MainPage.xaml.cs#SnippetPointerMoved)]
+ The value of *sender* (which is on the delegate signature, not this event data class).
+ Specific members of [PointerRoutedEventArgs](pointerroutedeventargs.md), such as [KeyModifiers](pointerroutedeventargs_keymodifiers.md) or [GetCurrentPoint](pointerroutedeventargs_getcurrentpoint.md).
+ Values of a [Pointer](pointer.md) device description class. Get the [Pointer](pointer.md) from the [Pointer](pointerroutedeventargs_pointer.md) property.
+ Members that come from the system input conceptualization of a [PointerPoint](../windows.ui.input/pointerpoint.md). Use the [GetCurrentPoint](pointerroutedeventargs_getcurrentpoint.md) API to get a [PointerPoint](../windows.ui.input/pointerpoint.md) value, then call [PointerPoint](../windows.ui.input/pointerpoint.md) API such as [Position](../windows.ui.input/pointerpoint_position.md) and [PointerPointProperties](../windows.ui.input/pointerpointproperties.md).


Specific events often have information available in the various pointer device and pointer point classes that is mainly only relevant for that event. For example, when you handle [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md), you might be interested in the [MouseWheelDelta](../windows.ui.input/pointerpointproperties_mousewheeldelta.md) from [PointerPointProperties](../windows.ui.input/pointerpointproperties.md).

The object retrieved by the GetCurrentPoint and GetIntermediatePoints methods provide access to extended pointer info through the [Properties](../windows.ui.input/pointerpoint_properties.md) property, which gets a [PointerPointProperties](../windows.ui.input/pointerpointproperties.md) object.



In the following example, we get extended pointer properties through the [PointerPoint](../windows.ui.input/pointerpoint.md) and [PointerPointProperties](../windows.ui.input/pointerpointproperties.md) objects. (See [Quickstart: Pointers](http://msdn.microsoft.com/library/90967981-40c0-4a7c-9ba9-86c28c78e154) for the complete example.)



[TODO:AUTO_SNIPPET (SAMPLE_ID:PointerInput)(SNIPPET_ID:QueryPointer)]

Typically, the object returned by this method is used to feed pointer data to a [GestureRecognizer](../windows.ui.input/gesturerecognizer.md). Another scenario is getting the [MouseWheelDelta](../windows.ui.input/pointerpointproperties_mousewheeldelta.md) for a [PointerWheelChanged](../windows.ui.xaml/uielement_pointerwheelchanged.md) event; that value is in [PointerPointProperties](../windows.ui.input/pointerpointproperties.md).



## -examples
The following code example shows scenario 2 from the [Input sample](http://go.microsoft.com/fwlink/p/?linkid=226855). This code shows some usage patterns for direct manipulation using the [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md), [PointerReleased](../windows.ui.xaml/uielement_pointerreleased.md), [PointerEntered](../windows.ui.xaml/uielement_pointerentered.md), [PointerExited](../windows.ui.xaml/uielement_pointerexited.md), and [PointerMoved](../windows.ui.xaml/uielement_pointermoved.md) events.



[!code-xml[Scenario2Xaml](../windows.ui.xaml/code/input/csharp/Scenario2.xaml#SnippetScenario2Xaml)]

[!code-csharp[Scenario2Code](../windows.ui.xaml/code/input/csharp/Scenario2.xaml.cs#SnippetScenario2Code)]

[!code-vb[Scenario2Code](../windows.ui.xaml/code/input/vbnet/Scenario2.xaml.vb#SnippetScenario2Code)]

## -see-also
[RoutedEventArgs](../windows.ui.xaml/routedeventargs.md), [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md)
d), [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md)
