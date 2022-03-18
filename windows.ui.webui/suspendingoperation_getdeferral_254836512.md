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
[App lifecycle](/windows/uwp/launch-resume/app-lifecycle), [App activated, resume, and suspend using the WRL sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BJavaScript%5D-Windows%208%20app%20samples/JavaScript/Windows%208%20app%20samples/App%20activated%2C%20resume%2C%20and%20suspend%20using%20the%20WRL%20%20sample%20(Windows%208)/JavaScript)
