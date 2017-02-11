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
The [StoreContext.GetAssociatedStoreProductsWithPagingAsync](storecontext_getassociatedstoreproductswithpagingasync.md) and [StoreContext.GetUserCollectionWithPagingAsync](storecontext_getusercollectionwithpagingasync.md) methods return an object of this type.

After you have a [StoreProductPagedQueryResult](storeproductpagedqueryresult.md) object, you can retrieve the object that contains the next page of results by using the [GetNextAsync](storeproductpagedqueryresult_getnextasync.md) method.

## -examples

## -see-also
