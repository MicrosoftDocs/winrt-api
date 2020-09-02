---
-api-id: M:Windows.Services.Store.StoreProduct.GetIsAnySkuInstalledAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> GetIsAnySkuInstalledAsync()
-->

# Windows.Services.Store.StoreProduct.GetIsAnySkuInstalledAsync

## -description
Indicates whether any SKU of this product is installed on the current device. This method is intended to be used for products that have downloadable content (DLC).

## -returns
An asynchronous operation that, on successful completion, returns true if a SKU of this product is installed on the current device; otherwise, false.

## -remarks
To determine whether the product has downloadable content, use the [HasDigitalDownload](storeproduct_hasdigitaldownload.md) property.

> [!NOTE]
> Downloadable content (DLC) packages are not available to all developer accounts.

## -examples

## -see-also
[Optional packages and related set authoring](/windows/uwp/packaging/optional-packages)
