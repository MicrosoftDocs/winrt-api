---
-api-id: E:Windows.ApplicationModel.Calls.LockScreenCallUI.Closed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Closed<Windows.ApplicationModel.Calls.LockScreenCallUI,  object>
-->

# Windows.ApplicationModel.Calls.LockScreenCallUI.Closed

## -description
Occurs when the lock screen interaction is complete.

## -remarks
The [Closed](lockscreencallui_closed.md) event fires when the app is removed from the lock screen by any means. After this event fires, the [LockScreenCallUI](lockscreencallui.md) object is no longer valid. Any further attempt to use the [LockScreenCallUI](lockscreencallui.md) object can either silently fail or explicitly fail with RPC_E_DISCONNECTED.

The [Closed](lockscreencallui_closed.md) event doesn't use the object parameter passed to it. The object parameter exists only because event handlers require it.

## -examples

## -see-also
