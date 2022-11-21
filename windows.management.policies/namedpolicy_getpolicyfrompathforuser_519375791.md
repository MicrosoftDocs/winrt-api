---
-api-id: M:Windows.Management.Policies.NamedPolicy.GetPolicyFromPathForUser(Windows.System.User,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public NamedPolicyData NamedPolicy.GetPolicyFromPathForUser(User user, String area, String name)
-->

# Windows.Management.Policies.NamedPolicy.GetPolicyFromPathForUser


## -description

Gets a valid MDM user policy given the specified MDM policy name and area name. This gets a policy specific to a user, whereas [GetPolicyFromPath](namedpolicy_getpolicyfrompath_340705329.md) gets a global policy.

## -parameters

### -param user

The user data for user policies.

### -param area

A string representing the area name for a policy.

### -param name

A string representing the name of the policy.

## -returns

The NamedPolicyData for the policy specified by the user, area, and name parameters.

## -remarks

## -see-also

[Policy CSP](/windows/client-management/mdm/policy-configuration-service-provider)

## -examples

