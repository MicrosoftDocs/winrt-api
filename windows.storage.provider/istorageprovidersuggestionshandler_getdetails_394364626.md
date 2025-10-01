---
-api-id: M:Windows.Storage.Provider.IStorageProviderSuggestionsHandler.GetDetails(System.String,System.String[],System.String)
-api-type: winrt method
---

# Windows.Storage.Provider.IStorageProviderSuggestionsHandler.GetDetails(System.String,System.String[],System.String)

<!--
public Windows.Storage.Provider.StorageProviderSuggestionResult GetDetails (string remoteFileId, string[] propertiesToFetch, string queryId);
-->

## -description

Get additional metadata for a single file suggestion.

> [!IMPORTANT]
> The **Windows.Storage.Provider.IStorageProviderSuggestionsHandler** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -parameters

### -param remoteFileId

The remote file ID of the file. See [StorageProviderSuggestionResult.RemoteFileId](storageprovidersuggestionresult_remotefileid.md).

### -param propertiesToFetch

The properties to fetch.

### -param queryId

The query ID.

## -returns

The result of the operation as a [StorageProviderSuggestionResult](storageprovidersuggestionresult.md).

## -remarks

## -see-also

## -examples
