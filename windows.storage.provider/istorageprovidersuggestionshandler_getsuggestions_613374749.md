---
-api-id: M:Windows.Storage.Provider.IStorageProviderSuggestionsHandler.GetSuggestions(Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions)
-api-type: winrt method
---

# Windows.Storage.Provider.IStorageProviderSuggestionsHandler.GetSuggestions(Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions)

<!--
public Windows.Storage.Provider.StorageProviderQueryResultSet GetSuggestions (Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions options);
-->

## -description

Implemented by cloud provider to return the list of recent or recommended files.

## -parameters

### -param options

The [StorageProviderSuggestionsQueryOptions](storageprovidersuggestionsqueryoptions.md) to use to get the list of results.

## -returns

Returns a [StorageProviderQueryResultSet](storageproviderqueryresultset.md) object that contains the list of results.

## -remarks

If this scenario is supported by a cloud provider they should return a [StorageProviderQueryResultSet](storageproviderqueryresultset.md) object with the **Status** set to **NotSupported**.

This is expected to be a blocking call and should not be called on a UI thread.

## -see-also

## -examples

The following is an example of how Windows File Explorer would call **GetSuggestions** to get related files for the details pane:

```cppwinrt
void GetRelatedFiles(hstring remoteFileId)
{
    MockSuggestionsHandler searchHandler;
    auto propertiesToFetch = single_threaded_vector<hstring>({ L"System.DisplayName", L"System.DateModified"});
    auto options = winrt::make_self<winrt::CloudSearch::implementation::StorageProviderSuggestionsQueryOptions>();
    options->SuggestionsKind(winrt::CloudSearch::StorageProviderResultKind::RelatedFiles);
    options->PropertiesToFetch(propertiesToFetch.GetView());
    options->RemoteFileId(remoteFileId);
    auto queryResult = searchHandler.GetSuggestions(options.as<winrt::CloudSearch::StorageProviderSuggestionsQueryOptions>());
    if (queryResult.Status() == StorageProviderSearchQueryStatus::Success)
    {
        auto results = queryResult.GetResults();
        for (auto result : results)
        {
            // Use the results to populate the details pane
        }
    }
    else
    {
        // Handle error
    }
}
```
