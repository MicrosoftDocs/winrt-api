---
-api-id: P:Windows.Storage.Search.QueryOptions.UserSearchFilter
-api-type: winrt property
---

<!-- Property syntax
public string UserSearchFilter { get;  set; }
-->

# Windows.Storage.Search.QueryOptions.UserSearchFilter

## -description
Gets or sets a user-defined Advanced Query Syntax (AQS) string for filtering files by keywords or properties. This property is combined with the [ApplicationSearchFilter](queryoptions_applicationsearchfilter.md) to create the query's search filter.

## -property-value
A simple keyword or a string that conforms to Advanced Query Syntax (AQS). For more information, see [Using Advanced Query Syntax Programmatically](/windows/desktop/search/-search-3x-advancedquerysyntax).

## -remarks
Windows builds the search query by combining this property with the [ApplicationSearchFilter](queryoptions_applicationsearchfilter.md) property.

## -examples

## -see-also
