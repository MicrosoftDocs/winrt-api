---
-api-id: M:Windows.Storage.Provider.IStorageProviderSuggestionsHandlerFactory.CreateSuggestionsHandler(System.String)
-api-type: winrt method
---

# Windows.Storage.Provider.IStorageProviderSuggestionsHandlerFactory.CreateSuggestionsHandler(System.String)

<!--
public Windows.Storage.Provider.IStorageProviderSuggestionsHandler CreateSuggestionsHandler (string cloudProviderId);
-->

## -description

Creates a suggestions handler for a given sync root identifier.

> [!IMPORTANT]
> The **Windows.Storage.Provider.IStorageProviderSuggestionsHandlerFactory** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -parameters

### -param cloudProviderId

The sync root identifier for the cloud files provider, see [SyncRootId](./storageprovidersyncrootinfo_id.md).

## -returns

Returns a suggestions handler that can be used to query for suggested files from the provider.

## -remarks

## -see-also

## -examples
