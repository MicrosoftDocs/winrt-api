---
-api-id: M:Windows.Services.Store.StoreContext.RequestPurchaseAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StorePurchaseResult> RequestPurchaseAsync(System.String storeId)
-->

# Windows.Services.Store.StoreContext.RequestPurchaseAsync

## -description
Requests the purchase for the specified app or add-on and displays the UI that is used to complete the transaction via the Windows Store.

> [!IMPORTANT]
> This method must be called on the UI thread.

## -parameters
### -param storeId
The Store ID of the app or the add-on that you want to purchase for the current user.

## -returns
An asynchronous operation that, on successful completion, returns a [StorePurchaseResult](storepurchaseresult.md) object that provides status and error info about the purchase.

## -remarks
For more information about using this method, including a code example, see [Enable in-app purchases of apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/enable-in-app-purchases-of-apps-and-add-ons).

The Store ID for an app or add-on is available in the Windows Dev Center dashboard, and it is returned by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the app or add-on.

If this method is not called on the UI thread, the [StorePurchaseResult](storepurchaseresult.md) return value might indicate that an error occurred, and the [ExtendedError](storepurchaseresult_extendederror.md) property could have the value 0x800706be. This value corresponds to the [RPC_S_CALL_FAILED](https://msdn.microsoft.com/en-us/library/windows/desktop/aa378645(v=vs.85).aspx) error code.

## -examples

## -see-also
[RequestPurchaseAsync(String, StorePurchaseProperties)](storecontext_requestpurchaseasync_1039951085.md), [Enable in-app purchases of apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/enable-in-app-purchases-of-apps-and-add-ons)