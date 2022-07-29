---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.IsFileProtectionRequiredForNewFileAsync(Windows.Storage.IStorageFolder,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> IsFileProtectionRequiredForNewFileAsync(Windows.Storage.IStorageFolder parentFolder, System.String identity, System.String desiredName)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.IsFileProtectionRequiredForNewFileAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

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
