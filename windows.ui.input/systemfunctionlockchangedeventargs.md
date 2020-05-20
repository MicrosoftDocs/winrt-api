---
-api-id: T:Windows.UI.Input.SystemFunctionLockChangedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SystemFunctionLockChangedEventArgs 
-->

# Windows.UI.Input.SystemFunctionLockChangedEventArgs

## -description

Contains event data for the [SystemFunctionLockChanged](systembuttoneventcontroller_systemfunctionlockchanged.md) event.

## -remarks

This API is intended for use by Accessibility tools as a low level hook for intercepting events from hardware system buttons.

[SystemButtonEventController](systembuttoneventcontroller.md) event registration applies system wide and is first-come, first-served. If an application or service sets a SystemButtonEventController event Handled property to true, applications or services that registered after that app or service for the same event notification will not receive the notification.

## -see-also

[Screen readers and hardware system buttons](/windows/uwp/design/accessibility/system-button-narration), [Hooks Overview](/windows/win32/winmsg/about-hooks)

## -examples
