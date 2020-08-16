---
-api-id: P:Windows.UI.Input.SystemFunctionButtonEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax.
public bool Handled { get;  set; }
-->

# Windows.UI.Input.SystemFunctionButtonEventArgs.Handled

## -description

Gets or sets a value that marks the [SystemFunctionButtonPressed](systembuttoneventcontroller_systemfunctionbuttonpressed.md) and [SystemFunctionButtonReleased](systembuttoneventcontroller_systemfunctionbuttonreleased.md) events as handled.

## -property-value

If false (default), the event bubbles up to the next event handler. Otherwise, the event does not bubble up to the next event handler.

## -remarks

This API is intended for use by Accessibility tools as a low level hook for intercepting events from hardware system buttons.

[SystemButtonEventController](systembuttoneventcontroller.md) event registration applies system wide and is first-come, first-served. If an application or service sets a SystemButtonEventController event Handled property to true, applications or services that registered after that app or service for the same event notification will not receive the notification.

## -see-also

[Screen readers and hardware system buttons](/windows/uwp/design/accessibility/system-button-narration), [Hooks Overview](/windows/win32/winmsg/about-hooks)

## -examples
