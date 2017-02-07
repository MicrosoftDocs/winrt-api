---
-api-id: T:Windows.Security.ExchangeActiveSyncProvisioning.EasMinPasswordLengthResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.ExchangeActiveSyncProvisioning.EasMinPasswordLengthResult : int
-->

# EasMinPasswordLengthResult

## -description
> [!NOTE]
> [EasMinPasswordLengthResult](easminpasswordlengthresult.md) may be unavailable for releases after Windows 10.

Represents the minimum length result for passwords. These values are mapped against the HRESULT codes returned from the EAS policy engine.

## -enum-fields
### -field NotEvaluated:0
The policy is not set for evaluation.

### -field Compliant:1
This computer is compliant to the policy.HRESULT: S_OK and the user is controlled.

### -field CanBeCompliant:2
This computer can be compliant by using the [ApplyAsync](easclientsecuritypolicy_applyasync.md) method.HRESULT: EAS_E_POLICY_COMPLIANT_WITH_ACTIONS and the user is not an admin.

HRESULT: S_OK but the user is not controlled.

### -field RequestedPolicyIsStricter:3
The requested policy is stricter than the computer policies.HRESULT: EAS_E_POLICY_COMPLIANT_WITH_ACTIONS and the user is not an admin.

### -field RequestedPolicyNotEnforceable:4
The EAS policy being evaluated cannot be enforced by the system.HRESULT: EAS_E_REQUESTED_POLICY_NOT_ENFORCEABLE

### -field InvalidParameter:5
The policy value is not in a valid range.HRESULT: HRESULT_FROM_WIN32(ERROR_INVALID_PARAMETER)

### -field CurrentUserHasBlankPassword:6
The EAS password policies for the user cannot be evaluated as the user has a blank password.HRESULT: EAS_E_CURRENT_USER_HAS_BLANK_PASSWORD

### -field AdminsHaveBlankPassword:7
The EAS password policies cannot be evaluated as one or more admins have blank passwords. HRESULT: EAS_E_ADMINS_HAVE_BLANK_PASSWORD

### -field UserCannotChangePassword:8
The user is not allowed to change the password. HRESULT: EAS_E_USER_CANNOT_CHANGE_PASSWORD

### -field AdminsCannotChangePassword:9
One or more admins are not allowed to change their passwords. HRESULT: EAS_E_ADMINS_CANNOT_CHANGE_PASSWORD

### -field LocalControlledUsersCannotChangePassword:10
There are other standard users present who are not allowed to change their passwords. HRESULT: EAS_E_LOCAL_CONTROLLED_USERS_CANNOT_CHANGE_PASSWORD

### -field ConnectedAdminsProviderPolicyIsWeak:11
The EAS password policy cannot be enforced by the connected account provider of at least one administrator.HRESULT: EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CONNECTED_ADMINS

### -field ConnectedUserProviderPolicyIsWeak:12
The EAS password policy cannot be enforced by the connected account provider of the current user.HRESULT: EAS_E_PASSWORD_POLICY_NOT_ENFORCEABLE_FOR_CURRENT_CONNECTED_USER

### -field ChangeConnectedAdminsPassword:13
There is at least one administrator whose connected account password must be changed for EAS password policy compliance.HRESULT: EAS_E_CONNECTED_ADMINS_NEED_TO_CHANGE_PASSWORD

### -field ChangeConnectedUserPassword:14
The connected account password for the current user must be changed for EAS password policy compliance.HRESULT: EAS_E_CURRENT_CONNECTED_USER_NEED_TO_CHANGE_PASSWORD


## -remarks

## -examples

## -see-also