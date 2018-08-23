---
-api-id: M:Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Calls.LockScreenCallEndCallDeferral GetDeferral()
-->

# Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs.GetDeferral

## -description
Requests to defer the default behavior of removing the app from the lock screen.

## -returns
When this method completes, it returns a [LockScreenCallEndCallDeferral](lockscreencallendcalldeferral.md) object that signals when the app no longer needs to defer the removal of itself from the lock screen.

## -remarks
An app can extend its time on the lock screen by calling [GetDeferral](lockscreencallendrequestedeventargs_getdeferral_254836512.md) to request a deferral. If the app requested a deferral, the app is removed from the lock screen when the deferral completes or the deadline passes.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem
