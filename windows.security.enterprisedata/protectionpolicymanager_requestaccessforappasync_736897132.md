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
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

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