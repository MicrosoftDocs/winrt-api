---
-api-id: T:Windows.ApplicationModel.Background.BackgroundTaskDeferral
-api-type: winrt class
---

<!-- Class syntax.
public class BackgroundTaskDeferral : Windows.ApplicationModel.Background.IBackgroundTaskDeferral
-->

# Windows.ApplicationModel.Background.BackgroundTaskDeferral

## -description
Represents a background task deferral returned by the [IBackgroundTaskInstance.GetDeferral](ibackgroundtaskinstance_getdeferral_254836512.md) method.

## -examples
The following example shows how to use a background task deferral to delay a task from closing prematurely while asynchronous code is still running. Ensure that you complete all background task deferrals. Most background tasks have a timeout after which the app will be suspended or terminated regardless of whether there are any pending deferrals. However, leaving outstanding background task deferrals interferes with the system's ability to manage process lifetimes in a timely way.

```csharp
//
// Declare that your background task's Run method makes asynchronous calls by
// using the async keyword.
//
public async void Run(IBackgroundTaskInstance taskInstance)
{
    //
    // Create the deferral by requesting it from the task instance.
    //
    BackgroundTaskDeferral deferral = taskInstance.GetDeferral();
    
    //
    // Call asynchronous method(s) using the await keyword.
    //
    var result = await ExampleMethodAsync();

    //
    // Once the asynchronous method(s) are done, close the deferral.
    //
    deferral.Complete();
}
```



## -see-also
