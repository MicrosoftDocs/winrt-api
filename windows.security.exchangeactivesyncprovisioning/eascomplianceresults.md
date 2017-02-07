---
-api-id: T:Windows.Security.ExchangeActiveSyncProvisioning.EasComplianceResults
-api-type: winrt class
---

<!-- Class syntax.
public class EasComplianceResults : Windows.Security.ExchangeActiveSyncProvisioning.IEasComplianceResults, Windows.Security.ExchangeActiveSyncProvisioning.IEasComplianceResults2
-->

# Windows.Security.ExchangeActiveSyncProvisioning.EasComplianceResults

## -description
> [!NOTE]
> [EasComplianceResults](eascomplianceresults.md) may be unavailable for releases after Windows 10.

Provides the mail app with the results of the evaluation of the EAS security policies. Every policy being evaluated returns an enumerated value indicating the evaluation results against the policy. The evaluations results are encapsulated in the [EasComplianceResults](eascomplianceresults.md) object for the caller app to retrieve.

## -remarks
An [EasComplianceResults](eascomplianceresults.md) object can be returned from a successful [CheckCompliance](easclientsecuritypolicy_checkcompliance.md) or [ApplyAsync](easclientsecuritypolicy_applyasync.md) call.

## -examples

## -see-also