---
-api-id: E:Windows.UI.Input.SystemButtonEventController.SystemFunctionLockChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler SystemFunctionLockChanged<SystemButtonEventController, SystemFunctionLockChangedEventArgs>
-->

# Windows.UI.Input.SystemButtonEventController.SystemFunctionLockChanged

## -description

Occurs on changes to the state of the **Fn** hardware system (also know as Function Shift) button lock.

## -remarks

This API is intended for use by Accessibility tools as a low level hook for intercepting events from hardware system buttons.

[SystemButtonEventController](systembuttoneventcontroller.md) event registration applies system wide and is first-come, first-served. If an application or service sets a SystemButtonEventController event Handled property to true, applications or services that registered after that app or service for the same event notification will not receive the notification.

## -see-also

[SystemFunctionLockChangedEventArgs](systemfunctionlockchangedeventargs.md), [Screen readers and hardware system buttons](/windows/uwp/design/accessibility/system-button-narration), [Hooks Overview](/windows/win32/winmsg/about-hooks)

## -examples
