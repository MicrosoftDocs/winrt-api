---
-api-id: T:Windows.ApplicationModel.Store.FulfillmentResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Store.FulfillmentResult : int
-->

# FulfillmentResult

## -description
Defines values used to indicate fulfillment status for a consumable in-app product.

## -enum-fields
### -field Succeeded:0
The purchased consumable in-app product was fulfilled.

### -field NothingToFulfill:1
The specified transaction ID has been passed or the consumable in-app product has already been fulfilled.

### -field PurchasePending:2
The purchase is not complete. At this point it is still possible for the transaction to be reversed due to provider failures and/or risk checks.

### -field PurchaseReverted:3
The purchase request has been reverted.

### -field ServerError:4
There was an issue receiving fulfillment status.


## -remarks

## -examples

## -see-also
[ReportConsumableFulfillmentAsync](currentapp_reportconsumablefulfillmentasync.md)