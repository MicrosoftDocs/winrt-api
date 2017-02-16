---
-api-id: M:Windows.ApplicationModel.Store.CurrentApp.LoadListingInformationByKeywordsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationByKeywordsAsync(Windows.Foundation.Collections.IIterable<System.String> keywords)
-->

# Windows.ApplicationModel.Store.CurrentApp.LoadListingInformationByKeywordsAsync

## -description
Loads the app listing information asynchronously, returning features and products in the [ProductListings](listinginformation_productlistings.md) collection that match all supplied keywords. 

## -parameters
### -param keywords
The list of keywords by which to filter the [ProductListings](listinginformation_productlistings.md) collection that is returned in the [ListingInformation](listinginformation.md) object.

## -returns
The app's listing information, with [ProductListings](listinginformation_productlistings.md) collection filtered by keywords. If the method fails, it returns an **HRESULT** error code. If no products or features are found that match all of the given keywords, the ProductListings collection will be empty.

## -remarks

## -examples

## -see-also
