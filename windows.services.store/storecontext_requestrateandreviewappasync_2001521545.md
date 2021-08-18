---
-api-id: M:Windows.Services.Store.StoreContext.RequestRateAndReviewAppAsync
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<StoreRateAndReviewResult> StoreContext.RequestRateAndReviewAppAsync()
-->

# Windows.Services.Store.StoreContext.RequestRateAndReviewAppAsync

## -description
Requests the user to rate and review the app. This method will display the UI for the user to select a Store rating and add an optional Store review for the product.

> [!IMPORTANT]
> This method must be called on the UI thread.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreRateAndReviewResult](storerateandreviewresult.md) object that provides status and error info.

## -exceptions

### T:System.Runtime.InteropServices.COMException

If the **ErrorCode** property of the exception has the value 0x80070578 (ERROR_INVALID_WINDOW_HANDLE), this indicates that the method was not called on the UI thread. If you are calling this method in a desktop application that uses the Desktop Bridge, this can also indicate that you did not configure the [StoreContext](storecontext.md) object to specify which application window is the owner window for modal dialogs shown by this method. For more information, see [this article](/windows/uwp/monetize/in-app-purchases-and-trials#desktop).

## -remarks

## -see-also

## -examples
