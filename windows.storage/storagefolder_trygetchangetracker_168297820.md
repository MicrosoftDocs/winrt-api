---
-api-id: M:Windows.Storage.StorageFolder.TryGetChangeTracker
-api-type: winrt method
---

<!-- Method syntax.
public StorageLibraryChangeTracker StorageFolder.TryGetChangeTracker()
-->

# Windows.Storage.StorageFolder.TryGetChangeTracker

## -description
Gets the [StorageLibraryChangeTracker](https://docs.microsoft.com/uwp/api/Windows.Storage.StorageLibraryChangeTracker) associated with a [StorageFolder](https://docs.microsoft.com/uwp/api/windows.storage.storagefolder).

## -returns
The [StorageLibraryChangeTracker](https://docs.microsoft.com/uwp/api/Windows.Storage.StorageLibraryChangeTracker) associated with a [StorageFolder](https://docs.microsoft.com/uwp/api/windows.storage.storagefolder).

## -remarks

## -see-also
[StorageLibraryChangeTrackerTrigger Class](https://docs.microsoft.com/uwp/api/windows.applicationmodel.background.storagelibrarychangetrackertrigger)

## -examples
This example demonstrates getting a StorageLibraryChangeTracker from a StorageFolder, and then enabling the tracker.

```csharp
private void EnableChangeTracker(StorageFolder folder) 
{ 
    // Get the change tracker object corresponding to the StorageFolder in the parameters 
    StorageLibraryChangeTracker tracker = folder.TryGetChangeTracker(); 
    if (tracker != null) 
    { 
        tracker.Enable(); 
    } 
} 
```

