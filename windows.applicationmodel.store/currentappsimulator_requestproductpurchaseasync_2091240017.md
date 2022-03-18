---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.RequestProductPurchaseAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.PurchaseResults> RequestProductPurchaseAsync(System.String productId)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.RequestProductPurchaseAsync

## -description
Creates the async operation that displays the UI that is used to simulate the purchase of an add-on (also called an in-app product or IAP) from the Microsoft Store.

## -parameters
### -param productId
The product ID (as defined by the simulation) of the add-on to purchase.

## -returns
A [PurchaseResults](purchaseresults.md) that contains the results of the simulated in-app product purchase request.

## -remarks
Uses the **CurrentApp/ListingInformation/Product** element in the WindowsStoreProxy.xml file with the **ProductId** attribute that matches *ProductId* as the data source for the members of the returned object. If the purchase succeeds, the license state is updated only in memory. The contents of WindowsStoreProxy.xml are not changed. For more information, see [Using the WindowsStoreProxy.xml file with CurrentAppSimulator](/windows/uwp/monetize/in-app-purchases-and-trials-using-the-windows-applicationmodel-store-namespace).

You can see an example of how to use this method in our [code sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Trial%20app%20and%20in-app%20purchase%20sample).

## -examples

## -see-also
[RequestProductPurchaseAsync(String, Boolean)](currentappsimulator_requestproductpurchaseasync_1631257175.md)
