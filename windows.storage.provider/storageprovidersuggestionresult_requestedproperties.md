---
-api-id: P:Windows.Storage.Provider.StorageProviderSuggestionResult.RequestedProperties
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderSuggestionResult.RequestedProperties

<!--
public Windows.Foundation.Collections.PropertySet RequestedProperties { get; }
-->

## -description

Gets the properties that were requested in [StorageProviderSuggestionsQueryOptions.PropertiesToFetch](storageprovidersuggestionsqueryoptions_propertiestofetch.md) for the suggestion result.

> [!IMPORTANT]
> The **Windows.Storage.Provider.StorageProviderSuggestionResult** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -property-value

The properties that were requested for the suggestion result.

## -remarks

The set of requested properties may vary depending on the [SuggestionKind](storageprovidersuggestionsqueryoptions_suggestionskind.md) assigned to the query, or the OS version. Unsupported or unrecognized properties should be ignored by the provider and omitted from the property set.

## -see-also

## -examples
