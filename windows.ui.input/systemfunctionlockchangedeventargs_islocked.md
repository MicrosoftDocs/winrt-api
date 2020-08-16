---
-api-id: P:Windows.UI.Input.SystemFunctionLockChangedEventArgs.IsLocked
-api-type: winrt property
---

<!-- Property syntax.
public bool IsLocked { get; }
-->

# Windows.UI.Input.SystemFunctionLockChangedEventArgs.IsLocked

## -description

Gets the state of the **Fn** hardware system button lock for the [SystemFunctionLockChanged](systembuttoneventcontroller_systemfunctionlockchanged.md) event.

## -property-value

True, if the hardware Function button lock is on. Otherwise, false.

## -remarks

This API is intended for use by Accessibility tools as a low level hook for intercepting events from hardware system buttons.

[SystemButtonEventController](systembuttoneventcontroller.md) event registration applies system wide and is first-come, first-served. If an application or service sets a SystemButtonEventController event Handled property to true, applications or services that registered after that app or service for the same event notification will not receive the notification.

## -see-also

[Screen readers and hardware system buttons](/windows/uwp/design/accessibility/system-button-narration), [Hooks Overview](/windows/win32/winmsg/about-hooks)

## -examples
