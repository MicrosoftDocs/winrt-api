---
-api-id: M:Windows.Services.Store.StoreContext.RequestPurchaseAsync(System.String,Windows.Services.Store.StorePurchaseProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StorePurchaseResult> RequestPurchaseAsync(System.String storeId, Windows.Services.Store.StorePurchaseProperties storePurchaseProperties)
-->

# Windows.Services.Store.StoreContext.RequestPurchaseAsync

## -description
Requests the purchase for the specified app or add-on and displays the UI that is used to complete the transaction via the Microsoft Store. This method provides the option to specify additional details for a specific offer within a large catalog of products that are represented by a single listing in the Microsoft Store, including the product name to display to the user during the purchase.

> [!IMPORTANT]
> This method must be called on the UI thread.

## -parameters
### -param storeId
The Store ID of the app or the add-on that you want to purchase for the current user.

### -param storePurchaseProperties
An object that specifies additional info for the purchase request, including the product name to display to the user during the purchase.

## -returns
An asynchronous operation that, on successful completion, returns a [StorePurchaseResult](storepurchaseresult.md) object that provides status and error info about the purchase.

## -exceptions
### T:System.Runtime.InteropServices.COMException

If the **ErrorCode** property of the exception has the value 0x80070578 (ERROR_INVALID_WINDOW_HANDLE), this indicates that the method was not called on the UI thread. If you are calling this method in a desktop application that uses the Desktop Bridge, this can also indicate that you did not configure the [StoreContext](storecontext.md) object to specify which application window is the owner window for modal dialogs shown by this method. For more information, see [this article](/windows/uwp/monetize/in-app-purchases-and-trials#desktop).

## -remarks
The Store ID for an app or add-on is available in [Partner Center](https://partner.microsoft.com/dashboard), and it is returned by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the app or add-on.

## -examples

## -see-also
[RequestPurchaseAsync(String)](storecontext_requestpurchaseasync_1017170817.md), [Enable in-app purchases of apps and add-ons](/windows/uwp/monetize/enable-in-app-purchases-of-apps-and-add-ons)
