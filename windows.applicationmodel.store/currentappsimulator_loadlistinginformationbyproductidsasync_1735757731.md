---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.LoadListingInformationByProductIdsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationByProductIdsAsync(Windows.Foundation.Collections.IIterable<System.String> productIds)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.LoadListingInformationByProductIdsAsync

## -description
Loads the simulated app listing information asynchronously, returning available in-app products in the [ProductListings](listinginformation_productlistings.md) collection that match any of the given products IDs. 

## -parameters
### -param productIds
The list of product IDs by which to filter the [ProductListings](listinginformation_productlistings.md) collection.

## -returns
The simulated app listing information, with [ProductListings](listinginformation_productlistings.md) collection filtered by product IDs. If the method fails, it returns an **HRESULT** error code. If no in-app products are found that match the given product IDs, the ProductListings collection will be empty.

## -remarks
Uses the **ListingInformation** element in the WindowsStoreProxy.xml file as the data source for the members of the returned objects. For more information, see [Using the WindowsStoreProxy.xml file with CurrentAppSimulator](/windows/uwp/monetize/in-app-purchases-and-trials-using-the-windows-applicationmodel-store-namespace).

Calling this method requires an internet connection.

## -examples

## -see-also
