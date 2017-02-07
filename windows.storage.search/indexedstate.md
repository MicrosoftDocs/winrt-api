---
-api-id: T:Windows.Storage.Search.IndexedState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.Search.IndexedState : int
-->

# IndexedState

## -description
Indicates whether a [StorageFolder](../windows.storage/storagefolder.md) is included in the system index.

## -enum-fields
### -field Unknown:0
The indexed state is not known.

### -field NotIndexed:1
The folder is not indexed.

### -field PartiallyIndexed:2
Some folders in the library are indexed, but not all of them. This value is relevant only for libraries.

### -field FullyIndexed:3
The folder contains indexed content. 

> [!NOTE]
> The folder might contain subfolders that are not indexed.


## -remarks

## -examples

## -see-also