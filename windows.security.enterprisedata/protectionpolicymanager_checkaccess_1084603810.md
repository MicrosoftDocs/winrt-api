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
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

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
