---
-api-id: M:Windows.Services.Store.StoreContext.GetConsumableBalanceRemainingAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StoreConsumableResult> GetConsumableBalanceRemainingAsync(System.String productStoreId)
-->

# Windows.Services.Store.StoreContext.GetConsumableBalanceRemainingAsync

## -description
Gets the remaining balance for the specified consumable add-on for the current app.

## -parameters
### -param productStoreId
The Store ID for the add-on (as provided by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the add-on).

## -returns
An asynchronous operation that, on successful completion, returns a [StoreConsumableResult](storeconsumableresult.md) that provides the remaining balance and other info.

## -remarks
For more information about using this method, including a code example, see [Enable consumable add-on purchases](/windows/uwp/monetize/enable-consumable-add-on-purchases).

## -examples

## -see-also
[StoreConsumableResult](storeconsumableresult.md), [Enable consumable add-on purchases](/windows/uwp/monetize/enable-consumable-add-on-purchases), [Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Store)