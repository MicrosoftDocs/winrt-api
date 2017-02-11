---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackageForUser(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Package FindPackageForUser(System.String userSecurityId, System.String packageFullName)
-->

# Windows.Management.Deployment.PackageManager.FindPackageForUser

## -description
Retrieves information about a specific package installed for a specific user or for all users.

## -parameters
### -param userSecurityId
This user security ID of the user for whom the specified package is being retrieved. If this parameter is **null**, the specified package is retrieved for the current user.

### -param packageFullName
The full name of the package.

## -returns
The package.

## -remarks
This method requires administrative privileges if the user security ID specified is different from the user security ID of the calling user. Otherwise, an AccessDeniedException is thrown.

## -examples

## -see-also


## -capabilities
packageQuery