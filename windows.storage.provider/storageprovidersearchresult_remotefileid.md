---
-api-id: P:Windows.Storage.Provider.StorageProviderSearchResult.RemoteFileId
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderSearchResult.RemoteFileId

<!--
public string RemoteFileId { get; set; }
-->

## -description

Gets or sets the remote file ID of the search result.

## -property-value

The remote file ID of the search result.

## -remarks

This identifier is expected to be unique across all query results and items in the provider's sync root.

The cloud storage provider should set this property to the same value as the [System.StorageProviderFileIdentifier](/windows/desktop/properties/props-system-storageproviderfileidentifier) property for the item. This ensures a consistent file identifier across query results and items in the provider's sync root.

## -see-also

## -examples
