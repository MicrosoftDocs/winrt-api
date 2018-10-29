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
The folder that contains files that you want to know whether to protect.

### -param identity
The enterprise identity.

>[!IMPORTANT]
>Due to a bug in the current implementation of this property, please pass the enterprise identity to the *desiredName* parameter.

### -param desiredName
The name that you would like to give the file.

>[!IMPORTANT]
>Due to a bug in the current implementation of this property, please pass this name to the *identity* parameter.

## -returns
**true** if files in this folder should be protected, otherwise **false**.

## -remarks
See the remarks section of this method: [IsFileProtectionRequiredAsync](protectionpolicymanager_isfileprotectionrequiredasync_2068771327.md).

## -examples

## -see-also
