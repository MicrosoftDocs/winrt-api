---
-api-id: M:Windows.Services.Store.StoreAvailability.RequestPurchaseAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StorePurchaseResult> RequestPurchaseAsync()
-->

# Windows.Services.Store.StoreAvailability.RequestPurchaseAsync

## -description
Requests the purchase of the current SKU availability and displays the UI that is used to complete the transaction via the Microsoft Store.

> [!IMPORTANT]
> This method must be called on the UI thread.

## -returns
An asynchronous operation that, on successful completion, returns a [StorePurchaseResult](storepurchaseresult.md) object that provides status and error info about the purchase.

## -exceptions
### T:System.Runtime.InteropServices.COMException

If the **ErrorCode** property of the exception has the value 0x80070578 (ERROR_INVALID_WINDOW_HANDLE), this indicates that the method was not called on the UI thread. If you are calling this method in a desktop application that uses the Desktop Bridge, this can also indicate that you did not configure the [StoreContext](storecontext.md) object to specify which application window is the owner window for modal dialogs shown by this method. For more information, see [this article](/windows/uwp/monetize/in-app-purchases-and-trials#desktop).

## -examples

## -see-also
[RequestPurchaseAsync(StorePurchaseProperties)](storeavailability_requestpurchaseasync_1703896342.md)
