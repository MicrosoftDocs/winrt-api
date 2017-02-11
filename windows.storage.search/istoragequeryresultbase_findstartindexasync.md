---
-api-id: M:Windows.Storage.Search.IStorageQueryResultBase.FindStartIndexAsync(System.Object)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<uint> FindStartIndexAsync(System.Object value)
-->

# Windows.Storage.Search.IStorageQueryResultBase.FindStartIndexAsync

## -description
Retrieves the index of the file from the query results that most closely matches the specified property value. The property that is matched is determined by the first [SortEntry](sortentry.md) of the [QueryOptions.SortOrder](queryoptions_sortorder.md) list.

## -parameters
### -param value
The property value to match when searching the query results.

## -returns
When this method completes successfully it returns the index of the matched item in the query results.

## -remarks
You can use this index in conjunction with Semantic Zoom to determine where the page should be zoomed in after the user selects the Semantic Zoom control.

## -examples

## -see-also
