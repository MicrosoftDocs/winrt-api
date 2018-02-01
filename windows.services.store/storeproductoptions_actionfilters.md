---
-api-id: P:Windows.Services.Store.StoreProductOptions.ActionFilters
-api-type: winrt property
---

<!-- Property syntax.
public IVector<string> ActionFilters { get; }
-->

# Windows.Services.Store.StoreProductOptions.ActionFilters

## -description
Gets a collection of filter strings you can use with the [GetStoreProductsAsync](storecontext_getstoreproductsasync_915504661.md) method to get info for the specified products that are associated with the current app. Currently, this collection only supports one filter string, ```Purchase```.

## -property-value
A collection of filter strings you can use with the [GetStoreProductsAsync](storecontext_getstoreproductsasync_915504661.md) method to get info for the specified products that are associated with the current app.

## -remarks
Currently, this property only supports one filter string, ```Purchase```. When you include this filter string, [GetStoreProductsAsync](storecontext_getstoreproductsasync_915504661.md) returns info only for products that are currently available for purchase from within the current app (the operation will exclude products that are no longer sellable by the app).

## -see-also

## -examples
