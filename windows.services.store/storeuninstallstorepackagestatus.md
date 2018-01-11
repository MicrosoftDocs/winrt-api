---
-api-id: T:Windows.Services.Store.StoreUninstallStorePackageStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum StoreUninstallStorePackageStatus : int
-->

# Windows.Services.Store.StoreUninstallStorePackageStatus

## -description
Defines values that represent the status of a package uninstall request.

## -enum-fields
### -field UninstallNotApplicable:3
The uninstall operation is not applicable to the specified package.

### -field Succeeded:0
The uninstall operation succeeded.

### -field NetworkError:2
The uninstall operation did not succeed because of a network connectivity error.

### -field Error:4
The uninstall operation did not succeed because of an unknown error.

### -field CanceledByUser:1
The uninstall operation was canceled by the user.

## -remarks

## -see-also
[Status](storeuninstallstorepackageresult_status.md)

## -examples
