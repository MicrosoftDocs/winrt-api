---
-api-id: P:Windows.ApplicationModel.Background.BackgroundTaskRegistration.AllTasks
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<System.Guid, Windows.ApplicationModel.Background.IBackgroundTaskRegistration> AllTasks { get; }
-->

# Windows.ApplicationModel.Background.BackgroundTaskRegistration.AllTasks

## -description
Enumerates an application's registered background tasks, except for the background tasks registered in a group with [Windows.ApplicationModel.Background.BackgroundTaskBuilder.TaskGroup](backgroundtaskbuilder_taskgroup.md).

## -property-value
A view into a map of registered background tasks consisting of the task ID and an [IBackgroundTaskRegistration](ibackgroundtaskregistration.md) interface.

## -remarks

## -examples
The following example shows how to use the [AllTasks](backgroundtaskregistration_alltasks.md) property of the [BackgroundTaskRegistration](backgroundtaskregistration.md) class to retrieve the existing background task registration object for your app's background task (if the task is currently registered).

```csharp
// The name of the background task for your app.
string name = "ExampleTaskName";

// Get a list of all background tasks. The list is returned as
// a dictionary of IBackgroundTaskRegistration objects.
foreach (var cur in BackgroundTaskRegistration.AllTasks)
{
    if (cur.Value.Name == name)
    {
        // Take some action based on finding the background task.
        //
        // For example, unregister the task: cur.Value.Unregister(true);
        // Or, set a global variable indicating that the task is already registered
    }
}
```

## -see-also
[Windows.ApplicationModel.Background.BackgroundTaskBuilder.TaskGroup](backgroundtaskbuilder_taskgroup.md)
