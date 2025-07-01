---
-api-id: M:Windows.Storage.Provider.IStorageProviderSuggestionsHandlerFactory.CreateSuggestionsHandler(System.String)
-api-type: winrt method
---

# Windows.Storage.Provider.IStorageProviderSuggestionsHandlerFactory.CreateSuggestionsHandler(System.String)

<!--
public Windows.Storage.Provider.IStorageProviderSuggestionsHandler CreateSuggestionsHandler (string cloudProviderId);
-->

## -description

Activated in the cloud provider process as a local server and creates a suggestions handler for a given sync root identifier to provide suggestions for files and folders in a location that the provider manages.

> [!IMPORTANT]
> The **Windows.Storage.Provider.IStorageProviderSuggestionsHandlerFactory** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -parameters

### -param cloudProviderId

The identifier for the sync root that the suggestions handler will provide suggestions for.

## -returns

The suggestions handler for the specified sync root identifier.

## -remarks

## -see-also

## -examples
