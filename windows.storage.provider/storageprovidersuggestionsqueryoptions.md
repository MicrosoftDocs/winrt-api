---
-api-id: T:Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions
-api-type: winrt class
---

# Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions

<!--
public sealed class StorageProviderSuggestionsQueryOptions
-->

## -description

Provides options for a suggestions query.

> [!IMPORTANT]
> The **Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -remarks

## -see-also

## -examples

The following is an example of how Windows would make a request for recent files using the suggestions handler:

```cppwinrt
auto propertiesToFetch = single_threaded_vector<hstring>(
    {
        L"System.ItemNameDisplayWithoutExtension",
        L"System.FileExtension",
        L"System.ContentUri",
        L"System.DateAccessed"
    });

auto options = winrt::make_self<implementation::StorageProviderSuggestionsQueryOptions>();
options->SuggestionsKind(StorageProviderResultKind::Recent);
options->MaxResults(100);
options->PropertiesToFetch(propertiesToFetch.GetView());

MockSuggestionsHandler suggestionsHandler;
auto queryResult = suggestionsHandler.GetSuggestions(options.as<StorageProviderSuggestionsQueryOptions>());
if (queryResult.Status() == StorageProviderSearchQueryStatus::Success)
{
    auto results = queryResult.GetResults();
    for (auto result : results)
    {
        auto suggestionResult = result.as<StorageProviderSuggestionResult>();
        // Use the result
    }
}
else
{
    // Handle error
}
```
