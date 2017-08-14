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
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

Enables UI policy enforcement for an enterprise identity. When an app is about to display a protected file (such as a PDF) or resource (buffer or stream) on its UI, it must enable UI policy enforcement based on the identity the file is protected to. A call to [TryApplyProcessUIPolicy](protectionpolicymanager_tryapplyprocessuipolicy.md) ensures that the OS knows about the current context of the app.

## -parameters
### -param identity
The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged.md) to confirm that an email address or domain is managed.

## -returns
**true** if the identity is being managed by an enterprise policy, or **false** if it is not.

## -remarks

## -examples

## -see-also


## -capabilities
enterpriseDataPolicy
