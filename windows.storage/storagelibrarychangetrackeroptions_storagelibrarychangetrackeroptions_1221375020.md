---
-api-id: M:Windows.Storage.StorageLibraryChangeTrackerOptions.#ctor
-api-type: winrt constructor
---

# Windows.Storage.StorageLibraryChangeTrackerOptions.#ctor

<!--
public StorageLibraryChangeTrackerOptions ();
-->


## -description
Constructor for the [StorageLibraryChangeTrackerOptions](storagelibrarychangetrackeroptions.md) to be used to setup the behavior of the change tracker for a StorageFolder or StorageLibrary.

## -remarks

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

