---
-api-id: P:Windows.Storage.Provider.StorageProviderSuggestionResult.RequestedProperties
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderSuggestionResult.RequestedProperties

<!--
public Windows.Foundation.Collections.PropertySet RequestedProperties { get; }
-->

## -description

Gets the properties that the app must provide to the storage provider to complete the suggested save operation.

## -property-value

The properties that the app must provide to the storage provider to complete the suggested save operation.

## -remarks

## -see-also

## -examples

The following is an example of how a CSP would provide additional details for a file suggestion:

```cppwinrt
StorageProviderSuggestionResult ParseDetailsResponse(IHttpContent content, array_view<hstring const> propertiesToFetch)
{
    JsonObject result = JsonObject::Parse(c_sampleSuggestionsResponse);
    StorageProviderSuggestionResult suggestionsResult;
    
    hstring filePath = result.GetNamedString(L"filePath");
    hstring id = result.GetNamedString(L"id");
    
    suggestionsResult.FilePath(filePath);
    suggestionsResult.ResultId(id);
    
    JsonObject requestedProperties = result.GetNamedObject(L"requestedProperties");
    for (auto propertyName : propertiesToFetch)
    {
        if (requestedProperties.HasKey(propertyName))
        {
            hstring value = requestedProperties.GetNamedString(propertyName);
            suggestionsResult.RequestedProperties().Insert(propertyName, box_value(value));
        }
    }
    
    return suggestionsResult;
}

winrt::CloudSearch::StorageProviderSuggestionResult MockSuggestionsHandler::GetDetails(hstring const& remoteFileId, array_view<hstring const> propertiesToFetch, hstring const& queryId)
{
    StorageProviderSuggestionResult result;
    
    Uri uri = GetDetailsUriFromRemoteFileId(remoteFileId);
    if (uri)
    {
        HttpClient client;
        IHttpContent requestBody = GetRequestBodyFromPropertiesToFetch(propertiesToFetch);
        
        HttpResponseMessage response = client.PostAsync(uri, requestBody).get();
        if (response.IsSuccessStatusCode())
        {
            result = ParseDetailsResponse(response.Content(), propertiesToFetch);
        }
    }
    
    return result;
}
```
