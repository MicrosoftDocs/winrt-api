---
-api-id: T:Windows.Security.ExchangeActiveSyncProvisioning.EasMaxPasswordFailedAttemptsResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.ExchangeActiveSyncProvisioning.EasMaxPasswordFailedAttemptsResult : int
-->

# EasMaxPasswordFailedAttemptsResult

## -description
> [!NOTE]
> EasMaxPasswordFailedAttemptsResult may be unavailable for releases after Windows 10.

Represents the maximum number of password attempts results. These values are mapped against the HRESULT codes returned from the EAS policy engine.

## -enum-fields
### -field NotEvaluated:0
The policy is not set for evaluation.

### -field Compliant:1
This computer is compliant to the policy.HRESULT: S_OK and the user is controlled.

### -field CanBeCompliant:2
This computer can be compliant by using the [ApplyAsync](easclientsecuritypolicy_applyasync_489349523.md) method.HRESULT: EAS_E_POLICY_COMPLIANT_WITH_ACTIONS and the user is an admin.

HRESULT: S_OK but the user is not controlled.

### -field RequestedPolicyIsStricter:3
The requested policy is stricter than the computer policies.HRESULT: EAS_E_POLICY_COMPLIANT_WITH_ACTIONS and the user is not an admin.

### -field InvalidParameter:4
The policy value is not in a valid range.HRESULT: HRESULT_FROM_WIN32(ERROR_INVALID_PARAMETER)


## -remarks

## -examples

## -see-also
