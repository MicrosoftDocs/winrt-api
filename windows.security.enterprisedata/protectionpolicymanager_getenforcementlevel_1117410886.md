---
-api-id: M:Windows.Security.EnterpriseData.ProtectionPolicyManager.GetEnforcementLevel(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Security.EnterpriseData.EnforcementLevel GetEnforcementLevel(System.String identity)
-->

# Windows.Security.EnterpriseData.ProtectionPolicyManager.GetEnforcementLevel

## -description
> [!NOTE]
> Windows Information Protection (WIP) policy cannot be applied on Windows 10, version 1511 (build 10586) or earlier.

You can use this method to determine the current Windows Information Protection (WIP) enforcement level. WIP enforcement level is one aspect of mobile device management (MDM) policy configuration.

## -parameters
### -param identity
The enterprise identity. This is an email address or domain that is managed. Your app should use [IsIdentityManaged](protectionpolicymanager_isidentitymanaged.md) to confirm that an email address or domain is managed.

## -returns
A value of the [EnforcementLevel](enforcementlevel.md) enumeration.

## -remarks

## -examples

## -see-also
