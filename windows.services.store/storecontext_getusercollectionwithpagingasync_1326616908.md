---
-api-id: M:Windows.Services.Store.StoreContext.GetUserCollectionWithPagingAsync(Windows.Foundation.Collections.IIterable{System.String},System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StoreProductPagedQueryResult> GetUserCollectionWithPagingAsync(Windows.Foundation.Collections.IIterable<System.String> productKinds, System.UInt32 maxItemsToRetrievePerPage)
-->

# Windows.Services.Store.StoreContext.GetUserCollectionWithPagingAsync

## -description
Gets Microsoft Store info for the add-ons of the current app for which the user has purchased. This method supports paging to return the results.

## -parameters
### -param productKinds
An array of strings that specify the types of add-ons for which you want to retrieve info. For a list of the supported string values, see the [ProductKind](storeproduct_productkind.md) property.

### -param maxItemsToRetrievePerPage
The maximum number of add-ons to return in each page of results.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreProductPagedQueryResult](storeproductpagedqueryresult.md) object that provides access to the Microsoft Store info for the add-ons of the current app for which the user has purchased and relevant error info, as well as the next page of results.

## -remarks
This method is similar to [GetUserCollectionAsync](storecontext_getusercollectionasync_822351662.md), with the difference that it enables you to use paging to retrieve the add-ons. For more information about using [GetUserCollectionAsync](storecontext_getusercollectionasync_822351662.md), including a code example, see [Get product info for apps and add-ons](/windows/uwp/monetize/get-product-info-for-apps-and-add-ons).

Use the [HasMoreResults](storeproductpagedqueryresult_hasmoreresults.md) of the [StoreProductPagedQueryResult](storeproductpagedqueryresult.md) object to determine whether there are additional pages of results, and use the [GetNextAsync](storeproductpagedqueryresult_getnextasync_1854313260.md) method to get the next page of results.

If the current user is not signed in to the Store, the [ExtendedError](storeproductpagedqueryresult_extendederror.md) property of the [StoreProductPagedQueryResult](storeproductpagedqueryresult.md) return value will return the error code 0x80070525 (**ERROR_NO_SUCH_USER**).

> [!NOTE]
> Always use [HasMoreResults](storeproductpagedqueryresult_hasmoreresults.md) to determine if there are more pages available, even if the current page of data contains fewer items than *maxItemsToRetrievePerPage*. To provide faster results, the service can return fewer items in a page than *maxItemsToRetrievePerPage* even if there are more pages of data available.

## -examples

## -see-also
