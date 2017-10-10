---
-api-id: M:Windows.Phone.Management.Deployment.InstallationManager.FindPackages
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackages()
-->

# Windows.Phone.Management.Deployment.InstallationManager.FindPackages

## -description
Retrieves information about all packages installed across all users.

## -returns
If the method succeeds, an enumerable collection of package objects is returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location.

## -remarks
> This method requires the ID_CAP_OEM_DEPLOYMENT capability and is not intended to be used directly from your code.

## -examples

## -see-also
[FindPackages(String, String)](installationmanager_findpackages_1597689551.md)
## -capabilities
oemDeployment
