---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.GetIsPackageIdentityAllowedToInstallForUserAsync(Windows.System.User,System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> AppInstallManager.GetIsPackageIdentityAllowedToInstallForUserAsync(User user, String correlationVector, String packageIdentityName, String publisherCertificateName)
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.GetIsPackageIdentityAllowedToInstallForUserAsync

## -description
Returns a value that indicates whether the package with the specified identity info is allowed to be installed on the current device for the specified user.

## -parameters
### -param user
An object that identifies the user to specify for this operation.

### -param correlationVector
A correlation vector string that can be used to generate telemetry data for the operation.

### -param packageIdentityName
The identity name of the package, as specified in the package manifest.

### -param publisherCertificateName
The publisher name of the package, as specified in the package manifest.

## -returns
True if the package with the specified identity info is allowed to be installed on the current device for the specified user; otherwise, false.

## -remarks
For more details about identity names and publisher names, see [Identity](/uwp/schemas/appxpackage/uapmanifestschema/element-identity) in the package manifest schema reference.

## -see-also

## -examples

## -capabilities
runFullTrust
