---
-api-id: P:Windows.Storage.Provider.StorageProviderSuggestionResult.FilePath
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderSuggestionResult.FilePath

<!--
public string FilePath { get; set; }
-->

## -description

Gets or sets the local file path for the suggestion result.

> [!IMPORTANT]
> The **Windows.Storage.Provider.StorageProviderSuggestionResult** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -property-value

The local file path for the suggestion result.

## -remarks

When available, the cloud storage provider should set this property to the absolute file path where the item is stored in the user's sync root. For example, "C:\Users\Admin\ContosoDrive\foo.txt".

This property may be omitted if the suggestion does not have a representation on disk. For example, a file from a different user's cloud storage accessible through a cloud provider service. To support this case, Windows will request the remote URL of the file, represented by the **System.ContentUri** property in [PropertiesToFetch](storageprovidersuggestionsqueryoptions_propertiestofetch.md), which should be returned by the cloud storage provider in the result's [RequestedProperties](storageprovidersuggestionresult_requestedproperties.md).

## -see-also

## -examples
