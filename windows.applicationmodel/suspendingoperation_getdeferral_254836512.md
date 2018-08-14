---
-api-id: M:Windows.ApplicationModel.SuspendingOperation.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.SuspendingDeferral GetDeferral()
-->

# Windows.ApplicationModel.SuspendingOperation.GetDeferral

## -description
Requests that the app suspending operation be delayed.

## -returns
The suspension deferral.

## -remarks
App suspension is delayed until the app calls the [SuspendingDeferral.Complete](suspendingdeferral_complete_1807836922.md) method or the deadline for suspension has passed.

## -examples

## -see-also
[UX guidelines for launch, suspend, and resume](http://msdn.microsoft.com/library/90770735-c2c5-4d3a-a21f-48a59e2a0ba9), [SuspendingEventArgs](suspendingeventargs.md), [SuspendingOperation.GetDeferral](suspendingoperation_getdeferral_254836512.md), [Handle app suspend](http://msdn.microsoft.com/library/f84f1512-24b9-45ec-bf23-a09e0ac985b0), [suspendingEventArgs](../windows.ui.webui/suspendingeventargs.md), [suspendingOperation.getDeferral](../windows.ui.webui/suspendingoperation_getdeferral_254836512.md), [App lifecycle](http://msdn.microsoft.com/library/6c469e77-f1e3-4859-a27b-c326f9616d10)