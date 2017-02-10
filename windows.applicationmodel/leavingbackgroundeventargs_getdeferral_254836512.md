---
-api-id: M:Windows.ApplicationModel.LeavingBackgroundEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Deferral GetDeferral()
-->

# Windows.ApplicationModel.LeavingBackgroundEventArgs.GetDeferral

## -description
Gets the deferral object which delays the transition from running in the background to running in the foreground until the app calls [Deferral.Complete](../windows.foundation/deferral_complete.md) or the deadline for navigation has passed.

## -returns
The deferral object you will use to indicate that your processing is done.

## -remarks
Deferrals are important if you call asynchronous methods from your event handler. Without the deferral, the app transitions to the next state when the event handler returns— which may happen before your asynchronous method has finished.

## -examples

## -see-also
