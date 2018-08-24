---
-api-id: M:Windows.ApplicationModel.ISuspendingOperation.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.SuspendingDeferral GetDeferral()
-->

# Windows.ApplicationModel.ISuspendingOperation.GetDeferral

## -description
Requests that the app suspending operation be delayed.

## -returns
The suspension deferral.

## -remarks
App suspension is delayed until the app calls the [ISuspendingDeferral.Complete](isuspendingdeferral_complete_1807836922.md) method or the deadline for suspension has passed.

## -examples

## -see-also
