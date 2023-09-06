---
-api-id: T:Windows.Storage.Provider.StorageProviderKnownFolderSyncStatus
-api-type: winrt enum
---

# Windows.Storage.Provider.StorageProviderKnownFolderSyncStatus

<!--
public enum StorageProviderKnownFolderSyncStatus
-->

## -description

An enumeration that describes the sync enrollment status of a known folder.

## -enum-fields

### -field Available: 0

A specific known folder is eligible to be backed up by the cloud provider and is not already enrolled or enrolling.

### -field Enrolling: 1

A cloud provider started the process of enrolling a known folder. Typically, this represents the time during which files are moved from the known folder to the storage provider’s root and the known folder redirection is applied.

### -field Enrolled: 2

A specific folder is already backed up by the cloud provider.

## -remarks

The **StorageProviderKnownFolderSyncStatus** enumeration is used by the [Status](storageproviderknownfolderentry_status.md) property of the [StorageProviderKnownFolderEntry](storageproviderknownfolderentry.md) class.

## -see-also

[Status](storageproviderknownfolderentry_status.md), [StorageProviderKnownFolderEntry](storageproviderknownfolderentry.md)

## -examples
