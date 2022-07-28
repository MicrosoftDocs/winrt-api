---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.GetPrimaryManagedIdentityForIdentity(System.String)
-api-type: winrt method
---

<!-- Method syntax
public string GetPrimaryManagedIdentityForIdentity(System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.GetPrimaryManagedIdentityForIdentity

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Gets the parent or primary identity of a given child or secondary identity.

## -parameters

### -param identity

The child or secondary identity that you want to use to get the parent or primary identity.

## -returns

The parent or primary identity.

## -remarks

Most policies have a list of identities. The primary identity usually appears first in that list. The secondary identities usually appear after the primary identity. Those secondary identities are, in a sense "owned" by the primary identity.

## -examples

## -see-also
