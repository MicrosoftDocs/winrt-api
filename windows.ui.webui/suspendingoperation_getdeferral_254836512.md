---
-api-id: M:Windows.UI.WebUI.SuspendingOperation.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.SuspendingDeferral GetDeferral()
-->

# Windows.UI.WebUI.SuspendingOperation.GetDeferral

## -description
Requests that the app suspension operation be delayed.

## -returns
The suspension deferral.

## -remarks
App suspension is delayed until the app calls the [SuspendingDeferral.complete](suspendingdeferral_complete_1807836922.md) method or the deadline for suspension has passed.

Use the deferral to complete asynchronous operations, such as saving data to a file, before the system suspends your app.

Note that requesting a deferral does not give your app more time to complete suspend, it simply allows you to complete asynchronous operations in the same amount of time that your app would normally get in the suspending event handler.

## -examples

## -see-also
[App lifecycle](http://msdn.microsoft.com/library/6c469e77-f1e3-4859-a27b-c326f9616d10), [App activated, resume, and suspend using the WRL sample](http://go.microsoft.com/fwlink/p/?linkid=226722)