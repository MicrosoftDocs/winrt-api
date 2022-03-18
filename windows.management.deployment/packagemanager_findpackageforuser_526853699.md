---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackageForUser(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Package FindPackageForUser(System.String userSecurityId, System.String packageFullName)
-->

# Windows.Management.Deployment.PackageManager.FindPackageForUser

## -description
Retrieves information about a specific [Package](/uwp/api/windows.applicationmodel.package) installed for a specific user or for all users.

## -parameters
### -param userSecurityId
The user security identifier (SID). If this parameter is string.Empty, the packages are retrieved for the current user.

### -param packageFullName
The full name of the package.

## -returns
The package.

## -remarks
This method requires administrative privileges if the user security ID specified is different from the user security ID of the calling user. Otherwise, an AccessDeniedException is thrown.

## -examples

## -see-also

[Package](/uwp/api/windows.applicationmodel.package)

## -capabilities
packageQuery
