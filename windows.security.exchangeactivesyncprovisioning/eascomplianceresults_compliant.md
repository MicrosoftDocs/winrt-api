---
-api-id: P:Windows.Security.ExchangeActiveSyncProvisioning.EasComplianceResults.Compliant
-api-type: winrt property
---

<!-- Property syntax
public bool Compliant { get; }
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasComplianceResults.Compliant

## -description
> [!NOTE]
> [EasComplianceResults](eascomplianceresults.md) may be unavailable for releases after Windows 10.

Returns the result of whether the computer is compliant with the EAS policies.

## -property-value
The result of whether the computer is compliant with the EAS policies. The [Compliant](eascomplianceresults_compliant.md) property is set to TRUE if all of the policies being evaluated are compliant. Otherwise, it is set to FALSE.

## -remarks
The mail app needs to scan through each evaluation result to determine the actual reason for not being compliant if the [Compliant](eascomplianceresults_compliant.md) property is FALSE.

## -examples

## -see-also
