---
-api-id: E:Windows.UI.Xaml.Input.FocusManager.LostFocus
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
static public event EventHandler LostFocus<FocusManagerLostFocusEventArgs>
-->

# Windows.UI.Xaml.Input.FocusManager.LostFocus

## -description

Occurs when an element within a container element (a focus scope) loses focus. This event is raised asynchronously, so focus might move again before bubbling is complete.



## -remarks

We recommend using the [UIElement](../windows.ui.xaml/uielement.md) focus routed events instead of [FocusManager](focusmanager.md) events whenever possible.

UIElement focus events bubble up to the FocusManager in the following order:

1. [UIElement.LosingFocus](../windows.ui.xaml/uielement_losingfocus.md)/[FocusManager.LosingFocus](focusmanager_losingfocus.md)
2. [UIElement.GettingFocus](../windows.ui.xaml/uielement_gettingfocus.md)/[FocusManager.GettingFocus](focusmanager_gettingfocus.md)
3. [UIElement.LostFocus](../windows.ui.xaml/uielement_lostfocus.md) routed event is raised by the element that lost focus and the event bubbles up
4. FocusManager.LostFocus is raised (even if the routed event is marked handled)
5. [UIElement.GotFocus](../windows.ui.xaml/uielement_gotfocus.md) routed event is raised by the element that received focus and the event bubbles up
6. [FocusManager.GotFocus](focusmanager_gotfocus.md) is raised (even if the routed event is marked handled)

## -see-also

[LostFocus](../windows.ui.xaml/uielement_lostfocus.md), [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)

## -examples
