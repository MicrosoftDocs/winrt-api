---
-api-id: M:Windows.Services.Store.StoreContext.ReportConsumableFulfillmentAsync(System.String,System.UInt32,System.Guid)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StoreConsumableResult> ReportConsumableFulfillmentAsync(System.String productStoreId, System.UInt32 quantity, System.Guid trackingId)
-->

# Windows.Services.Store.StoreContext.ReportConsumableFulfillmentAsync

## -description
Reports a consumable add-on for the current app as fulfilled in the Microsoft Store.

## -parameters
### -param productStoreId
The Store ID of the consumable add-on that you want to report as fulfilled.

### -param quantity
The number of units of the consumable add-on that you want to report as fulfilled. For a Store-managed consumable (that is, a consumable where Microsoft keeps track of the balance), specify the number of units that have been consumed. For a developer-managed consumable (that is, a consumable where the developer keeps track of the balance), specify 1.

### -param trackingId
A developer-supplied [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) that identifies the specific transaction that the fulfillment operation is associated with for tracking purposes. For more information, see the remarks.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreConsumableResult](storeconsumableresult.md) object that contains info about the fulfillment operation, such as the remaining balance of add-on units.

## -remarks
After the user has used a consumable add-on in your app, use this method to report the add-on as fulfilled in the Microsoft Store. The Store ID for the add-on is available in [Partner Center](https://partner.microsoft.com/dashboard), and it is returned by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the add-on. For more information about using this method, including a code example, see [Enable consumable add-on purchases](/windows/uwp/monetize/enable-consumable-add-on-purchases).

The *trackingId* parameter is used to help ensure that each fulfillment operation is handled exactly once by the Microsoft Store. For example, consider a scenario where you call ReportConsumableFulfillmentAsync with a given pair of *productStoreId* and *trackingId* values, the Microsoft Store successfully marks the consumable as fulfilled, but there is a network connectivity issue that prevents your app from receiving and handling the response. The next time your app retries the same ReportConsumableFulfillmentAsync call with the same pair of *productStoreId* and *trackingId* values after it regains connectivity, the Microsoft Store will report the transaction as successful without charging the user again. The *trackingId* parameter can be retrieved via the [TrackingId](storeconsumableresult_trackingid.md) property of the [StoreConsumableResult](storeconsumableresult.md) return value.

## -examples

## -see-also
[Enable consumable add-on purchases](/windows/uwp/monetize/enable-consumable-add-on-purchases), [Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Store)
