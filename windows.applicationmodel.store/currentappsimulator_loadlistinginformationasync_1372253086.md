---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.LoadListingInformationAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationAsync()
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.LoadListingInformationAsync

## -description
Loads the simulated app listing information asynchronously. 

The returned [ListingInformation](currentappsimulator_loadlistinginformationasync_1372253086.md) object contains listing information (e.g. name, price, age rating) specific to the market the user currently resides in. Additionally, listing information for products available via in-app products is also provided.

> [!NOTE]
> For simulation purposes, this method uses the  element in the WindowsStoreProxy.xml file as the data source for the members of the returned object. For more info, see the code examples in [CurrentAppSimulator](currentappsimulator.md).

## -returns
The app listing information as defined by the simulation. If the method fails, it returns an **HRESULT** error code.

## -remarks
Calling this method requires an internet connection.

## -examples

## -see-also
