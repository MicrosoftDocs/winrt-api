---
-api-id: P:Windows.ApplicationModel.Store.ListingInformation.FormattedPrice
-api-type: winrt property
---

<!-- Property syntax
public string FormattedPrice { get; }
-->

# Windows.ApplicationModel.Store.ListingInformation.FormattedPrice

## -description
Gets the app's purchase price formatted for the current market and currency.

## -property-value
The app's purchase price with the appropriate formatting for the current market and currency.

## -remarks
If the app is on sale in the current market, the [FormattedPrice](listinginformation_formattedprice.md) property returns the sale price. Use the [FormattedBasePrice](listinginformation_formattedbaseprice.md) property to get the default price. If the app is not on sale, [FormattedBasePrice](listinginformation_formattedbaseprice.md) and [FormattedPrice](listinginformation_formattedprice.md) return the same value.

## -examples

## -see-also
[Put apps on sale](m_selling.put_apps_and_iaps_on_sale)