---
-api-id: M:Windows.UI.Input.SystemButtonEventController.CreateForDispatcherQueue(Windows.System.DispatcherQueue)
-api-type: winrt method
---

<!-- Method syntax.
public SystemButtonEventController SystemButtonEventController.CreateForDispatcherQueue(DispatcherQueue queue)
-->

# Windows.UI.Input.SystemButtonEventController.CreateForDispatcherQueue

## -description

Creates a [SystemButtonEventController](systembuttoneventcontroller.md) object on the specified dispatcher queue.

All events are fired on the queue thread.

## -parameters

### -param queue

The [DispatcherQueue](../windows.system/dispatcherqueue.md) for managing prioritized tasks that execute in a serial fashion on a thread.

## -returns

A [SystemButtonEventController](systembuttoneventcontroller.md).

## -remarks

This API is intended for use by Accessibility tools as a low level hook for intercepting events from hardware system buttons.

[SystemButtonEventController](systembuttoneventcontroller.md) event registration applies system wide and is first-come, first-served. If an application or service sets a SystemButtonEventController event Handled property to true, applications or services that registered after that app or service for the same event notification will not receive the notification.

## -see-also

[Screen readers and hardware system buttons](/windows/uwp/design/accessibility/system-button-narration), [Hooks Overview](/windows/win32/winmsg/about-hooks)

## -examples
