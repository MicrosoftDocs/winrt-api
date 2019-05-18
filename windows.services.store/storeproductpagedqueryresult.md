---
-api-id: T:Windows.Services.Store.StoreProductPagedQueryResult
-api-type: winrt class
---

<!-- Class syntax.
public class StoreProductPagedQueryResult : Windows.Services.Store.IStoreProductPagedQueryResult
-->

# Windows.Services.Store.StoreProductPagedQueryResult

## -description
Provides response data for a paged request to retrieve details about products that can be purchased from within the current app.

## -remarks
The [StoreContext.GetAssociatedStoreProductsWithPagingAsync](storecontext_getassociatedstoreproductswithpagingasync_35867193.md) and [StoreContext.GetUserCollectionWithPagingAsync](storecontext_getusercollectionwithpagingasync_1326616908.md) methods return an object of this type.

After you have a StoreProductPagedQueryResult object, you can retrieve the object that contains the next page of results by using the [GetNextAsync](storeproductpagedqueryresult_getnextasync_1854313260.md) method.

## -examples

## -see-also
