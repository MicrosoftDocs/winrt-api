---
-api-id: M:Windows.Storage.Search.ContentIndexer.GetIndexer(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.ContentIndexer GetIndexer(System.String indexName)
-->

# Windows.Storage.Search.ContentIndexer.GetIndexer

## -description
Gets the per-app index with the specified name or creates a new one, if necessary.

## -parameters
### -param indexName
The index name.

## -returns
The index.

## -remarks
The app can provide an *indexName* identifier that it can use to partition data for its own queries. This identifier is included as part of the item scope, which means that it's faster to partition based on this scope than by filtering with a property. The approach has the cost of being unable to query easily across multiple scopes.

## -examples

## -see-also
[GetIndexer](contentindexer_getindexer_97502564.md)