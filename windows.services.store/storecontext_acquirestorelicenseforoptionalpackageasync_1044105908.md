---
-api-id: M:Windows.Services.Store.StoreContext.AcquireStoreLicenseForOptionalPackageAsync(Windows.ApplicationModel.Package)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StoreAcquireLicenseResult> AcquireStoreLicenseForOptionalPackageAsync(Windows.ApplicationModel.Package optionalPackage)
-->

# Windows.Services.Store.StoreContext.AcquireStoreLicenseForOptionalPackageAsync

## -description
Acquires a license for the specified downloadable content (DLC) add-on package for the current app.

## -parameters
### -param optionalPackage
The DLC add-on package for which to acquire a license.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreAcquireLicenseResult](storeacquirelicenseresult.md) object that contains the license.

## -remarks
> [!NOTE]
> Downloadable content (DLC) packages are not available to all developer accounts.

## -examples

## -see-also
[Optional packages and related set authoring](/windows/uwp/packaging/optional-packages)
