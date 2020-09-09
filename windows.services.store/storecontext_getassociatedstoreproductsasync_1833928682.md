---
-api-id: M:Windows.Services.Store.StoreContext.GetAssociatedStoreProductsAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StoreProductQueryResult> GetAssociatedStoreProductsAsync(Windows.Foundation.Collections.IIterable<System.String> productKinds)
-->

# Windows.Services.Store.StoreContext.GetAssociatedStoreProductsAsync

## -description
Gets Microsoft Store listing info for the products that can be purchased from within the current app.

## -parameters
### -param productKinds
An array of strings that specify the types of products you want to get. For a list of the supported string values, see the [ProductKind](storeproduct_productkind.md) property.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreProductQueryResult](storeproductqueryresult.md) that provides access to the associated products and relevant error info.

## -remarks
For more information about using this method, including a code example, see [Get product info for apps and add-ons](/windows/uwp/monetize/get-product-info-for-apps-and-add-ons).

## -examples

## -see-also
[StoreProductQueryResult](storeproductqueryresult.md), [Get product info for apps and add-ons](/windows/uwp/monetize/get-product-info-for-apps-and-add-ons), [Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Store)
