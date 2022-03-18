---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.LoadListingInformationByKeywordsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationByKeywordsAsync(Windows.Foundation.Collections.IIterable<System.String> keywords)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.LoadListingInformationByKeywordsAsync

## -description
Loads the simulated app listing information asynchronously, returning in-app products in the [ProductListings](listinginformation_productlistings.md) collection that match all supplied keywords. 

## -parameters
### -param keywords
The list of keywords by which to filter the [ProductListings](listinginformation_productlistings.md) collection that is returned in the [ListingInformation](listinginformation.md) object.

## -returns
The simulated app listing information, with [ProductListings](listinginformation_productlistings.md) collection filtered by keywords. If the method fails, it returns an **HRESULT** error code. If no in-app products are found that match all of the given keywords, the ProductListings collection will be empty.

## -remarks
Uses the **ListingInformation** element in the WindowsStoreProxy.xml file as the data source for the members of the returned objects. For more information, see [Using the WindowsStoreProxy.xml file with CurrentAppSimulator](/windows/uwp/monetize/in-app-purchases-and-trials-using-the-windows-applicationmodel-store-namespace).

Calling this method requires an internet connection.

## -examples

## -see-also
