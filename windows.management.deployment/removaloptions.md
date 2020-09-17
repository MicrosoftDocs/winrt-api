---
-api-id: T:Windows.Management.Deployment.RemovalOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Management.Deployment.RemovalOptions : uint
-->

# RemovalOptions

## -description
Values that modify the removal of a package.

## -enum-fields
### -field None:0
No removal options are specified. This is the default deployment behavior.

### -field PreserveRoamableApplicationData:128
Don't remove the roamable portion of the app's data when the package is removed. This value is not supported with the **PreserveApplicationData** and **RemoveForAllUsers** fields. This field is useful in virtual desktop scenarios when additional work needs to be performed to enable the portable part of the app's state to be roamed between remote servers so that a user's virtual desktop session can be logged onto different servers without loss of app state.  

### -field PreserveApplicationData:4096
Don't remove any application data when the package is removed. This can only apply to packages that were deployed with the [DeploymentOptions.DevelopmentMode](deploymentoptions.md) value. If you specify **PreserveApplicationData** on an incompatible package, [PackageManager.RemovePackageAsync(String, RemovalOptions)](packagemanager_removepackageasync_1331217245.md) returns **E_INVALIDARG**.

### -field RemoveForAllUsers:524288
Removes a package for all users on the device.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | RemoveForAllUsers |
| 2004 | 19041 | PreserveRoamableApplicationData |

## -examples

## -see-also

[PackageManager.RemovePackageAsync(String, RemovalOptions)](packagemanager_removepackageasync_1331217245.md)
