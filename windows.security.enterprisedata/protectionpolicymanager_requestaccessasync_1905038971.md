---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessAsync(System.String,System.String,Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo,System.String,Windows.Security.EnterpriseData.ProtectionPolicyRequestAccessBehavior)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.EnterpriseData.ProtectionPolicyEvaluationResult> RequestAccessAsync(System.String sourceIdentity, System.String targetIdentity, Windows.Security.EnterpriseData.ProtectionPolicyAuditInfo auditInfo, System.String messageFromApp, Windows.Security.EnterpriseData.ProtectionPolicyRequestAccessBehavior behavior)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.RequestAccessAsync

## -description
Request access to enterprise protected content for an identity

## -parameters
### -param sourceIdentity
The enterprise identity to which the content is protected.

### -param targetIdentity
The enterprise identity to which the content is being disclosed. This is an email address or domain.

### -param auditInfo
An audit info object; an instance of [ProtectionPolicyAuditInfo](protectionpolicyauditinfo.md).

### -param messageFromApp
A message that will be displayed in the consent dialog so that the user can make a consent decision.

### -param behavior
A constant that defines how you would like to override default policy behavior.

## -returns
A value of the [ProtectionPolicyEvaluationResult](protectionpolicyevaluationresult.md) enumeration that is the result of the request.

## -remarks
Call this method from the main UI thread of your foreground app.

## -examples

## -see-also