---
-api-id: T:Windows.Storage.Provider.IStorageProviderSuggestionsHandlerFactory
-api-type: winrt interface
---

# Windows.Storage.Provider.IStorageProviderSuggestionsHandlerFactory

<!--
public interface IStorageProviderSuggestionsHandlerFactory
-->

## -description

This interface is implemented by a cloud files provider to create a suggestions handler that can be used to query for suggested files from the provider.

> [!IMPORTANT]
> The **Windows.Storage.Provider.IStorageProviderSuggestionsHandlerFactory** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -remarks

The suggestions handler factory is activated in the cloud files provider process as a local server and creates a suggestions handler for a given sync root identifier.

## -see-also

## -examples
