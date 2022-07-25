---
-api-id: T:Windows.UI.Xaml.Input.GettingFocusEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class GettingFocusEventArgs : RoutedEventArgs, RoutedEventArgs
-->

# Windows.UI.Xaml.Input.GettingFocusEventArgs

## -description

Provides data for the [FocusManager.GettingFocus](focusmanager_gettingfocus.md) and [UIElement.GettingFocus](../windows.ui.xaml/uielement_gettingfocus.md) events.



## -remarks

Only a single UI element at a time can have focus.

A control can get focus when another control loses focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | TryCancel |
| 1803 | 17134 | TrySetNewFocusedElement |
| 1809 | 17763 | CorrelationId |

## -see-also

 [GettingFocusEvent](../windows.ui.xaml/uielement_gettingfocusevent.md), [GettingFocus](../windows.ui.xaml/uielement_gettingfocus.md), [GotFocus](../windows.ui.xaml/uielement_gotfocus.md), [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md), [AddHandler](../windows.ui.xaml/uielement_addhandler_2121467075.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)

## -examples
