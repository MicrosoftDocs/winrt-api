---
-api-id: M:Windows.Storage.Search.ContentIndexerQuery.GetAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.Search.IIndexableContent>> GetAsync(System.UInt32 startIndex, System.UInt32 maxItems)
-->

# Windows.Storage.Search.ContentIndexerQuery.GetAsync

## -description
Runs the query on the app's indexed content properties and returns the specified number of items from the specified start index in the results collection.

## -parameters
### -param startIndex
The index of the first item to get from the results collection.

### -param maxItems
The maximum number of items to get.

## -returns
When this method completes, it returns the query results, represented as a collection of [IndexableContent](indexablecontent.md) instances.

## -remarks
Specifying *startIndex* and *maxItems* is useful for virtualization or paginated access of search results.

## -examples

## -see-also
[GetAsync](contentindexerquery_getasync_360625496.md), [IndexableContent](indexablecontent.md)