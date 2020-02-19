---
-api-id: E:Windows.UI.Input.SystemButtonEventController.SystemFunctionButtonReleased
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler SystemFunctionButtonReleased<SystemButtonEventController, SystemFunctionButtonEventArgs>
-->

# Windows.UI.Input.SystemButtonEventController.SystemFunctionButtonReleased

## -description

Occurs when a hardware Function (also know as Function Shift) button, which is currently pressed, is released.

## -remarks

This API is intended for use by Accessibility tools as a low level hook for intercepting events from hardware system buttons.

[SystemButtonEventController](systembuttoneventcontroller.md) event registration applies system wide and is first-come, first-served. If an application or service sets a SystemButtonEventController event Handled property to true, applications or services that registered after that app or service for the same event notification will not receive the notification.

## -see-also

[SystemFunctionButtonEventArgs](systemfunctionbuttoneventargs.md), [SystemFunctionButtonPressed](systembuttoneventcontroller_systemfunctionbuttonpressed.md), [Hooks Overview](/windows/win32/winmsg/about-hooks)

## -examples
