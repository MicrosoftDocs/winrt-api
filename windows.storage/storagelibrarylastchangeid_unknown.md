---
-api-id: P:Windows.Storage.StorageLibraryLastChangeId.Unknown
-api-type: winrt property
---

# Windows.Storage.StorageLibraryLastChangeId.Unknown

<!--
public static ulong Unknown { get; }
-->


## -description
Returned when the USN journal overflows and the service cannot keep up with changes or there is another reason the change id cannot be computed.

## -property-value
A read-only unique identifier that indicates the change id cannot be computed.

## -remarks

## -see-also
[StorageLibraryLastChangeId](storagelibrarylastchangeid.md)

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
