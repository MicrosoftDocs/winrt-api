---
-api-id: T:Windows.Storage.Search.IndexerOption
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.Search.IndexerOption : int
-->

# IndexerOption

## -description
Specifies whether the query should use the system index of the file system when enumerating content in the folder being queried. The indexer can retrieve results faster but is not available in all file locations.

## -enum-fields
### -field UseIndexerWhenAvailable:0
Use the system index for content that has been indexed and use the file system directly for content that has not been indexed.

### -field OnlyUseIndexer:1
Use only indexed content and ignore content that has not been indexed.

### -field DoNotUseIndexer:2
Access the file system directly; don't use the system index.

### -field OnlyUseIndexerAndOptimizeForIndexedProperties:3
Only returns the properties specified in [QueryOptions.SetPropertyPrefetch](queryoptions_setpropertyprefetch_770511515.md) for faster results.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | OnlyUseIndexerAndOptimizeForIndexedProperties |

## -examples

## -see-also
