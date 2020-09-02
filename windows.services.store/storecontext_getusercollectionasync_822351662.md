---
-api-id: M:Windows.Services.Store.StoreContext.GetUserCollectionAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StoreProductQueryResult> GetUserCollectionAsync(Windows.Foundation.Collections.IIterable<System.String> productKinds)
-->

# Windows.Services.Store.StoreContext.GetUserCollectionAsync

## -description
Gets Microsoft Store info for the add-ons of the current app for which the user has purchased.

## -parameters
### -param productKinds
An array of strings that specify the types of add-ons for which you want to retrieve info. For a list of the supported string values, see the [ProductKind](storeproduct_productkind.md) property.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreProductQueryResult](storeproductqueryresult.md) object that contains Microsoft Store info for the add-ons of the current app for which the user has purchased and relevant error info.

## -remarks
For more information about using this method, including a code example, see [Get product info for apps and add-ons](/windows/uwp/monetize/get-product-info-for-apps-and-add-ons).

If the current user is not signed in to the Store, the [ExtendedError](storeproductqueryresult_extendederror.md) property of the [StoreProductQueryResult](storeproductqueryresult.md) return value will return the error code 0x80070525 (**ERROR_NO_SUCH_USER**).

## -examples

## -see-also
[Get product info for apps and add-ons](/windows/uwp/monetize/get-product-info-for-apps-and-add-ons)
