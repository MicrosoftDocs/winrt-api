---
-api-id: P:Windows.Storage.StorageLibraryChangeTrackerOptions.TrackChangeDetails
-api-type: winrt property
---

# Windows.Storage.StorageLibraryChangeTrackerOptions.TrackChangeDetails

<!--
public bool TrackChangeDetails { get; set; }
-->


## -description
Used to determine if the system will track each individual change or just the last change id for a given change tracker.

## -property-value
A boolean value that determines if the change tracker should track all change details or just the last change id. If not set or modified, this defaults to true.

## -remarks
TrackChangeDetails is true by default for all change trackers. You can set this to false when passed to StorageLibraryChangeTracker::EnableWithOptions in order to save on system storage if the application is only concerned about the last change id, and not details about each individual change.

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
