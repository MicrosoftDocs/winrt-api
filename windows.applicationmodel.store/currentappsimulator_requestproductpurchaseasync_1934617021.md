---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.RequestProductPurchaseAsync(System.String,System.String,Windows.ApplicationModel.Store.ProductPurchaseDisplayProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.PurchaseResults> RequestProductPurchaseAsync(System.String productId, System.String offerId, Windows.ApplicationModel.Store.ProductPurchaseDisplayProperties displayProperties)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.RequestProductPurchaseAsync

## -description
Creates the async operation that displays the UI that is used to simulate the purchase of an in-app product from the Windows Store.

The resulting [RequestProductPurchaseAsync](currentappsimulator_requestproductpurchaseasync.md) object includes the parameters required to display details for a specific offer within a large catalog of in-app products that is represented by a single entry in the Windows Store.

## -parameters
### -param productId
The product ID used for listing in the Windows Store.

### -param offerId
The specific in-app product within the large purchase catalog represented on the Windows Store by the *productId.* This value correlates with the content your app is responsible for fulfilling. The Windows Store only uses this parameter value to itemize the [PurchaseResults](purchaseresults.md).

### -param displayProperties
The name of the in-app product that is displayed to the user at time of purchase.

## -returns
The results of the in-app product purchase.

## -remarks

## -examples

## -see-also
[RequestProductPurchaseAsync(String)](currentappsimulator_requestproductpurchaseasync_2091240017.md), [RequestProductPurchaseAsync(String, Boolean)](currentappsimulator_requestproductpurchaseasync_1631257175.md)