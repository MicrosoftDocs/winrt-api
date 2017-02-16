---
-api-id: M:Windows.ApplicationModel.Store.CurrentApp.ReportConsumableFulfillmentAsync(System.String,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.FulfillmentResult> ReportConsumableFulfillmentAsync(System.String productId, System.Guid transactionId)
-->

# Windows.ApplicationModel.Store.CurrentApp.ReportConsumableFulfillmentAsync

## -description
Notifies the Windows Store that the purchase of a consumable is fulfilled and that the user has the right to access the content.

## -parameters
### -param productId
Identifies the consumable.

### -param transactionId
Identifies a transaction that includes the purchase of the consumable (*productId*).

## -returns
A value that indicates the status of fulfillment for a consumable in-app product. Possible values are defined by the [FulfillmentResult](fulfillmentresult.md) enumeration.

## -remarks
A unique ID is required for each instance of a consumable product that has been purchased more than once.

## -examples

## -see-also
