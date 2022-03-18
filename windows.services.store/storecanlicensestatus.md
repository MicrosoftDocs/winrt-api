---
-api-id: T:Windows.Services.Store.StoreCanLicenseStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum StoreCanLicenseStatus : int
-->

# Windows.Services.Store.StoreCanLicenseStatus

## -description
Defines values that represent the license status for a downloadable content (DLC) add-on package.

## -enum-fields
### -field ServerError:4
The license request did not succeed because of a server error returned by the Microsoft Store.

### -field NotLicensableToUser:0
The user doesn't have the right to acquire a license for the product.

### -field NetworkError:3
The license request did not succeed because of a network connectivity error.

### -field LicenseActionNotApplicableToProduct:2
The product is not individually licensable. For example, this can occur if you pass a Store ID to the [CanAcquireStoreLicenseAsync(String)](storecontext_canacquirestorelicenseasync_871232308.md) method for a non-DLC add-on (that is, an add-on without a package).

### -field Licensable:1
The product can be licensed to the current user.

## -remarks

## -see-also
[StoreCanAcquireLicenseResult.Status](storecanacquirelicenseresult_status.md),[CanAcquireStoreLicenseAsync](storecontext_canacquirestorelicenseasync_871232308.md),[CanAcquireStoreLicenseForOptionalPackageAsync](storecontext_canacquirestorelicenseforoptionalpackageasync_846442686.md),[Optional packages and related set authoring](/windows/uwp/packaging/optional-packages)

## -examples
