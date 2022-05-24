---
-api-id: T:Windows.Storage.StorageLibraryChangeTrackerOptions
-api-type: winrt class
---

# Windows.Storage.StorageLibraryChangeTrackerOptions

<!--
public sealed class StorageLibraryChangeTrackerOptions
-->


## -description
Allows callers to call EnableWithOptions on the change tracker to choose to track all changes including last change id, or just the last change id. 

## -remarks
By default, enabling a change tracker on a specific library or folder will track all change details as well as keep track of the last change id. By setting StorageLibraryChangeTrackerOptions::TrackChangeDetails to false and using EnableWithOptions like the example below, the system will only keep track of the last change id which uses less system storage.

If your application doesn't need details about the changes, this is the recommended approach.

## -see-also
[StorageLibraryChangeTrackerOptions.TrackChangeDetails](storagelibrarychangetrackeroptions_trackchangedetails.md)

## -examples

```cpp
// applications are expected to persist the previous value
UINT64 appsLastPersistedChangeId = StorageLibraryLastChangeId::Unknown();
StorageFolder folder = StorageFolder::GetFolderFromPathAsync(L"my folder path").get();

StorageLibraryChangeTracker tracker = folder.TryGetChangeTracker();
if (tracker != nullptr)
{
StorageLibraryChangeTrackerOptions ops;
ops.TrackChangeDetails(false);
tracker.Enable(ops);

StorageLibraryChangeReader reader = tracker.GetChangeReader();
if (reader != nullptr)
{
    UINT32 changeId = reader.GetLastChangeId();
    if ((changeId == StorageLibraryLastChangeId::Unknown())
    {
        ScanFolderSlow();
    }
    else if (changeId == 0)
    {
        // no changes in the storage folder yet, OR nothing has changed
        ProcessNormalApplicationStartup();
    }
    else if (changeId != appsLastPersistedChangeId)
    {
        // There have been new changes since we’ve last ran, process them
        appsLastPersistedChangeId = changeId;
        ScanFolderForChanges();
    }
    else
    {
        // changeId and our last persisted change id match, also normal application startup
        ProcessNormalApplicationStartup();
    }
}
}
```
