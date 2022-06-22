---
-api-id: M:Windows.UI.Xaml.UIElement.AddHandler(Windows.UI.Xaml.RoutedEvent,System.Object,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void AddHandler(Windows.UI.Xaml.RoutedEvent routedEvent, System.Object handler, System.Boolean handledEventsToo)
-->

# Windows.UI.Xaml.UIElement.AddHandler

## -description
Adds a routed event handler for a specified routed event, adding the handler to the handler collection on the current element. Specify *handledEventsToo* as **true** to have the provided handler be invoked even if the event is handled elsewhere.



## -parameters
### -param routedEvent
An identifier for the routed event to be handled.

### -param handler
A reference to the handler implementation.

### -param handledEventsToo
**true** to register the handler such that it is invoked even when the routed event is marked handled in its event data.

**false** to register the handler with the default condition that it will not be invoked if the routed event is already marked handled. The default is **false**.

Do not routinely ask to rehandle a routed event, because it interferes with the intended design of the Windows Runtime event system for control compositing.

## -remarks
Don't try to use AddHandler as a general substitute for the language-specific syntax you normally use for wiring event handlers; it won't work, because not all events have an identifier you can pass as *routedEvent*. AddHandler is specifically for routed events, and intended mainly for the particular scenario enabled by passing *handledEventsToo* as **true**. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

### Routed event identifiers

The routed event identifier is generally a static property member of [UIElement](uielement.md). For example, to add a handler for the [KeyUp](uielement_keyup.md) event, pass [KeyUpEvent](uielement_keyupevent.md) for this parameter. Only a small number of Windows Runtime events have this identifier; only routed events on [UIElement](uielement.md) have an identifier API available for this usage. These are generally events that are related to input actions at various levels: pointer level, gesture level, manipulation level. Also, the key input events can be handled this way.

Here is a list of routed events that expose a routed event identifier, and thus can be processed by handlers that are registered by an AddHandler call:

+ [DoubleTapped](uielement_doubletapped.md)
+ [DragEnter](uielement_dragenter.md)
+ [DragLeave](uielement_dragleave.md)
+ [DragOver](uielement_dragover.md)
+ [Drop](uielement_drop.md)
+ [Holding](uielement_holding.md)
+ [KeyDown](uielement_keydown.md)
+ [KeyUp](uielement_keyup.md)
+ [ManipulationCompleted](uielement_manipulationcompleted.md)
+ [ManipulationDelta](uielement_manipulationdelta.md)
+ [ManipulationInertiaStarting](uielement_manipulationinertiastarting.md)
+ [ManipulationStarted](uielement_manipulationstarted.md)
+ [ManipulationStarting](uielement_manipulationstarting.md)
+ [PointerCanceled](uielement_pointercanceled.md)
+ [PointerCaptureLost](uielement_pointercapturelost.md)
+ [PointerEntered](uielement_pointerentered.md)
+ [PointerExited](uielement_pointerexited.md)
+ [PointerMoved](uielement_pointermoved.md)
+ [PointerPressed](uielement_pointerpressed.md)
+ [PointerReleased](uielement_pointerreleased.md)
+ [PointerWheelChanged](uielement_pointerwheelchanged.md)
+ [RightTapped](uielement_righttapped.md)
+ [Tapped](uielement_tapped.md)


### The *handler* parameter

The *handler* parameter is an untyped parameter, but you should provide a new delegate that references a handler method that is specific to the desired event. For example, if handling a [KeyUp](uielement_keyup.md) event, pass a new [KeyEventHandler](../windows.ui.xaml.input/keyeventhandler.md) instance that references a method that is based on that [KeyEventHandler](../windows.ui.xaml.input/keyeventhandler.md) delegate signature. This requires a dereference, and the dereference syntax varies depending on which language you are using. See the examples in this topic.

### When to use *handledEventsToo*

Processing low-level input events in a practical way is a complex task. Many controls implement behavior where a certain event is marked as handled, and is replaced by another more intuitive event. Generally, a control will mark a routed event as handled only if there is some design intention for doing so. However, in certain scenarios, those design intentions might not be what your particular handling of the input event requires. It is for these scenarios that registering handlers with *handledEventsToo* as **true** is appropriate. But you should not do this routinely. Invoking handlers in response to all events even if handled will complicate your own app event-processing logic. You may see a decrease in performance if the handler logic is substantial. You should attach handlers to already-handled events only if you have discovered that certain controls are handling events that you want to handle with app logic.

Another technique for avoiding a control's class-handling behavior is to subclass that control and override its **On**_Event_ methods, which are pre-configured overrides by which the control marks an event as handled. However, this too can be complex. You may have to reproduce a control's handling implementation without calling the base implementation, because the base implementation would mark the event as handled. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

## -examples
This example shows the basic syntax for wiring an event handler with AddHandler and *handledEventsToo* as **true**. In this case the event being wired is [Tapped](uielement_tapped.md). The typical place to wire handlers is either [Loaded](frameworkelement_loaded.md) for a page or [OnApplyTemplate](frameworkelement_onapplytemplate_1955470198.md) for a templated control.


```cppwinrt
void MyControl::MyPointerPressedHandler(
    winrt::Windows::Foundation::IInspectable const &sender,
    winrt::Windows::UI::Xaml::Input::PointerRoutedEventArgs const& e) {
  // implementation..
}

this->AddHandler(
    winrt::Windows::UI::Xaml::UIElement::PointerPressedEvent(),
    winrt::box_value(winrt::Windows::UI::Xaml::Input::PointerEventHandler(this, &MyControl::MyPointerPressedHandler)),
    true);

// Or passing the handler as a lambda, instead of a member function:
this->AddHandler(
    winrt::Windows::UI::Xaml::UIElement::PointerPressedEvent(),
    winrt::box_value(winrt::Windows::UI::Xaml::Input::PointerEventHandler(
      [=](auto &&, winrt::Windows::UI::Xaml::Input::PointerRoutedEventArgs const &args) {
      // ...
    })),
    true);    
```
[!code-cpp[AddHandler](../windows.ui.xaml/code/BaseElementEvents/cpp/BasicPage.xaml.cpp#SnippetAddHandler)]

[!code-csharp[AddHandler](../windows.ui.xaml/code/BaseElementEvents/csharp/BasicPage1.xaml.cs#SnippetAddHandler)]

[!code-vb[AddHandler](../windows.ui.xaml/code/BaseElementEvents/vbnet/MainPage.xaml.vb#SnippetAddHandler)]


## -see-also
[RemoveHandler](uielement_removehandler_661998757.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Handle pointer input](/windows/uwp/design/input/handle-pointer-input)
afee-8792-4a57-ae84-aa11ab95355a)
