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
[UX guidelines for launch, suspend, and resume](/windows/uwp/launch-resume/index), [SuspendingEventArgs](suspendingeventargs.md), SuspendingOperation.GetDeferral, [Handle app suspend](/windows/uwp/launch-resume/suspend-an-app), [suspendingEventArgs](../windows.ui.webui/suspendingeventargs.md), [suspendingOperation.getDeferral](../windows.ui.webui/suspendingoperation_getdeferral_254836512.md), [App lifecycle](/windows/uwp/launch-resume/app-lifecycle)
