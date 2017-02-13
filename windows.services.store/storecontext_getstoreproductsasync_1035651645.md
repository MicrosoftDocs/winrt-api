---
-api-id: M:Windows.Services.Store.StoreContext.GetStoreProductsAsync(Windows.Foundation.Collections.IIterable{System.String},Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StoreProductQueryResult> GetStoreProductsAsync(Windows.Foundation.Collections.IIterable<System.String> productKinds, Windows.Foundation.Collections.IIterable<System.String> storeIds)
-->

# Windows.Services.Store.StoreContext.GetStoreProductsAsync

## -description
Gets Windows Store listing info for the specified products that can be purchased from within the current app.

## -parameters
### -param productKinds
An array of strings that specify the types of products for which you want to retrieve listing info. For a list of the supported string values, see the [ProductKind](storeproduct_productkind.md) property.

### -param storeIds
An array of the Store ID strings for the products for which you want to retrieve listing info.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreProductQueryResult](storeproductqueryresult.md) object that contains Windows Store listing info for the specified products and any relevant error info.

## -remarks
For more information about using this method, including a code example, see [Get product info for apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/get-product-info-for-apps-and-add-ons).

The Store ID for a product is available in the Windows Dev Center dashboard, and it also is returned by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the product. For more information, see [Store IDs](https://msdn.microsoft.com/windows/uwp/monetize/get-product-info-for-apps-and-add-ons).

## -examples

## -see-also
[Get product info for apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/get-product-info-for-apps-and-add-ons)