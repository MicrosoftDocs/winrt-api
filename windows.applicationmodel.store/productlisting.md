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

## -examples
This code example here shows how to get the [ListingInformation](listinginformation.md) from simulated app data and then get the [ProductListing](productlisting.md) object an add-on.

```javascript
// get current app object using the simulator interface
currentApp = Windows.ApplicationModel.Store.CurrentAppSimulator;

// get the listing information for the products this app supports
currentApp.loadListingInformationAsync().then(
    function (listing) {
        // loadListingInformationAsync returns the ListingInformation object in listing.
        // now get info about a specific product and write it to the screen.
        thisProduct = listing.productListings.lookup("product1");
        id("purchasePrice").innerText = "You can buy " + thisProduct.name +
            " for: " + thisProduct.formattedPrice + ".";
    }
);

```

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