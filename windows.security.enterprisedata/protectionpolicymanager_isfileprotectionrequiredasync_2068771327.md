---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.IsFileProtectionRequiredAsync(Windows.Storage.IStorageItem,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> IsFileProtectionRequiredAsync(Windows.Storage.IStorageItem target, System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.IsFileProtectionRequiredAsync

## -description
Indicates whether a file needs to be protected by the enterprise identity.

## -parameters
### -param target
The file that you want to know whether to protect.

### -param identity
The enterprise identity.

## -returns
**true** if the file should be protected, otherwise **false**.

## -remarks
Your code can call this method to avoid encrypting files that don’t need to be encrypted such as exe, dll, and other build artifacts. This lowers the risk of those files being inaccessible to other users of a computer and lowers performance cost for unnecessarily encrypting files.

## -examples

## -see-also