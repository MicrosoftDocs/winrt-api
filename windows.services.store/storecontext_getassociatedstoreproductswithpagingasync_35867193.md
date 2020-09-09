---
-api-id: M:Windows.Services.Store.StoreContext.GetAssociatedStoreProductsWithPagingAsync(Windows.Foundation.Collections.IIterable{System.String},System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StoreProductPagedQueryResult> GetAssociatedStoreProductsWithPagingAsync(Windows.Foundation.Collections.IIterable<System.String> productKinds, System.UInt32 maxItemsToRetrievePerPage)
-->

# Windows.Services.Store.StoreContext.GetAssociatedStoreProductsWithPagingAsync

## -description
Gets Microsoft Store listing info for the products that can be purchased from within the current app. This method supports paging to return the results.

## -parameters
### -param productKinds
An array of strings that specify the types of products you want to get. For a list of the supported string values, see the [ProductKind](storeproduct_productkind.md) property.

### -param maxItemsToRetrievePerPage
The maximum number of products to return in each page of results.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreProductPagedQueryResult](storeproductpagedqueryresult.md) that provides access to the associated products, relevant error info, and the next page of results.

## -remarks
This method is similar to [GetAssociatedStoreProductsAsync](storecontext_getassociatedstoreproductsasync_1833928682.md), with the difference that it enables you to use paging to retrieve the products. For more information about using [GetAssociatedStoreProductsAsync](storecontext_getassociatedstoreproductsasync_1833928682.md), including a code example, see [Get product info for apps and add-ons](/windows/uwp/monetize/get-product-info-for-apps-and-add-ons).

Use the [HasMoreResults](storeproductpagedqueryresult_hasmoreresults.md) of the [StoreProductPagedQueryResult](storeproductpagedqueryresult.md) return value to determine whether there are additional pages of results, and use the [GetNextAsync](storeproductpagedqueryresult_getnextasync_1854313260.md) method to get the next page of results.

> [!NOTE]
> Always use [HasMoreResults](storeproductpagedqueryresult_hasmoreresults.md) to determine if there are more pages available, even if the current page of data contains fewer items than *maxItemsToRetrievePerPage*. To provide faster results, the service can return fewer items in a page than *maxItemsToRetrievePerPage* even if there are more pages of data available.

## -examples

## -see-also
[StoreProductPagedQueryResult](storeproductpagedqueryresult.md)
