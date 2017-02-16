---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.ReportConsumableFulfillmentAsync(System.String,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.FulfillmentResult> ReportConsumableFulfillmentAsync(System.String productId, System.Guid transactionId)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.ReportConsumableFulfillmentAsync

## -description
Simulates notifying the Windows Store that the purchase of a consumable in-app product is fulfilled and that the user has the right to access the content.

## -parameters
### -param productId
Identifies the consumable in-app product.

### -param transactionId
Identifies a simulated transaction that includes the purchase of the consumable in-app product (*productId*).

## -returns
A value that indicates the status of fulfillment for a simulated consumable in-app product purchase.

## -remarks
A unique ID is required for each instance of a consumable that has been purchased more than once.

## -examples

## -see-also
