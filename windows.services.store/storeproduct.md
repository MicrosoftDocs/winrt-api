---
-api-id: T:Windows.Services.Store.StoreProduct
-api-type: winrt class
---

<!-- Class syntax.
public class StoreProduct : Windows.Services.Store.IStoreProduct
-->

# Windows.Services.Store.StoreProduct

## -description
Represents a product that is available in the Microsoft Store.

## -remarks
Products in the Store are organized in a hierarcy of *product*, *SKU*, and *availability* objects. Products are represented by **StoreProduct** objects. The SKUs for each product are represented by [StoreSku](storesku.md) objects, and the availabilities for each SKU are represented by [StoreAvailability](storeavailability.md) objects. For more information, see [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials#products-skus).

To retrieve a **StoreProduct** object for the current app, use the [GetStoreProductForCurrentAppAsync](storecontext_getstoreproductforcurrentappasync.md) method. 

To retrieve **StoreProduct** objects for products that can be purchased from within the current app, use these methods.
+ [GetAssociatedStoreProductsAsync](storecontext_getassociatedstoreproductsasync.md)
+ [GetAssociatedStoreProductsWithPagingAsync](storecontext_getassociatedstoreproductswithpagingasync.md)
+ [GetStoreProductsAsync](storecontext_getstoreproductsasync.md)
+ [GetUserCollectionAsync](storecontext_getusercollectionasync.md)
+ [GetUserCollectionWithPagingAsync](storecontext_getusercollectionwithpagingasync.md)

## -examples

## -see-also
[In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials)