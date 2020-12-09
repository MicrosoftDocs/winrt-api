---
-api-id: T:Windows.ApplicationModel.Store.ProductListing
-api-type: winrt class
---

<!-- Class syntax.
public class ProductListing : Windows.ApplicationModel.Store.IProductListing, Windows.ApplicationModel.Store.IProductListing2, Windows.ApplicationModel.Store.IProductListingWithMetadata
-->

# Windows.ApplicationModel.Store.ProductListing

## -description
Provides localized information that details an add-on (also called an in-app product or IAP).

## -remarks
You access this object by picking an element of the collection that the [ProductListings](listinginformation_productlistings.md) property of the [ListingInformation](listinginformation.md) object returns.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | CurrencyCode |
| 1511 | 10586 | FormattedBasePrice |
| 1511 | 10586 | IsOnSale |
| 1511 | 10586 | SaleEndDate |

## -examples
This code example here shows how to get the [ListingInformation](listinginformation.md) from simulated app data and then get the ProductListing object an add-on.

```csharp
// get the license info for this app from the simulator
ListingInformation listing = await CurrentAppSimulator.LoadListingInformationAsync();

// get the ProductListing object for the product named "product1"
ProductListing thisProduct = listing.ProductListings["product1"];

// format the purchase string or this in-app offer
String purchasePrice = "You can buy " + thisProduct.Name + 
    " for: " + thisProduct.FormattedPrice + ".";

```

## -see-also
[ListingInformation](listinginformation.md), [ProductListings](listinginformation_productlistings.md)
