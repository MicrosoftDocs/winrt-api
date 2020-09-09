---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.ReportConsumableFulfillmentAsync(System.String,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.FulfillmentResult> ReportConsumableFulfillmentAsync(System.String productId, System.Guid transactionId)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.ReportConsumableFulfillmentAsync

## -description
Simulates notifying the Microsoft Store that the purchase of a consumable add-on (also called an in-app product or IAP) is fulfilled and that the user has the right to access the content.

## -parameters
### -param productId
The product ID of the consumable add-on to report as fulfilled.

### -param transactionId
The transaction ID for the simulated purchase of the consumable add-on.

## -returns
A [FulfillmentResult](fulfillmentresult.md) value that indicates the fulfillment status for the consumable add-on.

## -remarks
The product ID is the string that the app uses to identify the add-on. You enter the product ID when [submitting your add-on](/windows/uwp/publish/set-your-add-on-product-id) in [Partner Center](https://partner.microsoft.com/dashboard), where it is associated with the description, price tier and lifetime. For more information, see [How to use product IDs for add-ons in your code](/windows/uwp/monetize/in-app-purchases-and-trials#how-to-use-product-ids-for-add-ons-in-your-code).

A unique transaction ID is required for each instance of a consumable product that has been purchased more than once.

## -examples

## -see-also
