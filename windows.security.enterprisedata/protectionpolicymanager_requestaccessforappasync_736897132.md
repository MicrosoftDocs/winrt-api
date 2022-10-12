---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessForAppAsync(System.String,System.String,Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectionPolicyEvaluationResult> RequestAccessForAppAsync(System.String sourceIdentity, System.String appPackageFamilyName, Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo auditInfo, System.String messageFromApp)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessForAppAsync

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Request access to enterprise-protected content for a specific target app.

## -parameters

### -param sourceIdentity

The enterprise identity to which the content is protected. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

### -param appPackageFamilyName

The enterprise identity to which the content is being disclosed. This is an email address or domain.

### -param auditInfo

An audit info object; an instance of [ProtectionPolicyAuditInfo](protectionpolicyauditinfo.md).

### -param messageFromApp

A message that will be displayed in the consent dialog so that the user can make a consent decision.

## -returns

A value of the [ProtectionPolicyEvaluationResult](protectionpolicyevaluationresult.md) enumeration that is the result of the query.

## -remarks

## -examples

## -see-also

[RequestAccessForAppAsync(String, String, ProtectionPolicyAuditInfo)](protectionpolicymanager_requestaccessforappasync_404496020.md), [RequestAccessForAppAsync(String, String)](protectionpolicymanager_requestaccessforappasync_377805400.md)
