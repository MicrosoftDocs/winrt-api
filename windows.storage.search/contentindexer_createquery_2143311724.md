---
-api-id: M:Windows.Storage.Search.ContentIndexer.CreateQuery(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Foundation.Collections.IIterable{Windows.Storage.Search.SortEntry},System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.ContentIndexerQuery CreateQuery(System.String searchFilter, Windows.Foundation.Collections.IIterable<System.String> propertiesToRetrieve, Windows.Foundation.Collections.IIterable<Windows.Storage.Search.SortEntry> sortOrder, System.String searchFilterLanguage)
-->

# Windows.Storage.Search.ContentIndexer.CreateQuery

## -description
Builds a query with the specified search filter, sort order, filter language, and identifies which properties to retrieve.

## -parameters
### -param searchFilter
The Advanced Query Syntax (AQS) filter to apply.

### -param propertiesToRetrieve
The properties to retrieve, specified by their Windows canonical property names.

### -param sortOrder
The sort order for the filtered results.

### -param searchFilterLanguage
The language that's used to parse Advanced Query Syntax (AQS), specified as a BCP-47 language tag.

## -returns
The query.

## -remarks

## -examples

## -see-also
[CreateQuery(String, IIterable(String), IIterable(SortEntry))](contentindexer_createquery_1278239124.md), [CreateQuery(String, IIterable(String))](contentindexer_createquery_293378840.md), [GetPropertiesAsync](/uwp/api/windows.storage.search.contentindexerquery.getpropertiesasync)