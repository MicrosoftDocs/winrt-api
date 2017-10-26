---
-api-id: T:Windows.ApplicationModel.Store.ProductPurchaseStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Store.ProductPurchaseStatus : int
-->

# ProductPurchaseStatus

## -description
Defines values used to indicate the transaction status when purchasing an in-app product.

## -enum-fields
### -field Succeeded:0
The transaction succeeded and the user has been notified.

### -field AlreadyPurchased:1
The transaction did not complete because this in-app product has already been purchased by the user, and it cannot be purchased again.

### -field NotFulfilled:2
The transaction did not complete because the last purchase of this consumable in-app product has not been reported as fulfilled to the Microsoft Store.

### -field NotPurchased:3
The purchase did not occur because the user decided not to complete the transaction (or the transaction failed for other reasons).


## -remarks

## -examples

## -see-also
[RequestProductPurchaseAsync(String)](currentapp_requestproductpurchaseasync_2091240017.md), [RequestProductPurchaseAsync(String, Boolean)](currentapp_requestproductpurchaseasync_1631257175.md)