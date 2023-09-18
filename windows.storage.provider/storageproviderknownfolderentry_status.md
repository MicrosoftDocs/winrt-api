---
-api-id: P:Windows.Storage.Provider.StorageProviderKnownFolderEntry.Status
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderKnownFolderEntry.Status

<!--
public Windows.Storage.Provider.StorageProviderKnownFolderSyncStatus Status { get; set; }
-->

## -description

The [StorageProviderKnownFolderSyncStatus](storageproviderknownfoldersyncstatus.md) of the known folder.

## -property-value

Gets or sets the sync enrollment status of the known folder.

## -remarks

The three possible states are:

- **Available**: A specific known folder is eligible to be backed up by the cloud provider and is not already enrolled or enrolling.
- **Enrolling**: A cloud provider started the process of enrolling a known folder. Typically, this represents the time during which files are moved from the known folder to the storage provider’s root and the known folder redirection is applied.
- **Enrolled**: A specific folder is already backed up by the cloud provider.

## -see-also

[StorageProviderKnownFolderSyncStatus](storageproviderknownfoldersyncstatus.md)

## -examples
