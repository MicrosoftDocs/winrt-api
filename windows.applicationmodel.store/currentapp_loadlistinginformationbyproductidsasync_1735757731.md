---
-api-id: M:Windows.ApplicationModel.Store.CurrentApp.LoadListingInformationByProductIdsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationByProductIdsAsync(Windows.Foundation.Collections.IIterable<System.String> productIds)
-->

# Windows.ApplicationModel.Store.CurrentApp.LoadListingInformationByProductIdsAsync

## -description
Loads the app listing information asynchronously, returning features and products in the [ProductListings](listinginformation_productlistings.md) collection that match any of the given products IDs. 

## -parameters
### -param productIds
The list of product IDs by which to filter the [ProductListings](listinginformation_productlistings.md) collection.

## -returns
The app's listing information, with [ProductListings](listinginformation_productlistings.md) collection filtered by product IDs. If the method fails, it returns an **HRESULT** error code. If no products or features are found that match the given product IDs, the ProductListings collection will be empty.

## -remarks

## -examples

## -see-also
