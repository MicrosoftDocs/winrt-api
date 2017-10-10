---
-api-id: E:Windows.ApplicationModel.Calls.LockScreenCallUI.EndRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler EndRequested<Windows.ApplicationModel.Calls.LockScreenCallUI,  Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs>
-->

# Windows.ApplicationModel.Calls.LockScreenCallUI.EndRequested

## -description
Occurs when the lock screen wants to end the call.

## -remarks
The [EndRequested](lockscreencallui_endrequested.md) event typically happens when the user taps the “End call” button on the lock screen, but the event can also happen under other conditions. For example, suppose a call comes in while a call is already active on the lock screen. By accepting the new call on the lock screen, the previous call ends.

When the [EndRequested](lockscreencallui_endrequested.md) event handler returns, the app is removed from the lock screen. An app can extend its time on the lock screen by calling [LockScreenCallEndRequestedEventArgs.GetDeferral](lockscreencallendrequestedeventargs_getdeferral.md) to request a deferral. If the app requested a deferral, the app is removed from the lock screen when the deferral completes or the deadline passes.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem
