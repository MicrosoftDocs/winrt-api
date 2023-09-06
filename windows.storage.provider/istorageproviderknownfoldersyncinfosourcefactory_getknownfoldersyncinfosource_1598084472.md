---
-api-id: M:Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSourceFactory.GetKnownFolderSyncInfoSource
-api-type: winrt method
---

# Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSourceFactory.GetKnownFolderSyncInfoSource

<!--
public Windows.Storage.Provider.IStorageProviderKnownFolderSyncInfoSource GetKnownFolderSyncInfoSource ();
-->

## -description

The method that File Explorer calls to obtain an instance of [IStorageProviderKnownFolderSyncInfoSource](istorageproviderknownfoldersyncinfosource.md) for a given provider.

## -returns

## -remarks

Changing a property on the object after it has been returned by **GetKnownFolderSyncInfoSource** could result in undefined behavior. To update any property on [StorageProviderKnownFolderSyncInfo](storageproviderknownfoldersyncinfo.md), the cloud provider should raise the [KnownFolderSyncInfoChanged](istorageproviderknownfoldersyncinfosource_knownfoldersyncinfochanged.md) event on **IStorageProviderKnownFolderSyncInfoSource** and be ready to provide a new **StorageProviderKnownFolderSyncInfo** object.

## -see-also

[IStorageProviderKnownFolderSyncInfoSource](istorageproviderknownfoldersyncinfosource.md), [StorageProviderKnownFolderSyncInfo](storageproviderknownfoldersyncinfo.md), [KnownFolderSyncInfoChanged](istorageproviderknownfoldersyncinfosource_knownfoldersyncinfochanged.md)

## -examples
