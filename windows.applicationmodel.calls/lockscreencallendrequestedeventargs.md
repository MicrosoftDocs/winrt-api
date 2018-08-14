---
-api-id: T:Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class LockScreenCallEndRequestedEventArgs : Windows.ApplicationModel.Calls.ILockScreenCallEndRequestedEventArgs
-->

# Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs

## -description
Controls the removal of an app from the lock screen.

## -remarks

If the app doesn't call [GetDeferral](lockscreencallendrequestedeventargs_getdeferral_254836512.md) to request a deferral, the app is removed from the lock screen as soon as the [LockScreenCallUI.EndRequested](lockscreencallui_endrequested.md) event handler returns.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem
