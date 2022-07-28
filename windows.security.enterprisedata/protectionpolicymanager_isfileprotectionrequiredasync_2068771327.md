---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.IsFileProtectionRequiredAsync(Windows.Storage.IStorageItem,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> IsFileProtectionRequiredAsync(Windows.Storage.IStorageItem target, System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.IsFileProtectionRequiredAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

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
