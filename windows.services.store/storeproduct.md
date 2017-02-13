---
-api-id: T:Windows.Services.Store.StoreProduct
-api-type: winrt class
---

<!-- Class syntax.
public class StoreProduct : Windows.Services.Store.IStoreProduct
-->

# Windows.Services.Store.StoreProduct

## -description
Represents a product that is available in the Windows Store.

## -remarks
The [StoreProductQueryResult.Products](storeproductqueryresult_products.md), [StoreProductPagedQueryResult.Products](storeproductpagedqueryresult_products.md), and [StoreProductResult.Product](storeproductresult_product.md) properties return objects of this type. For more information about products and their relationship with SKUs and availabilities, see [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials).

To retrieve product listing info for a product, use the following methods of the [StoreContext](storecontext.md) class:
+ [GetAssociatedStoreProductsAsync](storecontext_getassociatedstoreproductsasync.md)
+ [GetAssociatedStoreProductsWithPagingAsync](storecontext_getassociatedstoreproductswithpagingasync.md)
+ [GetStoreProductsAsync](storecontext_getstoreproductsasync.md)
+ [GetStoreProductForCurrentAppAsync](storecontext_getstoreproductforcurrentappasync.md)
+ [GetUserCollectionAsync](storecontext_getusercollectionasync.md)
+ [GetUserCollectionWithPagingAsync](storecontext_getusercollectionwithpagingasync.md)


## -examples

## -see-also
[In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials)