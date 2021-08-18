---
-api-id: M:Windows.Services.Store.StoreSku.RequestPurchaseAsync(Windows.Services.Store.StorePurchaseProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StorePurchaseResult> RequestPurchaseAsync(Windows.Services.Store.StorePurchaseProperties storePurchaseProperties)
-->

# Windows.Services.Store.StoreSku.RequestPurchaseAsync

## -description
Requests the purchase of the product SKU and displays the UI that is used to complete the transaction via the Microsoft Store. This method provides the option to specify additional details for a specific offer within a large catalog of products that are represented by a single listing in the Microsoft Store, including the product name to display to the user during the purchase.

> [!IMPORTANT]
> This method must be called on the UI thread.

## -parameters
### -param storePurchaseProperties
An object that specifies additional info for the purchase request, including the product name to display to the user during the purchase.

## -returns
An asynchronous operation that, on successful completion, returns a [StorePurchaseResult](storepurchaseresult.md) object that provides status and error info about the purchase.

## -exceptions
### T:System.Runtime.InteropServices.COMException

If the **ErrorCode** property of the exception has the value 0x80070578 (ERROR_INVALID_WINDOW_HANDLE), this indicates that the method was not called on the UI thread. If you are calling this method in a desktop application that uses the Desktop Bridge, this can also indicate that you did not configure the [StoreContext](storecontext.md) object to specify which application window is the owner window for modal dialogs shown by this method. For more information, see [this article](/windows/uwp/monetize/in-app-purchases-and-trials#desktop).

## -examples

## -see-also
[RequestPurchaseAsync](storesku_requestpurchaseasync_1696674465.md)
