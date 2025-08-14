---
-api-id: P:Windows.Storage.Provider.StorageProviderSearchQueryOptions.ProgrammaticQuery
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderSearchQueryOptions.ProgrammaticQuery

<!--
public string ProgrammaticQuery { get; }
-->

## -description

Gets the programmatic query string for the search query which can include additional conditions not directly entered by the user.

## -property-value

The programmatic query string.

## -remarks

This query will be in the AQS format, see [Advanced Query Syntax](/windows/win32/lwef/-search-2x-wds-aqsreference).

If a service can not preform the search with the given conditions, it should not return results.

## -see-also

## -examples
