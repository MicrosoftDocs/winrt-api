---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.RequestProductPurchaseAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.PurchaseResults> RequestProductPurchaseAsync(System.String productId)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.RequestProductPurchaseAsync

## -description
Creates the async operation that displays the UI that is used to simulate the purchase of in-app product from the Windows Store.

## -parameters
### -param productId
Specifies the id, as defined by the simulation, of the in-app product to buy.

## -returns
A [PurchaseResults](purchaseresults.md) object containing transaction details for the provided *productId*.

## -remarks
Uses the **CurrentApp/ListingInformation/Product** element in the WindowsStoreProxy.xml file with the **ProductId** attribute that matches *ProductId* as the data source for the members of the returned object. If the purchase succeeds, the license state is updated only in memory. The contents of WindowsStoreProxy.xml are not changed. For more information, see [Using the WindowsStoreProxy.xml file with CurrentAppSimulator](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials-using-the-windows-applicationmodel-store-namespace#proxy).

Use the [LicenseInformation.IsActive](licenseinformation_isactive.md) property to confirm that a product license is active after a successful [RequestProductPurchaseAsync](currentappsimulator_requestproductpurchaseasync.md) call.

> [!NOTE]
> This method of confirming a successful purchase is only applicable to the [RequestProductPurchaseAsync](currentappsimulator_requestproductpurchaseasync.md) overloads that don't return a [PurchaseResults](purchaseresults.md) object.

You can see an example of how to use this method in our [code sample](http://go.microsoft.com/fwlink/p/?linkid=231569).

## -examples

## -see-also
[RequestProductPurchaseAsync(String, Boolean)](currentappsimulator_requestproductpurchaseasync_1631257175.md)