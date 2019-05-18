---
-api-id: M:Windows.ApplicationModel.Store.CurrentApp.LoadListingInformationAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.ListingInformation> LoadListingInformationAsync()
-->

# Windows.ApplicationModel.Store.CurrentApp.LoadListingInformationAsync

## -description
Loads the app's listing information asynchronously. 

The returned ListingInformation object contains listing information (e.g. name, price, age rating) specific to the market the user currently resides in. Additionally, the listing information for available in-app products is also provided.

## -returns
The apps' listing information. If the method fails, it returns an **HRESULT** error code.

## -remarks
Calling this method requires an internet connection.

## -examples

## -see-also
