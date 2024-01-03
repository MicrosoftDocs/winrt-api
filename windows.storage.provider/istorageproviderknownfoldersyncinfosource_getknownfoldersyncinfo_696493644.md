---
-api-id: M:Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSource.GetKnownFolderSyncInfo
-api-type: winrt method
---

# Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSource.GetKnownFolderSyncInfo

<!--
public Windows.Storage.Provider.StorageProviderKnownFolderSyncInfo GetKnownFolderSyncInfo ();
-->

## -description

**GetKnownFolderSyncInfo** is called by File Explorer whenever it needs to get the latest known folder sync status from the cloud provider.

## -returns

Returns a [StorageProviderKnownFolderSyncInfo](storageproviderknownfoldersyncinfo.md) object that contains the latest known folder sync status.

## -remarks

Once returned, the [StorageProviderKnownFolderSyncInfo](storageproviderknownfoldersyncinfo.md) is considered immutable.

A [SyncRequested](storageproviderknownfoldersyncinfo_syncrequested.md) handler must be set on the returned object to be considered valid and to be displayed in File Explorer.

## -see-also

[StorageProviderKnownFolderSyncInfo](storageproviderknownfoldersyncinfo.md), [SyncRequested](storageproviderknownfoldersyncinfo_syncrequested.md)

## -examples

The following example shows how to implement **GetKnownFolderSyncInfo** in a cloud provider.

```cppwinrt
StorageProviderKnownFolderSyncInfo MyKnownFolderInfoSource::GetKnownFolderSyncInfo()
{
    winrt::StorageProviderKnownFolderSyncInfo info{};
    info.ProviderDisplayName(GetProviderDisplayName());

    // Setting a SyncRequested handler to respond to user action.
    auto syncRequestHandler = [](
    winrt::CloudMirror::StorageProviderKnownFolderSyncRequestArgs const& args)
    {
        // The user wants to sync some known folders with our cloud provider.
        // We can show some UI to sign in, confirm their choice, etc.
        MyStorageProviderSyncManager::ShowFolderEnrollmentUI(args.KnownFolders(), args.Source());

        // Or we can immediately start syncing the requested folders.
        MyStorageProviderSyncManager::StartSyncingFolders(args.KnownFolders(), args.Source());
    };

    info.SyncRequested(syncRequestHandler);
    info.KnownFolderEntries().ReplaceAll(m_knownFolderEntries);

    return info;
}
```
