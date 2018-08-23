---
-api-id: M:Windows.ApplicationModel.EnteredBackgroundEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Deferral GetDeferral()
-->

# Windows.ApplicationModel.EnteredBackgroundEventArgs.GetDeferral

## -description
Gets the deferral object which delays the transition from running in the background state to the suspended state until the app calls [Deferral.Complete](../windows.foundation/deferral_complete_1807836922.md) or the deadline for navigation has passed.

## -returns
The deferral object you will use to indicate when your processing is complete.

## -remarks
Deferrals are important if you call asynchronous methods from your event handler. Without the deferral, the app transitions to the next state when the event handler returns— which could happen before your asynchronous method has finished.

## -examples

## -see-also
