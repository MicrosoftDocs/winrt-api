---
-api-id: M:Windows.Security.EnterpriseData.FileProtectionManager.ProtectAsync(Windows.Storage.IStorageItem,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.FileProtectionInfo> ProtectAsync(Windows.Storage.IStorageItem target, System.String identity)
-->

# Windows.Security.EnterpriseData.FileProtectionManager.ProtectAsync

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Protect the data in a file to an enterprise identity. The app can then use standard API to read or write from the file.

## -parameters
### -param target
The file to be protected.

### -param identity
The enterprise identity. This is an email address or domain that is managed. Use [ProtectionPolicyManager.IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed before using the identity to protect a file.

## -returns
When the call to this method completes successfully, it returns a [FileProtectionInfo](fileprotectioninfo.md) object that contains the status of the newly protected file.

## -remarks

## -examples

## -see-also
[FileProtectionInfo](fileprotectioninfo.md), [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md)

## -capabilities
enterpriseDataPolicy
