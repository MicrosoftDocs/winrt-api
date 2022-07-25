---
-api-id: E:Windows.UI.Xaml.UIElement.LosingFocus
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler LosingFocus<UIElement, LosingFocusEventArgs>
-->

# Windows.UI.Xaml.UIElement.LosingFocus

## -description

Occurs before a [UIElement](uielement.md) loses focus. This event is raised synchronously to ensure focus isn't moved while the event is bubbling.



## -xaml-syntax

```xaml
<uiElement LosingFocus="eventhandler"/>
```

## -remarks

We recommend using the [UIElement](../windows.ui.xaml/uielement.md) focus routed events instead of [FocusManager](../windows.ui.xaml.input/focusmanager.md) events whenever possible.

Only a single UI element at a time can have focus.

A control can lose focus when another control gets focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

When programmatically navigating between elements, [FocusNavigationDirection.Previous](../windows.ui.xaml.input/focusnavigationdirection.md) and [FocusNavigationDirection.Next](../windows.ui.xaml.input/focusnavigationdirection.md) cannot be used with [FindNextElementOptions](../windows.ui.xaml.input/findnextelementoptions.md). Only [FocusNavigationDirection.Up](../windows.ui.xaml.input/focusnavigationdirection.md), [FocusNavigationDirection.Down](../windows.ui.xaml.input/focusnavigationdirection.md), [FocusNavigationDirection.Left](../windows.ui.xaml.input/focusnavigationdirection.md), or [FocusNavigationDirection.Right](../windows.ui.xaml.input/focusnavigationdirection.md) are valid.

LosingFocus is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

## -see-also

[LosingFocusEventArgs](../windows.ui.xaml.input/losingfocuseventargs.md), [LostFocus](uielement_lostfocus.md), [LosingFocusEvent](uielement_losingfocusevent.md), [GotFocus](uielement_gotfocus.md), [GettingFocusEvent](uielement_gettingfocusevent.md), [GettingFocus](uielement_gettingfocus.md), [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md), [AddHandler](uielement_addhandler_2121467075.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)

## -examples
