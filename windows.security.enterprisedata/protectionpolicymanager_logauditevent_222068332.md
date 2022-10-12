---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.LogAuditEvent(System.String,System.String,Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo)
-api-type: winrt method
---

<!-- Method syntax
public void LogAuditEvent(System.String sourceIdentity, System.String targetIdentity, Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo auditInfo)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.LogAuditEvent

## -description

> [!NOTE]
> Starting in July 2022, Microsoft is deprecating Windows Information Protection (WIP) and the APIs that support WIP. Microsoft will continue to support WIP on supported versions of Windows. New versions of Windows won't include new capabilities for WIP, and it won't be supported in future versions of Windows. For more information, see [Announcing sunset of Windows Information Protection](https://techcommunity.microsoft.com/t5/windows-it-pro-blog/announcing-the-sunset-of-windows-information-protection-wip/ba-p/3579282).
>
> For your data protection needs, Microsoft recommends that you use [Microsoft Purview Information Protection](/microsoft-365/compliance/information-protection) and [Microsoft Purview Data Loss Prevention](/microsoft-365/compliance/dlp-learn-about-dlp). Purview simplifies the configuration set-up and provides an advanced set of capabilities.

Causes an audit event to be logged.

## -parameters

### -param sourceIdentity

The enterprise identity to which the content is protected. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to confirm that an email address or domain is managed.

### -param targetIdentity

The enterprise identity to which the content is being disclosed. This is an email address or domain.

### -param auditInfo

An audit info object; an instance of [ProtectionPolicyAuditInfo](protectionpolicyauditinfo.md).

## -remarks

## -examples

## -see-also
