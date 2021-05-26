---
-api-id: M:Windows.Storage.StorageLibraryChangeTracker.Enable(Windows.Storage.StorageLibraryChangeTrackerOptions)
-api-type: winrt method
---

# Windows.Storage.StorageLibraryChangeTracker.Enable(Windows.Storage.StorageLibraryChangeTrackerOptions)

<!--
public void Enable (Windows.Storage.StorageLibraryChangeTrackerOptions options);
-->


## -description
Enables change tracking for the storage library on all or the latest changes based on the change id.

## -parameters

### -param options
A [StorageLibraryChangeTrackerOptions](storagelibrarychangetrackeroptions.md) instance.

## -remarks
For applications only interested in the last change id, the system will not store all change records and bloat the storage on the device. In this case, ReadBatchAsync will always return 0 records. 

## -see-also
[StorageLibraryChangeTrackerOptions](storagelibrarychangetrackeroptions.md)

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
