---
-api-id: P:Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs.Deadline
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime Deadline { get; }
-->

# Windows.ApplicationModel.Calls.LockScreenCallEndRequestedEventArgs.Deadline

## -description
Gets the deadline by which the app must complete the deferral.

## -property-value
The deadline by which the app must complete the deferral.

## -remarks
If the deadline passes and the app hasn't called [Complete](lockscreencallendcalldeferral_complete.md), the operating system acts as if the deferral completed.

The current deadline is 5 seconds after the user initiates the action that triggers the [LockScreenCallUI.EndRequested](lockscreencallui_endrequested.md) event.

## -examples

## -see-also
