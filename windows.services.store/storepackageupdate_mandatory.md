---
-api-id: P:Windows.Services.Store.StorePackageUpdate.Mandatory
-api-type: winrt property
---

<!-- Property syntax
public bool Mandatory { get; }
-->

# Windows.Services.Store.StorePackageUpdate.Mandatory

## -description
Gets a value that indicates whether the package that has an update available for download from the Microsoft Store is a mandatory package, as specified by the developer in [Partner Center](https://partner.microsoft.com/dashboard).

## -property-value
True if the package is a mandatory package; otherwise, false.

## -remarks
The mandatory status of a package is not enforced by Microsoft, and the OS does not provide a UI to indicate to users that a mandatory app must be installed. Developers are intended to use the mandatory setting to enforce mandatory app updates in their own code that uses [GetAppAndOptionalStorePackageUpdatesAsync](storecontext_getappandoptionalstorepackageupdatesasync_399599716.md) to determine which packages have updates available and [RequestDownloadStorePackageUpdatesAsync](storecontext_requestdownloadstorepackageupdatesasync_889669938.md) or [RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync_1750789617.md) to download or install the updated packages.

For more information about using this property, including a code example, see [Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates).

## -examples

## -see-also
[Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates)