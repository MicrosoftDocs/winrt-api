---
-api-id: M:Windows.ApplicationModel.Background.ApplicationTrigger.RequestAsync(Windows.Foundation.Collections.ValueSet)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Background.ApplicationTriggerResult> RequestAsync(Windows.Foundation.Collections.ValueSet arguments)
-->

# Windows.ApplicationModel.Background.ApplicationTrigger.RequestAsync

## -description
This method attempts to set the trigger and start the registered background task with specified arguments.

## -parameters
### -param arguments
The serialized arguments that are passed to the background task.

## -returns
Returns an [ApplicationTriggerResult](applicationtriggerresult.md) enumeration that indicates whether the user provided the necessary consent for the operation or the system policies didn't reject the request to trigger a background task.

## -remarks

## -examples

## -see-also
[RequestAsync](applicationtrigger_requestasync_1234533424.md)