---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.IsFileProtectionRequiredForNewFileAsync(Windows.Storage.IStorageFolder,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> IsFileProtectionRequiredForNewFileAsync(Windows.Storage.IStorageFolder parentFolder, System.String identity, System.String desiredName)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.IsFileProtectionRequiredForNewFileAsync

## -description
Indicates whether a file needs to be protected by the enterprise identity.

## -parameters

### -param parentFolder
The folder that contains files that that you want to know whether to protect.

### -param identity
The enterprise identity.

### -param desiredName
The name that you would like to give the file.

## -returns
**true** if files in this folder should be protected, otherwise **false**.

## -remarks
See the remarks section of this method: [IsFileProtectionRequiredAsync](protectionpolicymanager_isfileprotectionrequiredasync.md).

## -examples

## -see-also
