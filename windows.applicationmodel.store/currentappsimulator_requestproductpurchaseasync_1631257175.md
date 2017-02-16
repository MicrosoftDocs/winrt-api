---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.RequestProductPurchaseAsync(System.String,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> RequestProductPurchaseAsync(System.String productId, System.Boolean includeReceipt)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.RequestProductPurchaseAsync

## -description
> [!NOTE]
> [RequestProductPurchaseAsync(String, Boolean)](currentappsimulator_requestproductpurchaseasync_1631257175.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [RequestProductPurchaseAsync(String)](currentappsimulator_requestproductpurchaseasync_2091240017.md).

Creates the async operation that displays the UI that is used to simulate the purchase of an in-app product from the Windows Store.

## -parameters
### -param productId
Specifies the id, as defined by the simulation, of the in-app product to buy.

### -param includeReceipt
Determines if the method should return the receipts for the specified *productId.*

## -returns
A string providing in-app product purchase details for the provided *productId*. If *includeReceipt* is set **true**, the returned string will include a full receipt xml.

## -remarks
Uses the **CurrentApp/ListingInformation/Product** element in the WindowsStoreProxy.xml file with the **ProductId** attribute that matches *ProductId* as the data source for the members of the returned object. If the purchase transaction succeeds, the license state is updated only in memory. The contents of WindowsStoreProxy.xml are not changed. For more information, see [Using the WindowsStoreProxy.xml file with CurrentAppSimulator](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials-using-the-windows-applicationmodel-store-namespace#proxy).

Use the [LicenseInformation.IsActive](licenseinformation_isactive.md) property to confirm that a product license is active after a successful [RequestProductPurchaseAsync](currentappsimulator_requestproductpurchaseasync.md) call.

> [!NOTE]
> This method of confirming a successful purchase is only applicable to the [RequestProductPurchaseAsync](currentappsimulator_requestproductpurchaseasync.md) overloads that don't return a [PurchaseResults](purchaseresults.md) object.

You can see an example of how to use this method in our [code sample](http://go.microsoft.com/fwlink/p/?linkid=231569).

## -examples

## -see-also
[RequestProductPurchaseAsync(String)](currentappsimulator_requestproductpurchaseasync_2091240017.md)