---
-api-id: T:Windows.ApplicationModel.Background.StorageLibraryChangeTrackerTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class StorageLibraryChangeTrackerTrigger : IBackgroundTrigger
-->

# Windows.ApplicationModel.Background.StorageLibraryChangeTrackerTrigger

## -description
Represents a file change within a [StorageFolder](/uwp/api/windows.storage.storagefolder) that triggers a background task to run.

## -remarks
The background task must be declared in the manifest before the registration can be successful.

## -see-also
[Track file system changes in the background](/windows/uwp/files/change-tracking-filesystem),[Create and register an out-of-process background task](/windows/uwp/launch-resume/create-and-register-a-background-task),[Create and register an in-process background task](/windows/uwp/launch-resume/create-and-register-an-inproc-background-task)

## -examples

The following example shows how to create and register a storage library change trigger for the specified folder.

```csharp
private async Task<bool> RegisterBackgroundTask(StorageFolder folder)
{
    StorageLibraryChangeTracker tracker = folder.TryGetChangeTracker();
    if (tracker != null)
    {
        tracker.Enable();

        StorageLibraryChangeTrackerTrigger trigger = new StorageLibraryChangeTrackerTrigger(tracker);

        string name = "StorageLibraryChangeTrackerTask"; // a friendly task name
        string taskEntryPoint = "Tasks.StorageLibraryChangeTrackerTask";

        var access = await BackgroundExecutionManager.RequestAccessAsync(); // to register background tasks, you must first call RequestAccessAsync()

        BackgroundTaskBuilder builder = new BackgroundTaskBuilder();
        builder.Name = name;
        builder.TaskEntryPoint = taskEntryPoint;
        builder.SetTrigger(trigger);
        BackgroundTaskRegistration task = builder.Register();

        return true;
    }

    // Not getting a tracker means we don't have access to the folder or it’s not a physical folder
    return false;
}
```
