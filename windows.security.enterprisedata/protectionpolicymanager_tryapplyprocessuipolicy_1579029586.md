---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.TryApplyProcessUIPolicy(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool TryApplyProcessUIPolicy(System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.TryApplyProcessUIPolicy

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Enables UI policy enforcement for an enterprise identity. When an app is about to display a protected file (such as a PDF) or resource (buffer or stream) on its UI, it must enable UI policy enforcement based on the identity the file is protected to. A call to TryApplyProcessUIPolicy ensures that the OS knows about the current context of the app.

## -parameters

### -param identity

The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

## -returns

**true** if the identity is being managed by an enterprise policy, or **false** if it is not.

## -remarks

## -examples

## -see-also

## -capabilities

enterpriseDataPolicy
