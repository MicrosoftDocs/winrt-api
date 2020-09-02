---
-api-id: T:Windows.Storage.StorageLibraryChangeType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.StorageLibraryChangeType : int
-->

# StorageLibraryChangeType

## -description
Describes the type of change that occurred to the storage library item.

## -enum-fields
### -field Created:0
The item was created.

### -field Deleted:1
The item was deleted.

### -field MovedOrRenamed:2
The item was moved or renamed.

### -field ContentsChanged:3
The contents of the item changed.

### -field MovedOutOfLibrary:4
The item was moved out of a library.

### -field MovedIntoLibrary:5
The item was moved into a library

### -field ContentsReplaced:6
The contents have been replaced.

### -field IndexingStatusChanged:7
The item was changed from one where the content can be indexed to one where the content can't be indexed, or vice versa. Content indexing permits rapid searching of data by building a database of selected content.

### -field EncryptionChanged:8
The encryption applied to this item has changed.

### -field ChangeTrackingLost:9
The change tracking information associated with the item was lost. Call [Reset](storagelibrarychangetracker_reset_1636126115.md) to reestablish continuity with the storage library.


## -remarks

## -examples

## -see-also
[Track file system changes in the background](/windows/uwp/files/change-tracking-filesystem)
