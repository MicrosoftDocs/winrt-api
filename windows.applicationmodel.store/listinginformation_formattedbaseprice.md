---
-api-id: P:Windows.ApplicationModel.Store.ListingInformation.FormattedBasePrice
-api-type: winrt property
---

<!-- Property syntax
public string FormattedBasePrice { get; }
-->

# Windows.ApplicationModel.Store.ListingInformation.FormattedBasePrice

## -description
Gets the app's base price formatted for the current market and currency.

## -property-value
The app's base price with the appropriate formatting for the current market and currency.

## -remarks
The base price is the default price for the app. If the app is on sale in the current market, use the [FormattedPrice](listinginformation_formattedprice.md) property to get the sale price. If the app is not on sale, FormattedBasePrice and [FormattedPrice](listinginformation_formattedprice.md) return the same value.

## -examples

## -see-also
[Put apps and add-ons on sale](/windows/uwp/publish/put-apps-and-add-ons-on-sale)
