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

### -field PreserveApplicationData:4096
Don't remove any application data when the package is removed. This can only apply to packages that were deployed with the [DeploymentOptions::DevelopmentMode](deploymentoptions.md) value. If you specify **PreserveApplicationData** on an incompatible package, [PackageManager::RemovePackageAsync(String, RemovalOptions)](packagemanager_removepackageasync_1331217245.md) returns **E_INVALIDARG**.


## -remarks

## -examples

## -see-also
[PackageManager::RemovePackageAsync(String, RemovalOptions)](packagemanager_removepackageasync_1331217245.md)