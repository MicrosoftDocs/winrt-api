---
-api-id: M:Windows.Storage.Search.ContentIndexer.CreateQuery(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Foundation.Collections.IIterable{Windows.Storage.Search.SortEntry})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.ContentIndexerQuery CreateQuery(System.String searchFilter, Windows.Foundation.Collections.IIterable<System.String> propertiesToRetrieve, Windows.Foundation.Collections.IIterable<Windows.Storage.Search.SortEntry> sortOrder)
-->

# Windows.Storage.Search.ContentIndexer.CreateQuery

## -description
Builds a query with the specified search filter, sort order, and identifies which properties to retrieve.

## -parameters
### -param searchFilter
The Advanced Query Syntax (AQS) filter.

### -param propertiesToRetrieve
The properties to retrieve, specified by their Windows canonical property names.

### -param sortOrder
The sort order for the filtered results.

## -returns
The query.

## -remarks

## -examples

## -see-also
[CreateQuery(String, IIterable(String), IIterable(SortEntry), String)](contentindexer_createquery_2143311724.md), [CreateQuery(String, IIterable(String))](contentindexer_createquery_293378840.md), [GetPropertiesAsync](/uwp/api/windows.storage.search.contentindexerquery.getpropertiesasync)