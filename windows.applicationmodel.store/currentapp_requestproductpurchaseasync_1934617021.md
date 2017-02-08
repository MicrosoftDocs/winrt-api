---
-api-id: M:Windows.ApplicationModel.Store.CurrentApp.RequestProductPurchaseAsync(System.String,System.String,Windows.ApplicationModel.Store.ProductPurchaseDisplayProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.PurchaseResults> RequestProductPurchaseAsync(System.String productId, System.String offerId, Windows.ApplicationModel.Store.ProductPurchaseDisplayProperties displayProperties)
-->

# Windows.ApplicationModel.Store.CurrentApp.RequestProductPurchaseAsync

## -description
Requests the purchase of an in-app product. Additionally, calling this method displays the UI that is used to complete the transaction via the Windows Store.The resulting [RequestProductPurchaseAsync](currentapp_requestproductpurchaseasync.md) object includes the parameters required to display details for a specific offer within a large catalog of in-app purchases that is represented by a single product entry in the Store.



## -parameters
### -param productId
Specifies the id of the in-app product.

### -param offerId
The specific in-app feature or content within the large purchase catalog represented on the Windows Store by the *productId.* This value correlates with the content your app is responsible for fulfilling. The Windows Store only uses this value to itemize the [PurchaseResults](purchaseresults.md).

### -param displayProperties
The name of the app feature or content offer that is displayed to the user at time of purchase.

## -returns
The results of the in-app product purchase request.

## -remarks
The remarks for [RequestProductPurchaseAsync(String)](currentapp_requestproductpurchaseasync_2091240017.md) also apply to this method.

## -examples

## -see-also
[RequestProductPurchaseAsync(String)](currentapp_requestproductpurchaseasync_2091240017.md), [RequestProductPurchaseAsync(String, Boolean)](currentapp_requestproductpurchaseasync_1631257175.md)