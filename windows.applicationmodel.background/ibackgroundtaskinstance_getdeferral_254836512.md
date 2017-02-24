---
-api-id: M:Windows.ApplicationModel.Background.IBackgroundTaskInstance.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Background.BackgroundTaskDeferral GetDeferral()
-->

# Windows.ApplicationModel.Background.IBackgroundTaskInstance.GetDeferral

## -description
Informs the system that the background task might continue to perform work after the [IBackgroundTask.Run](ibackgroundtask_run.md) method returns.

## -returns
A background task deferral.

## -remarks
If a background task uses an asynchronous operation, it is possible for the [Run](ibackgroundtask_run.md) method to return before the background task has completed its work. As soon as the [Run](ibackgroundtask_run.md) method returns, the system might suspend or terminate the background task host process, which could prevent completion of asynchronous operations started by the background task.

To keep the host process from being suspended or terminated while the background task is running, use the [GetDeferral](ibackgroundtaskinstance_getdeferral.md) method to get a background task deferral for each asynchronous operation initiated. Then, when the asynchronous operation is finished, call the [BackgroundTaskDeferral.Complete](backgroundtaskdeferral_complete.md) method.

Ensure that you complete all background task deferrals. Most background tasks have a timeout after which the app will be suspended or terminated regardless of whether there are any pending deferrals. However, leaving outstanding background task deferrals interferes with the system's ability to manage process lifetimes in a timely way.

## -examples

## -see-also
