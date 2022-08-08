---
-api-id: M:Windows.UI.Xaml.Input.LosingFocusEventArgs.TrySetNewFocusedElement(Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax.
public bool LosingFocusEventArgs.TrySetNewFocusedElement(DependencyObject element)
-->

# Windows.UI.Xaml.Input.LosingFocusEventArgs.TrySetNewFocusedElement

## -description
Attempts to redirect focus from the targeted element to the specified element.


## -parameters
### -param element
The object on which to set focus.

## -returns
True, if the focus action is redirected; otherwise, false.

## -remarks
The [GotFocus](../windows.ui.xaml/uielement_gotfocus.md) routed event is raised on an element after it receives focus, while the [LostFocus](../windows.ui.xaml/uielement_lostfocus.md) routed event is raised on an element after it loses focus. 

The [GettingFocus](../windows.ui.xaml/uielement_gettingfocus.md) and [LosingFocus](../windows.ui.xaml/uielement_losingfocus.md) routed events occur before the focus change takes place, which enables your application to modify or cancel the focus change behavior.   

[GettingFocus](../windows.ui.xaml/uielement_gettingfocus.md) and [LosingFocus](../windows.ui.xaml/uielement_losingfocus.md) are raised synchronously, while [GotFocus](../windows.ui.xaml/uielement_gotfocus.md) and [LostFocus](../windows.ui.xaml/uielement_lostfocus.md) are raised asynchronously. For example, if your app calls the [Focus](/uwp/api/Windows.UI.Xaml.Controls.Control#controls-and-focus) method of a control, GettingFocus is raised during the call, but [GotFocus](../windows.ui.xaml/uielement_gotfocus.md) is raised after the call completes. 

If focus is moved while these events are still bubbling, an exception is thrown.

## -see-also
[LosingFocusEventArgs.TryCancel](losingfocuseventargs_trycancel_50138317.md), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)


## -examples

