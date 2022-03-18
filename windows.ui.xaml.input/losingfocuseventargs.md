---
-api-id: T:Windows.UI.Xaml.Input.LosingFocusEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class LosingFocusEventArgs : RoutedEventArgs, RoutedEventArgs
-->

# Windows.UI.Xaml.Input.LosingFocusEventArgs

## -description

Provides data for the [FocusManager.LosingFocus](focusmanager_losingfocus.md) and [UIElement.LosingFocus](../windows.ui.xaml/uielement_losingfocus.md) events.

Equivalent WinUI class: [Microsoft.UI.Xaml.Input.LosingFocusEventArgs](/windows/winui/api/microsoft.ui.xaml.input.losingfocuseventargs).

## -remarks

Only a single UI element at a time can have focus.

A control can lose focus when another control gets focus, the application view changes, the user switches applications, or the user interacts with the system such that the application is no longer in the foreground.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | TryCancel |
| 1803 | 17134 | TrySetNewFocusedElement |
| 1809 | 17763 | CorrelationId |

## -see-also

 [LosingFocusEvent](uielement_losingfocusevent.md), [LosingFocus](uielement_losingfocus.md), [LostFocus](uielement_lostfocus.md), [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md), [AddHandler](uielement_addhandler_2121467075.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)


## -examples

