---
-api-id: P:Windows.ApplicationModel.Store.ProductListing.FormattedPrice
-api-type: winrt property
---

<!-- Property syntax
public string FormattedPrice { get; }
-->

# Windows.ApplicationModel.Store.ProductListing.FormattedPrice

## -description
Gets the purchase price for the in-app product with the appropriate formatting for the current market.

## -property-value
The purchase price with the appropriate formatting for the current market.

## -remarks
If the in-app product is on sale in the current market, the FormattedPrice property returns the sale price. Use the [FormattedBasePrice](productlisting_formattedbaseprice.md) property to get the default price. If the in-app product is not on sale, [FormattedBasePrice](productlisting_formattedbaseprice.md) and FormattedPrice return the same value.

## -examples

## -see-also
