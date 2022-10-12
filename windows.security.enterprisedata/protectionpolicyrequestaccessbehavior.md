---
-api-id: T:Windows.Security.EnterpriseData.ProtectionPolicyRequestAccessBehavior
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.EnterpriseData.ProtectionPolicyRequestAccessBehavior : int
-->

# ProtectionPolicyRequestAccessBehavior

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Defines constants that you can use to override default behavior of the request access overloads of the [ProtectionPolicyManager](protectionpolicymanager.md) class.

## -enum-fields

### -field Decrypt:0

Indicates that an override action behaves as expected.

### -field TreatOverridePolicyAsBlock:1

Indicates that an override action behaves as a block action.

## -remarks

## -examples

## -see-also
