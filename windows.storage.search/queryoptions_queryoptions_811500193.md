---
-api-id: M:Windows.Storage.Search.QueryOptions.#ctor(Windows.Storage.Search.CommonFileQuery,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public QueryOptions(Windows.Storage.Search.CommonFileQuery query, Windows.Foundation.Collections.IIterable<System.String> fileTypeFilter)
-->

# Windows.Storage.Search.QueryOptions.QueryOptions

## -description
Creates an instance of the [QueryOptions](queryoptions.md) class for enumerating files and initializes it with values provided by the specified [CommonFileQuery](commonfilequery.md) and an optional file type filter that determines which files to include in query results.

## -parameters
### -param query
An enumeration value that specifies the search parameters to use to query files.

The [CommonFileQuery](commonfilequery.md) enumeration provides search parameters for several common types of file queries. For example, deep queries that retrieve all the files in the folder where the query is created or shallow queries that retrieve only the files in the top-level of the folder. The enumeration also determines how query results are sorted.

### -param fileTypeFilter
An array of file types to be included in the query results. To include all file types, supply null, an empty array, or an array containing a single entry of "*".

## -remarks

## -examples

## -see-also
[QueryOptions(CommonFolderQuery)](queryoptions_queryoptions_1209951623.md)
