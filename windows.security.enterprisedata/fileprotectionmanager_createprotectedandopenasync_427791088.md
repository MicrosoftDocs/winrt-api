---
-api-id: M:Windows.Security.EnterpriseData.FileProtectionManager.CreateProtectedAndOpenAsync(Windows.Storage.IStorageFolder,System.String,System.String,Windows.Storage.CreationCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectedFileCreateResult> CreateProtectedAndOpenAsync(Windows.Storage.IStorageFolder parentFolder, System.String desiredName, System.String identity, Windows.Storage.CreationCollisionOption collisionOption)
-->

# Windows.Security.EnterpriseData.FileProtectionManager.CreateProtectedAndOpenAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Create an enterprise-protected file.

## -parameters
### -param parentFolder
The folder into which to create the enterprise protected file.

### -param desiredName
The desired name of the new enterprise protected file.

### -param identity
The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged.md) to confirm that an email address or domain is managed.

### -param collisionOption
A [CreationCollisionOption](../windows.storage/creationcollisionoption.md) value that specifies what to do if *desiredName* already exists.

## -returns
When the call to this method completes successfully, it returns a [ProtectedFileCreateResult](protectedfilecreateresult.md) object representing the newly created protected file.

## -remarks

## -examples

## -see-also
[CreationCollisionOption](../windows.storage/creationcollisionoption.md), [IsIdentityManaged](protectionpolicymanager_isidentitymanaged.md), [ProtectedFileCreateResult](protectedfilecreateresult.md)

## -capabilities
enterpriseDataPolicy