---
-api-id: P:Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions.PropertiesToFetch
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions.PropertiesToFetch

<!--
public System.Collections.Generic.IReadOnlyList<string> PropertiesToFetch { get; }
-->

## -description

Gets the vector of additional properties to return for each query result. These are canonical property names from the [Windows Property System](/windows/desktop/properties/windows-properties-system) (e.g. **System.FileName** or **System.DateModified**).

> [!IMPORTANT]
> The **Windows.Storage.Provider.StorageProviderSuggestionsQueryOptions** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -property-value

The vector of additional properties to return for each query result.

## -remarks

The set of requested properties may vary depending on the [SuggestionKind](storageprovidersuggestionsqueryoptions_suggestionskind.md) assigned to the query, or the OS version. Unsupported or unrecognized properties should be ignored by the provider.

## -see-also

[Windows Properties](/windows/desktop/properties/props)

## -examples
