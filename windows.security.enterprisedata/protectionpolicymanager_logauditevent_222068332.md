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
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

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
