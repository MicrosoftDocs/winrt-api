---
-api-id: P:Windows.UI.Xaml.UIElement.LosingFocusEvent
-api-type: winrt property
---

<!-- Property syntax.
public RoutedEvent LosingFocusEvent { get; }
-->

# Windows.UI.Xaml.UIElement.LosingFocusEvent

## -description

Gets the identifier for the [LosingFocus](uielement_losingfocus.md) routed event.



## -property-value

The identifier for the [LosingFocus](uielement_losingfocus.md) routed event.

## -remarks

We recommend using the [UIElement](../windows.ui.xaml/uielement.md) focus routed events instead of [FocusManager](../windows.ui.xaml.input/focusmanager.md) events whenever possible.

Only a single UI element at a time can have focus.

A control can lose focus when another control gets focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

## -examples

## -see-also

[LosingFocusEventArgs](../windows.ui.xaml.input/losingfocuseventargs.md), [LosingFocus](uielement_losingfocus.md), [LostFocus](uielement_lostfocus.md), [GotFocus](uielement_gotfocus.md), [GettingFocusEvent](uielement_gettingfocusevent.md), [GettingFocus](uielement_gettingfocus.md), [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md), [AddHandler](uielement_addhandler_2121467075.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)
