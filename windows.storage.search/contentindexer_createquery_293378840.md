---
-api-id: M:Windows.Storage.Search.ContentIndexer.CreateQuery(System.String,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.ContentIndexerQuery CreateQuery(System.String searchFilter, Windows.Foundation.Collections.IIterable<System.String> propertiesToRetrieve)
-->

# Windows.Storage.Search.ContentIndexer.CreateQuery

## -description
Builds a query with the specified search filter and identifies which properties to retrieve.

## -parameters
### -param searchFilter
The Advanced Query Syntax (AQS) filter to apply.

### -param propertiesToRetrieve
The properties to retrieve, specified by their Windows canonical property names.

## -returns
The query.

## -remarks
Call the [GetPropertiesAsync](contentindexerquery_getpropertiesasync_1672422196.md) method to run the query.

## -examples

## -see-also
[CreateQuery(String, IIterable(String), IIterable(SortEntry), String)](contentindexer_createquery_2143311724.md), [CreateQuery(String, IIterable(String), IIterable(SortEntry))](contentindexer_createquery_1278239124.md), [GetPropertiesAsync](/uwp/api/windows.storage.search.contentindexerquery.getpropertiesasync)