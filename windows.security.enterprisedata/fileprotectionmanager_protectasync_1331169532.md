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
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

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
