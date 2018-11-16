---
-api-id: P:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.CanInstallForAllUsers
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool CanInstallForAllUsers { get; }
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.CanInstallForAllUsers

## -description
Gets or sets a value that indicates whether the calling app has elevated administrative privileges to ensure installing an app for all users will succeed.

## -property-value
True indicates the calling app has elevated administrative privileges; otherwise, false.

## -remarks
The calling app must have elevated admin privileges when installing an app for all users otherwise an Access Denied error will be thrown when attempted.

## -see-also

## -examples
