---
-api-id: M:Windows.Storage.Provider.IStorageProviderSuggestionsHandler.GetSuggestions(Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions)
-api-type: winrt method
---

# Windows.Storage.Provider.IStorageProviderSuggestionsHandler.GetSuggestions(Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions)

<!--
public Windows.Storage.Provider.StorageProviderQueryResultSet GetSuggestions (Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions options);
-->

## -description

Executes the suggestions query given the parameters in the options object and returns a result set.

> [!IMPORTANT]
> The **Windows.Storage.Provider.IStorageProviderSuggestionsHandler** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -parameters

### -param options

The options used to customize the suggestions query.

## -returns

The result set object that contains the list of results.

## -remarks

The returned [StorageProviderQueryResultSet](storageproviderqueryresultset.md) is expected to return [StorageProviderSuggestionResult](storageprovidersuggestionresult.md) objects from its [GetResults](storageproviderqueryresultset_getresults_732303200.md) method.

If the [SuggestionsKind](storageprovidersuggestionsqueryoptions_suggestionskind.md) passed in the options object is not supported by the cloud provider, they should return a [StorageProviderQueryResultSet](storageproviderqueryresultset.md) object with the [Status](storageproviderqueryresultset_status.md) set to **QueryNotSupported**.

To support offline scenarios and improve reliability, the cloud storage provider should cache the results of any requests made to backing services and return cached results when appropriate.

## -see-also

## -examples

The following is an example of how a cloud storage provider could implement **GetSuggestions** to return recent files by parsing a JSON response returned from a cloud storage service:

```cppwinrt
constexpr auto c_sampleSuggestionsResponse =
    LR"({
        "suggestionsKind": "Recent",
        "results": [
            {
                "filePath": "C:\Users\UserA\ContosoDrive\foo.txt",
                "id": "11",
                "requestedProperties": {
                    "System.ItemNameDisplayWithoutExtension": "foo",
                    "System.FileExtension": ".txt",
                    "System.ContentUri": "https://contoso.com/UserA/foo.txt",
                    "System.DateAccessed": "2020-01-01T12:00:00Z"
                }
            },
            {
                "filePath": "",
                "id": "12",
                "requestedProperties": {
                    "System.ItemNameDisplayWithoutExtension": "bar",
                    "System.FileExtension": ".txt",
                    "System.ContentUri": "https://contoso.com/UserB/bar.txt",
                    "System.DateAccessed": "2020-01-01T12:00:00Z"
                }
            }
        ]
    })";

std::vector<StorageProviderSuggestionResult> ParseSuggestionResponse(IVectorView<hstring> propertiesToFetch)
{
    // Parse the JSON response
    const JsonObject response = JsonObject::Parse(c_sampleSuggestionsResponse);

    std::vector<StorageProviderSuggestionResult> suggestionResults;
    for (const auto& result : response.GetNamedArray(L"results"))
    {
        const JsonObject resultObject = result.GetObject();

        StorageProviderSuggestionResult suggestionResult;
        suggestionResult.Kind(StorageProviderResultKind::Recent);
        suggestionResult.FilePath(resultObject.GetNamedString(L"filePath"));
        suggestionResult.RemoteFileId(resultObject.GetNamedString(L"id"));

        const JsonObject requestedProperties = resultObject.GetNamedObject(L"requestedProperties");
        for (const auto& propertyName : propertiesToFetch)
        {
            if (const IJsonValue value = requestedProperties.TryLookup(propertyName))
            {
                suggestionResult.RequestedProperties().Insert(propertyName, box_value(value.GetString()));
            }
        }
        suggestionResults.push_back(std::move(suggestionResult));
    }

    return suggestionResults;
}

StorageProviderQueryResultSet GetSuggestions(StorageProviderSuggestionsQueryOptions const& options)
{
    StorageProviderSearchQueryStatus status{ StorageProviderSearchQueryStatus::QueryNotSupported };

    std::vector<StorageProviderSuggestionResult> results;
    if (options.SuggestionsKind() == StorageProviderResultKind::Recent)
    {
        results = ParseSuggestionResponse(options.PropertiesToFetch());
        status = StorageProviderSearchQueryStatus::Success;
    }

    StorageProviderQueryResultSet resultSet{ com_array<IStorageProviderQueryResult>(std::move(results)) };
    resultSet.Status(status);
    return resultSet;
}
```
