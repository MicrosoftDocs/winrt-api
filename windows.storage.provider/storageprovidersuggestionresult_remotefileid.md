---
-api-id: P:Windows.Storage.Provider.StorageProviderSuggestionResult.RemoteFileId
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderSuggestionResult.RemoteFileId

<!--
public string RemoteFileId { get; set; }
-->

## -description

Gets or sets the remote file ID of the suggestion result.

> [!IMPORTANT]
> The **Windows.Storage.Provider.StorageProviderSuggestionResult** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -property-value

The remote file ID of the suggestion result.

## -remarks

The cloud storage provider should set this property to the same value as the [System.StorageProviderFileIdentifier](/windows/desktop/properties/props-system-storageproviderfileidentifier) property for the item. This ensures a consistent file identifier across suggestion results and files in the provider's sync root.

## -see-also

## -examples
