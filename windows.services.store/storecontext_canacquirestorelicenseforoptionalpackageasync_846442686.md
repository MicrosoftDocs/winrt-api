---
-api-id: M:Windows.Services.Store.StoreContext.CanAcquireStoreLicenseForOptionalPackageAsync(Windows.ApplicationModel.Package)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<StoreCanAcquireLicenseResult> StoreContext.CanAcquireStoreLicenseForOptionalPackageAsync(Package optionalPackage)
-->

# Windows.Services.Store.StoreContext.CanAcquireStoreLicenseForOptionalPackageAsync

## -description
Gets a value that indicates whether a license can be acquired for the specified downloadable content (DLC) package of the current app for the current user.

## -parameters
### -param optionalPackage
The DLC package to check.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreCanAcquireLicenseResult](storecanacquirelicenseresult.md) object that indicates whether the license can be acquired.

## -remarks
> [!NOTE]
> Downloadable content (DLC) packages are not available to all developer accounts.

## -see-also
[AcquireStoreLicenseForOptionalPackageAsync](storecontext_acquirestorelicenseforoptionalpackageasync_1044105908.md)

## -examples
