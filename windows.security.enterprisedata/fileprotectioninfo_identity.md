---
-api-id: P:Windows.Security.EnterpriseData.FileProtectionInfo.Identity
-api-type: winrt property
---

<!-- Property syntax
public string Identity { get; }
-->

# Windows.Security.EnterpriseData.FileProtectionInfo.Identity

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

The enterprise identity of the enterprise protected file.

## -property-value

The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

## -remarks

## -examples

## -see-also

[IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md)
