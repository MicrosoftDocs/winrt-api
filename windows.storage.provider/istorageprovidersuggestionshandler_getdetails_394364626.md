---
-api-id: M:Windows.Storage.Provider.IStorageProviderSuggestionsHandler.GetDetails(System.String,System.String[],System.String)
-api-type: winrt method
---

# Windows.Storage.Provider.IStorageProviderSuggestionsHandler.GetDetails(System.String,System.String[],System.String)

<!--
public Windows.Storage.Provider.StorageProviderSuggestionResult GetDetails (string remoteFileId, string[] propertiesToFetch, string queryId);
-->

## -description

Get additional metadata of a single file suggestion.

## -parameters

### -param remoteFileId

The remote ID of the file.

### -param propertiesToFetch

The properties to fetch.

### -param queryId

The query ID.

## -returns

The result of the operation as a [StorageProviderSuggestionResult](storageprovidersuggestionresult.md).

## -remarks

This is expected to be a blocking call and should not be called on a UI thread.

## -see-also

## -examples

The following is an example of how Windows File Explorer would call **GetDetails** to populate the details pane:

```cppwinrt
void GetDetails()
{
    MockSuggestionsHandler searchHandler;
    hstring remoteFileId = L"11";
    std::array<hstring, 3> propertiesToFetch = { L"System.Authors", L"System.Home.RecentActivity", L"System.Home.RelatedDocuments"};
    hstring queryId = L"a0a0a0a0-bbbb-cccc-dddd-e1e1e1e1e1e1";
    auto result = searchHandler.GetDetails(remoteFileId, propertiesToFetch, queryId);
    for (auto pair : result.RequestedProperties())
    {
        // Use the requested properties to populate the details pane
    }
}
```
