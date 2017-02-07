---
-api-id: T:Windows.Security.ExchangeActiveSyncProvisioning.EasDisallowConvenienceLogonResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.ExchangeActiveSyncProvisioning.EasDisallowConvenienceLogonResult : int
-->

# EasDisallowConvenienceLogonResult

## -description
> [!NOTE]
> [EasDisallowConvenienceLogonResult](easdisallowconveniencelogonresult.md) may be unavailable for releases after Windows 10.

Results of whether the logon can occur. These values are mapped against the HRESULT codes returned from the EAS policy engine.

## -enum-fields
### -field NotEvaluated:0
The policy is not set for evaluation.

### -field Compliant:1
This computer is compliant to the policy.HRESULT: S_OK and the user is controlled.

### -field CanBeCompliant:2
This computer can be compliant by using the [ApplyAsync](easclientsecuritypolicy_applyasync.md) method.HRESULT: EAS_E_POLICY_COMPLIANT_WITH_ACTIONS and the user is an admin.

HRESULT: S_OK but the user is not controlled.

### -field RequestedPolicyIsStricter:3
The requested policy is stricter than the computer policies.HRESULT: EAS_E_POLICY_COMPLIANT_WITH_ACTIONS and the user is not an admin.


## -remarks

## -examples

## -see-also