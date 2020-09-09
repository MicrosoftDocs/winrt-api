---
-api-id: M:Windows.Services.Store.StoreContext.GetStoreProductsAsync(Windows.Foundation.Collections.IIterable{System.String},Windows.Foundation.Collections.IIterable{System.String},Windows.Services.Store.StoreProductOptions)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<StoreProductQueryResult> StoreContext.GetStoreProductsAsync(IIterable<String> productKinds, IIterable<String> storeIds, StoreProductOptions storeProductOptions)
-->

# Windows.Services.Store.StoreContext.GetStoreProductsAsync

## -description
Gets Microsoft Store listing info for the specified products that are associated with the current app, with the option to use a filter for the query.

## -parameters
### -param productKinds
An array of strings that specify the types of products for which you want to retrieve listing info. For a list of the supported string values, see the [ProductKind](storeproduct_productkind.md) property.

### -param storeIds
An array of the Store ID strings for the products for which you want to retrieve listing info.

### -param storeProductOptions
An object that contains a filter that will be used for the query.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreProductQueryResult](storeproductqueryresult.md) object that contains listing info for the specified products and any relevant error info.

## -remarks
To return info only for products that can currently be purchased from within the current app, add the ```Purchase``` filter string to the [ActionFilters](storeproductoptions_actionfilters.md) property of the object you pass to the *storeProductOptions* parameter. To get info for all the specified products that are associated with the current app, regardless of whether they are currently available for purchase, use the [GetStoreProductsAsync](storecontext_getstoreproductsasync_1035651645.md) overload instead.

The Store ID for a product is available in [Partner Center](https://partner.microsoft.com/dashboard), and it also is returned by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the product. For more information, see [Store IDs](/windows/uwp/monetize/in-app-purchases-and-trials#store-ids).

For more information about using this method, including a code example, see [Get product info for apps and add-ons](/windows/uwp/monetize/get-product-info-for-apps-and-add-ons).

## -see-also
[Get product info for apps and add-ons](/windows/uwp/monetize/get-product-info-for-apps-and-add-ons)

## -examples
