---
-api-id: M:Windows.Storage.Provider.IStorageProviderSuggestionsHandler.Remove(Windows.Storage.Provider.StorageProviderResultKind,System.String)
-api-type: winrt method
---

# Windows.Storage.Provider.IStorageProviderSuggestionsHandler.Remove(Windows.Storage.Provider.StorageProviderResultKind,System.String)

<!--
public void Remove (Windows.Storage.Provider.StorageProviderResultKind kind, string remoteFileId);
-->

## -description

Removes an item from the cloud storage provider's suggestions of the given result kind.

> [!IMPORTANT]
> The **Windows.Storage.Provider.IStorageProviderSuggestionsHandler** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -parameters

### -param kind

The kind of item to remove.

### -param remoteFileId

The remote file ID of the item to remove. See [StorageProviderSuggestionResult.RemoteFileId](storageprovidersuggestionresult_remotefileid.md).

## -remarks

After **Remove** is successfully called for an item, the cloud storage provider should ensure that the item is never returned in future calls to [GetSuggestions](istorageprovidersuggestionshandler_getsuggestions_613374749.md) for that result kind.

To support offline scenarios and improve reliability, the cloud storage provider should ensure that removed suggestions are cached locally and synchronized with any backing service once service connectivity is restored.

If the given [StorageProviderResultKind](storageproviderresultkind.md) is not supported by the cloud provider, they should no-op the API call.

The given remote file ID will be the same value as the [System.StorageProviderFileIdentifier](windows/desktop/properties/props-system-storageproviderfileidentifier) property for the item. The ID may not correspond to an item returned by a previous call to [GetSuggestions](istorageprovidersuggestionshandler_getsuggestions_613374749.md). This can occur if the user interacts with an item in the provider's sync root (for example, hiding an item located in the provider's sync root that is already present in the local recents list).

## -see-also

## -examples
