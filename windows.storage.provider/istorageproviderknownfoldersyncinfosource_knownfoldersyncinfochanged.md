---
-api-id: E:Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSource.KnownFolderSyncInfoChanged
-api-type: winrt event
---

# Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSource.KnownFolderSyncInfoChanged

<!--
event Windows.Foundation.TypedEventHandler<Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSource,object> KnownFolderSyncInfoChanged;
-->

## -description

The event that is raised when the sync status of a known folder changes.

## -remarks

To update any property on [StorageProviderKnownFolderSyncInfo](storageproviderknownfoldersyncinfo.md), the cloud provider should raise the **KnownFolderSyncInfoChanged** event and be ready to provide a new **StorageProviderKnownFolderSyncInfo** object.

## -see-also

[StorageProviderKnownFolderSyncInfo](storageproviderknownfoldersyncinfo.md)

## -examples
