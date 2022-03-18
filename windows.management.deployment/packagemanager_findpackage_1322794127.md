---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackage(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Package FindPackage(System.String packageFullName)
-->

# Windows.Management.Deployment.PackageManager.FindPackage

## -description
Retrieves information about the specified [Package](/uwp/api/windows.applicationmodel.package) installed for any user.

## -parameters
### -param packageFullName
The full name of the package. This parameter cannot be null.

## -returns
If this method succeeds it returns a package object that contains information about the specified package, including but not limited to its name, publisher, version, and install location. If the specified package is not found, this method returns **null**.

## -remarks
This method requires administrative privileges. The returned package may be installed for the current user or for another user.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -capabilities
packageQuery
