---
-api-id: M:Windows.Storage.StorageLibraryChangeReader.GetLastChangeId
-api-type: winrt method
---

# Windows.Storage.StorageLibraryChangeReader.GetLastChangeId

<!--
public ulong GetLastChangeId ();
-->


## -description
Gets a unique value representing the last change processed by the indexing service for the given StorageFolder or StorageLibrary.

## -returns
A valid change id (> 0) if there have been changes.

Returns 0 if there have been no changes since the last time read or no changes have occurred yet.

Returns StorageLibraryChangeId::Unknown if the change tracker cannot compute the change id, or too many file changes have happened and this value overflows.

## -remarks

## -see-also
[StorageLibraryChangeReader](storagelibrarychangereader.md), [StorageLibraryLastChangeId](storagelibrarylastchangeid.md)

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