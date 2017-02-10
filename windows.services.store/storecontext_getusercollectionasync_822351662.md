---
-api-id: M:Windows.Services.Store.StoreContext.GetUserCollectionAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StoreProductQueryResult> GetUserCollectionAsync(Windows.Foundation.Collections.IIterable<System.String> productKinds)
-->

# Windows.Services.Store.StoreContext.GetUserCollectionAsync

## -description
Gets Windows Store info for the add-ons of the current app for which the user has entitlements to use.

## -parameters
### -param productKinds
An array of strings that specify the types of add-ons for which you want to retrieve listing info. For a list of the supported string values, see the [ProductKind](storeproduct_productkind.md) property.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreProductQueryResult](storeproductqueryresult.md) object that contains Windows Store listing info for the add-ons of the current app for which the user has entitlements to use.

## -remarks
For more information about using this method, including a code example, see [Get product info for apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/get-product-info-for-apps-and-add-ons).

## -examples

## -see-also
[Get product info for apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/get-product-info-for-apps-and-add-ons)