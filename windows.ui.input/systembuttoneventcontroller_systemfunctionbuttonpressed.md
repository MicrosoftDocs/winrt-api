---
-api-id: E:Windows.UI.Input.SystemButtonEventController.SystemFunctionButtonPressed
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler SystemFunctionButtonPressed<SystemButtonEventController, SystemFunctionButtonEventArgs>
-->

# Windows.UI.Input.SystemButtonEventController.SystemFunctionButtonPressed

## -description

Occurs when a **Fn** hardware system (also know as Function Shift) button is pressed.

## -remarks

This API is intended for use by Accessibility tools as a low level hook for intercepting events from hardware system buttons.

[SystemButtonEventController](systembuttoneventcontroller.md) event registration applies system wide and is first-come, first-served. If an application or service sets a SystemButtonEventController event Handled property to true, applications or services that registered after that app or service for the same event notification will not receive the notification.

## -see-also

[SystemFunctionButtonEventArgs](systemfunctionbuttoneventargs.md), [SystemFunctionButtonReleased](systembuttoneventcontroller_systemfunctionbuttonreleased.md), [Screen readers and hardware system buttons](/windows/uwp/design/accessibility/system-button-narration), [Hooks Overview](/windows/win32/winmsg/about-hooks)

## -examples
