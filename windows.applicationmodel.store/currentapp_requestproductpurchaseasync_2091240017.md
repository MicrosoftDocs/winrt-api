---
-api-id: M:Windows.ApplicationModel.Store.CurrentApp.RequestProductPurchaseAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.PurchaseResults> RequestProductPurchaseAsync(System.String productId)
-->

# Windows.ApplicationModel.Store.CurrentApp.RequestProductPurchaseAsync

## -description
Requests the purchase of an in-app product. Additionally, calling this method displays the UI that is used to complete the transaction via the Windows Store.

## -parameters
### -param productId
Specifies the id of the in-app product.

## -returns
The results of the in-app product purchase request.

## -remarks
Use the [LicenseInformation.IsActive](licenseinformation_isactive.md) property to confirm that a product license is active after a successful [RequestProductPurchaseAsync](currentappsimulator_requestproductpurchaseasync.md) call.

> [!NOTE]
> This method of confirming a successful purchase is only applicable to the [RequestProductPurchaseAsync](currentappsimulator_requestproductpurchaseasync.md) overloads that don't return a [PurchaseResults](purchaseresults.md) object.

You can see an example of how to use this method in our [code sample](http://go.microsoft.com/fwlink/p/?linkid=231569).



## -examples

## -see-also
[RequestProductPurchaseAsync(String, Boolean)](currentapp_requestproductpurchaseasync_1631257175.md)