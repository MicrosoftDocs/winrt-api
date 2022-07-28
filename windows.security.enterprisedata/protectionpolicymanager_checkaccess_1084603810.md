---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.CheckAccess(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.EnterpriseData.ProtectionPolicyEvaluationResult CheckAccess(System.String sourceIdentity, System.String targetIdentity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.CheckAccess

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Request if access to enterprise-protected content is available to an identity.

## -parameters

### -param sourceIdentity

The source enterprise identity of the app. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to check if an email address or domain is managed.

### -param targetIdentity

The enterprise identity you want to check has access to the protected content.

## -returns

A value of the [ProtectionPolicyEvaluationResult](protectionpolicyevaluationresult.md) enumeration that is the result of the query.

## -remarks

## -examples

## -see-also

## -capabilities

enterpriseDataPolicy
