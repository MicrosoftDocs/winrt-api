---
-api-id: T:Windows.Storage.Provider.StorageProviderKnownFolderSyncInfo
-api-type: winrt class
---

# Windows.Storage.Provider.StorageProviderKnownFolderSyncInfo

<!--
public sealed class StorageProviderKnownFolderSyncInfo
-->

## -description

The **StorageProviderKnownFolderSyncInfo** class encapsulates all the information relevant to the provider’s backup/sync capability and status.

## -remarks

**StorageProviderKnownFolderSyncInfo** lets the provider specify a friendly name and status for known folders. Once the object is returned by [GetKnownFolderSyncInfoSource](istorageproviderknownfoldersyncinfosourcefactory_getknownfoldersyncinfosource_1598084472.md) it should be considered immutable. Changing a property on the object after it has been returned could result in undefined behavior. To update any property on **StorageProviderKnownFolderSyncInfo**, the cloud provider should raise the [KnownFolderSyncInfoChanged](istorageproviderknownfoldersyncinfosource_knownfoldersyncinfochanged.md) event on [IStorageProviderKnownFolderSyncInfoSource](istorageproviderknownfoldersyncinfosource.md) and be ready to provide a new **StorageProviderKnownFolderSyncInfo** object.

Any missing property or invalid Uri on the **StorageProviderKnownFolderSyncInfo** will result in the enrollment button not being shown for this provider.

## -see-also

[GetKnownFolderSyncInfoSource](istorageproviderknownfoldersyncinfosourcefactory_getknownfoldersyncinfosource_1598084472.md), [KnownFolderSyncInfoChanged](istorageproviderknownfoldersyncinfosource_knownfoldersyncinfochanged.md), [IStorageProviderKnownFolderSyncInfoSource](istorageproviderknownfoldersyncinfosource.md)

## -examples
