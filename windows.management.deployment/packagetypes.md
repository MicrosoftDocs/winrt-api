---
-api-id: T:Windows.Management.Deployment.PackageTypes
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Management.Deployment.PackageTypes : uint
-->

# PackageTypes

## -description
Defines the types of [Package](/uwp/api/windows.applicationmodel.package) to be included in the result set of a query.

## -enum-fields
### -field None:0
Default inventorying behavior.

### -field Main:1
Include the main packages when you enumerate the package repository.

### -field Framework:2
Include the framework packages when you enumerate the package repository.

### -field Resource:4
Include the resource packages when you enumerate the package repository.

### -field Bundle:8
Include the bundle packages when you enumerate the package repository.

### -field Xap:16
Include the XAP packages when you enumerate the package repository.

### -field Optional:32
Include the optional packages when you enumerate the package repository.

### -field All:4294967295
Include all packages when you enumerate the package repository.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | Optional |
| 2004 | 19041 | All |

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [FindPackagesForUserWithPackageTypes](/uwp/api/windows.management.deployment.packagemanager.findpackagesforuserwithpackagetypes), [FindPackagesWithPackageTypes](/uwp/api/windows.management.deployment.packagemanager.findpackageswithpackagetypes)
