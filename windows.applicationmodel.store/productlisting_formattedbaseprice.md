---
-api-id: P:Windows.ApplicationModel.Store.ProductListing.FormattedBasePrice
-api-type: winrt property
---

<!-- Property syntax
public string FormattedBasePrice { get; }
-->

# Windows.ApplicationModel.Store.ProductListing.FormattedBasePrice

## -description
Gets the base price for the add-on (also called an in-app product or IAP) with the appropriate formatting for the current market.

## -property-value
The base price for the add-on with the appropriate formatting for the current market.

## -remarks
The base price is the default price for the add-on. If the add-on is on sale in the current market, use the [FormattedPrice](productlisting_formattedprice.md) property to get the sale price. If the add-on is not on sale, FormattedBasePrice and [FormattedPrice](productlisting_formattedprice.md) return the same value.

## -examples

## -see-also
