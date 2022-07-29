---
-api-id: M:Windows.Security.EnterpriseData.FileProtectionManager.CopyProtectionAsync(Windows.Storage.IStorageItem,Windows.Storage.IStorageItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> CopyProtectionAsync(Windows.Storage.IStorageItem source, Windows.Storage.IStorageItem target)
-->

# Windows.Security.EnterpriseData.FileProtectionManager.CopyProtectionAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Replicate the file protection of one file onto another file.

## -parameters

### -param source

The source file, from which file protection is being copied.

### -param target

The target file, to which file protection is being copied.

## -returns

When the call to this method completes successfully, it returns **true** if the file protection was copied, or **false** if there was an error.

## -remarks

## -examples

## -see-also

## -capabilities

enterpriseDataPolicy
