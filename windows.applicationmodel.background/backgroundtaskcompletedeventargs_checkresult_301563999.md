---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs.CheckResult
-api-type: winrt method
---

<!-- Method syntax
public void CheckResult()
-->

# Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs.CheckResult

## -description
Throws an exception if the background task completed event has reported an error.

## -remarks
This method should be called from within a **try** block. If the background task completed event reported an error, it will be caught as an exception in the subsequent **catch** clause.

## -examples

## -see-also
