---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.CheckAccessForApp(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.EnterpriseData.ProtectionPolicyEvaluationResult CheckAccessForApp(System.String sourceIdentity, System.String appPackageFamilyName)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.CheckAccessForApp

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Perform enterprise-protection policy evaluation for a data transfer between your app and a specific target app.

## -parameters
### -param sourceIdentity
The source enterprise identity of the app. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged_906801364.md) to check if an email address or domain is managed.

### -param appPackageFamilyName
The package family name of the app you want to check has access to the protected content.

## -returns
A value of the [ProtectionPolicyEvaluationResult](protectionpolicyevaluationresult.md) enumeration that is the result of the query.

## -remarks

## -examples

## -see-also
