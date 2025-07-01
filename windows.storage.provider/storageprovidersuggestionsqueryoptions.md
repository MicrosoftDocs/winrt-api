---
-api-id: T:Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions
-api-type: winrt class
---

# Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions

<!--
public sealed class StorageProviderSuggestionsQueryOptions
-->

## -description

Provides options for the [GetSuggestions](istorageprovidersuggestionshandler_getsuggestions_613374749.md) call to get suggestions for files or folders.

> [!IMPORTANT]
> The **Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -remarks

## -see-also

## -examples

The following is an example of how Windows would make a request for recent files using the suggestions handler:

```cppwinrt
winrt::fire_and_forget GetRecentFiles()
{
    MockSuggestionsHandler searchHandler;
    auto propertiesToFetch = single_threaded_vector<hstring>({ L"System.DateModified" });
    auto options = winrt::make_self<winrt::CloudSearch::implementation::StorageProviderSuggestionsQueryOptions>();
    options->SuggestionsKind(winrt::CloudSearch::StorageProviderResultKind::Recent);
    options->PropertiesToFetch(propertiesToFetch.GetView());
    auto queryResult = searchHandler.GetSuggestions(options.as<winrt::CloudSearch::StorageProviderSuggestionsQueryOptions>());
    if (queryResult.Status() == StorageProviderSearchQueryStatus::Success)
    {
        auto results = queryResult.GetResults();
        for (auto result : results)
        {
            // Handle the result
        }
    }
    else
    {
        // Handle error
    }
}
```
