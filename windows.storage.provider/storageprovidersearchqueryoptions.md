---
-api-id: T:Windows.Storage.Provider.StorageProviderSearchQueryOptions
-api-type: winrt class
---

# Windows.Storage.Provider.StorageProviderSearchQueryOptions

<!--
public sealed class StorageProviderSearchQueryOptions
-->

## -description

Provides options for a search query.

## -remarks

## -see-also

## -examples

The following is an example of how Windows would make a query using the cloud files search API:

```cppwinrt
MockSearchHandler searchHandler;
winrt::CloudSearch::StorageProviderSearchQueryOptions options = winrt::make<CloudSearch::implementation::StorageProviderSearchQueryOptions>(L"dog");
auto queryResult = searchHandler.Find(options);
if (queryResult.Status() == StorageProviderSearchQueryStatus::Success)
{
    auto results = queryResult.GetResults();
    for (auto result : results)
    {
        // Handle search results
    }
}
else
{
    // Handle error
}
```
