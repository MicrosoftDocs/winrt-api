---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessForAppAsync(System.String,System.String,Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo,System.String,Windows.Security.EnterpriseData.ProtectionPolicyRequestAccessBehavior)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectionPolicyEvaluationResult> RequestAccessForAppAsync(System.String sourceIdentity, System.String appPackageFamilyName, Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo auditInfo, System.String messageFromApp, Windows.Security.EnterpriseData.ProtectionPolicyRequestAccessBehavior behavior)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessForAppAsync

## -description
Request access to enterprise-protected content for a specific target app.

## -parameters
### -param sourceIdentity
The enterprise identity to which the content is protected. This is an email address or domain that is managed.

### -param appPackageFamilyName
The enterprise identity to which the content is being disclosed. This is an email address or domain.

### -param auditInfo
An audit info object; an instance of [ProtectionPolicyAuditInfo](protectionpolicyauditinfo.md).

### -param messageFromApp
A message that will be displayed in the consent dialog so that the user can make a consent decision.

### -param behavior
A constant that defines how you would like to override default policy behavior.


## -returns
A value of the [ProtectionPolicyEvaluationResult](protectionpolicyevaluationresult.md) enumeration that is the result of the query.

## -remarks

## -examples

## -see-also
