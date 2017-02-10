---
-api-id: P:Windows.Globalization.GeographicRegion.CurrenciesInUse
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> CurrenciesInUse { get; }
-->

# Windows.Globalization.GeographicRegion.CurrenciesInUse

## -description
Gets the set of currencies in use in this region.

## -property-value
The set of ISO 4217 3-letter codes for the currencies that are used in the region.

## -remarks
If the region is a country, there is typically one currency, although some countries do have more than one currency in use. If the region is larger, the returned set includes the currencies in use in each of the contained regions/countries.

## -examples

## -see-also
