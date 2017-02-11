---
-api-id: E:Windows.ApplicationModel.Core.CoreApplication.UnhandledErrorDetected
-api-type: winrt event
---

<!-- Event syntax
static public event Windows.Foundation.EventHandler UnhandledErrorDetected<Windows.ApplicationModel.Core.UnhandledErrorDetectedEventArgs>
-->

# Windows.ApplicationModel.Core.CoreApplication.UnhandledErrorDetected

## -description
Occurs when there is an underlying error that is routed to the [CoreApplication](coreapplication.md) instance, as part of global error handling logic.

## -remarks
As part of an app's life cycle management code, developers can inspect error data ([UnhandledError](unhandlederror.md)) from an **UnhandledErrorDetected** event, and choose whether to mark the error as handled. If the error is marked handled in the event data, then execution can continue. If the error is not marked handled, the app and its process will be terminated.

Errors that can fire **UnhandledErrorDetected** include errors that are thrown by code within an async completed handler.

**UnhandledErrorDetected** will occur if an app-code event handler throws an error, but the reason that the handler was executed was that system code (not app code) raised the event. App code doesn't always see that error or see that the handler executed.

Returning a failure from any delegate clears the handled state of the error.


<!--Do templates stub this? What is the interaction with the already existing UnhandledException on the XAML Application object?-->

<!--There is apparently a quirks mode.-->

<!--Spec has a lot of stuff about inprocess vs brokered - what does that mean? is it relevant to the API?-->

## -examples

## -see-also
