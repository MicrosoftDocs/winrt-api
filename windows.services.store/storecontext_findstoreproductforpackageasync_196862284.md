---
-api-id: M:Windows.Services.Store.StoreContext.FindStoreProductForPackageAsync(Windows.Foundation.Collections.IIterable{System.String},Windows.ApplicationModel.Package)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<StoreProductResult> StoreContext.FindStoreProductForPackageAsync(IIterable<String> productKinds, Package package)
-->

# Windows.Services.Store.StoreContext.FindStoreProductForPackageAsync


## -description

Gets Store product details for the app or add-on that is associated with the specified package.

## -parameters

### -param productKinds

An array of strings that specify the types of Store products that might be associated with the package. For a list of the supported string values, see the [ProductKind](storeproduct_productkind.md) property.

### -param package

A [Package](../windows.applicationmodel/package.md) that represents the package for which you want to get the corresponding Store product details.

## -returns

An asynchronous operation that, on successful completion, returns a [StoreProductResult](storeproductresult.md) object. Use the [Product](storeproductresult_product.md) property of this object to access a [StoreProduct](storeproduct.md) that contains Store product details for the specified package.

## -remarks

Use this method to get Store product details (such as the Store ID) for a package that is associated with the current app or an add-on for the current app. This method may return errors if the package is not associated with the current app, the current device is offline, or if the current app was not installed from the Store (for example, if the app was sideloaded). In these cases, you can examine the [ExtendedError](storeproductresult_extendederror.md) property of the [StoreProductResult](storeproductresult.md) return object to get more details about the error.

## -examples

## -see-also

[StoreContext](storecontext.md), [StoreProduct](storeproduct.md), [Get product info for apps and add-ons](/windows/uwp/monetize/get-product-info-for-apps-and-add-ons)

