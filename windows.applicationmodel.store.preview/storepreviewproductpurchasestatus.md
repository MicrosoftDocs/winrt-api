---
-api-id: T:Windows.ApplicationModel.Store.Preview.StorePreviewProductPurchaseStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Store.Preview.StorePreviewProductPurchaseStatus : int
-->

# StorePreviewProductPurchaseStatus

## -description
Defines values that are used to indicate the transaction status when purchasing an in-app product SKU by using the [RequestProductPurchaseByProductIdAndSkuIdAsync](storepreview_requestproductpurchasebyproductidandskuidasync.md) method.

## -enum-fields
### -field Succeeded:0
The transaction succeeded and the user has been notified.

### -field AlreadyPurchased:1
The transaction did not complete because this in-app product SKU has already been purchased by the user, and it cannot be purchased again. This value only applies to durable in-app products.

### -field NotFulfilled:2
The transaction did not complete because the last purchase of this consumable in-app product SKU has not been reported as fulfilled to the Microsoft Store. This value only applies to consumable in-app products.

### -field NotPurchased:3
The purchase did not occur because the user decided not to complete the transaction (or the transaction failed for other reasons).


## -remarks

## -examples

## -see-also