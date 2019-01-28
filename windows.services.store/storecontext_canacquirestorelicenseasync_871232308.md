---
-api-id: M:Windows.Services.Store.StoreContext.CanAcquireStoreLicenseAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<StoreCanAcquireLicenseResult> StoreContext.CanAcquireStoreLicenseAsync(String productStoreId)
-->

# Windows.Services.Store.StoreContext.CanAcquireStoreLicenseAsync

## -description
Gets a value that indicates whether a license can be acquired for the specified downloadable content (DLC) add-on of the current app for the current user.

## -parameters
### -param productStoreId
The Store ID of the DLC add-on to check.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreCanAcquireLicenseResult](storecanacquirelicenseresult.md) object that indicates whether the license can be acquired.

## -remarks
The Store ID for an add-on is available in [Partner Center](https://partner.microsoft.com/dashboard), and it is returned by the [StoreId](storeproduct_storeid.md) property of the [StoreProduct](storeproduct.md) that represents the add-on.

> [!NOTE]
> Downloadable content (DLC) add-on are not available to all developer accounts.

## -see-also
[AcquireStoreLicenseForOptionalPackageAsync](storecontext_acquirestorelicenseforoptionalpackageasync_1044105908.md)

## -examples
