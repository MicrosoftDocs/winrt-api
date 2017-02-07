---
-api-id: T:Windows.Security.ExchangeActiveSyncProvisioning.EasPasswordExpirationResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.ExchangeActiveSyncProvisioning.EasPasswordExpirationResult : int
-->

# EasPasswordExpirationResult

## -description
> [!NOTE]
> [EasPasswordExpirationResult](easpasswordexpirationresult.md) may be unavailable for releases after Windows 10.

Results of querying on the password expiration information. These values are mapped against the HRESULT codes returned from the EAS policy engine.

## -enum-fields
### -field NotEvaluated:0
The policy is not set for evaluation.

### -field Compliant:1
The computer is compliant to the policy.HRESULT: S_OK and the user is controlled.

### -field CanBeCompliant:2
The computer can be compliant using the [ApplyAsync](easclientsecuritypolicy_applyasync.md) method.HRESULT: EAS_E_POLICY_COMPLIANT_WITH_ACTIONS and the user is an admin.

HRESULT: S_OK but the user is not controlled.

### -field RequestedPolicyIsStricter:3
The requested policy is stricter than the computer policies.HRESULT: EAS_E_POLICY_COMPLIANT_WITH_ACTIONS and the user is not an admin.

### -field RequestedExpirationIncompatible:4
The EAS password expiration policy cannot be met as the password expiration interval is less than the minimum password interval for the system.HRESULT: EAS_E_REQUESTED_POLICY_PASSWORD_EXPIRATION_INCOMPATIBLE

### -field InvalidParameter:5
The policy value is not in a valid range.HRESULT: HRESULT_FROM_WIN32(ERROR_INVALID_PARAMETER)

### -field UserCannotChangePassword:6
The user is not allowed to change the password. HRESULT: EAS_E_USER_CANNOT_CHANGE_PASSWORD

### -field AdminsCannotChangePassword:7
One or more admins are not allowed to change their passwords. HRESULT: EAS_E_ADMINS_CANNOT_CHANGE_PASSWORD

### -field LocalControlledUsersCannotChangePassword:8
There are other standard users present who are not allowed to change their passwords. HRESULT: EAS_E_LOCAL_CONTROLLED_USERS_CANNOT_CHANGE_PASSWORD


## -remarks

## -examples

## -see-also
[ApplyAsync](easclientsecuritypolicy_applyasync.md)