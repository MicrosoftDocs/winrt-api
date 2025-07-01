---
-api-id: T:Windows.Storage.Provider.StorageProviderSuggestionResult
-api-type: winrt class
---

# Windows.Storage.Provider.StorageProviderSuggestionResult

<!--
public sealed class StorageProviderSuggestionResult : Windows.Storage.Provider.IStorageProviderQueryResult
-->

## -description

The class that the storage provider will use to return individual file suggestions.

## -remarks

## -see-also

## -examples

The following is an example of a cloud storage provider handling a request for suggestions. The provider sends a request to the cloud storage service and receives a JSON response. The provider then parses the JSON response and returns the suggestions to the caller.

```cppwinrt
const auto c_sampleSuggestionsResponse =
    LR"({ "suggestionsKind": "Recent",
        "results": [
            {
                "filePath": "foo.txt",
                "id": "11",
                "requestedProperties": {
                    "System.DateModified": "2020-01-01T12:00:00Z"
                }
            },
            {
                "filePath": "bar.txt",
                "id": "12",
                "requestedProperties": {
                    "System.DateModified": "2020-01-01T12:00:00Z"
                }
            }
        ]
        })";

std::vector<IStorageProviderQueryResult> ParseSuggestionResponse(IHttpContent content, IVector<hstring> propertiesToFetch)
{
    // Parse the JSON response
    JsonArray results = JsonArray::Parse(c_sampleSuggestionsResponse);
    std::vector<IStorageProviderQueryResult> suggestionsResults;
    
    for (auto result : results)
    {
        hstring filePath = result.GetObject().GetNamedString(L"filePath");
        hstring id = result.GetObject().GetNamedString(L"id");
        
        StorageProviderSuggestionResult suggestionsResult;
        suggestionsResult.FilePath(filePath);
        suggestionsResult.ResultId(id);
        
        JsonObject requestedProperties = result.GetObject().GetNamedObject(L"requestedProperties");
        for (auto propertyName: propertiesToFetch)
        {
            if (requestedProperties.HasKey(propertyName))
            {
                hstring value = requestedProperties.GetNamedString(propertyName);
                suggestionsResult.RequestedProperties().Insert(propertyName, box_value(value));
            }
        }
        suggestionsResults.push_back(suggestionsResult);
    }
    
    return suggestionsResults;
}

winrt::CloudSearch::StorageProviderQueryResultSet MockSuggestionsHandler::GetSuggestions(winrt::CloudSearch::StorageProviderSuggestionsQueryOptions const& options)
{
    std::vector<IStorageProviderQueryResult> results;
    StorageProviderSearchQueryStatus status{ StorageProviderSearchQueryStatus::QueryNotSupported };
    
    Uri uri = GetSuggestionsUriFromOptions(options);
    if (uri)
    {
        HttpClient client;
        HttpResponseMessage response = client.GetAsync(uri).get();
        if (response.IsSuccessStatusCode())
        {
            results = ParseSuggestionResponse(response.Content(), options.PropertiesToFetch());
            status = StorageProviderSearchQueryStatus::Success;
        }
    }
    
    StorageProviderQueryResultSet resultSet(results);
    resultSet.Status(status);
    
    return resultSet;
}
```
