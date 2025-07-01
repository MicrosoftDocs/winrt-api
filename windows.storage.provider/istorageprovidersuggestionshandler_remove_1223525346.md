---
-api-id: M:Windows.Storage.Provider.IStorageProviderSuggestionsHandler.Remove(Windows.Storage.Provider.StorageProviderResultKind,System.String)
-api-type: winrt method
---

# Windows.Storage.Provider.IStorageProviderSuggestionsHandler.Remove(Windows.Storage.Provider.StorageProviderResultKind,System.String)

<!--
public void Remove (Windows.Storage.Provider.StorageProviderResultKind kind, string remoteFileId);
-->

## -description

Removes an item from the recent list of items.

> [!IMPORTANT]
> The **Windows.Storage.Provider.IStorageProviderSuggestionsHandler** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -parameters

### -param kind

The kind of item to remove.

### -param remoteFileId

The remote ID of the item to remove.

## -remarks

This is expected to be a blocking call and should not be called on a UI thread.

## -see-also

## -examples
