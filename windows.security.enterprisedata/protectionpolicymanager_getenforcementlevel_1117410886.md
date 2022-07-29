---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.GetEnforcementLevel(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.EnterpriseData.EnforcementLevel GetEnforcementLevel(System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.GetEnforcementLevel

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

You can use this method to determine the current Windows Information Protection (WIP) enforcement level. WIP enforcement level is one aspect of mobile device management (MDM) policy configuration.

## -parameters

### -param identity

The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

## -returns

A value of the [EnforcementLevel](enforcementlevel.md) enumeration.

## -remarks

## -examples

## -see-also
