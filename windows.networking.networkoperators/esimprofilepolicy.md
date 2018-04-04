---
-api-id: T:Windows.Networking.NetworkOperators.ESimProfilePolicy
-api-type: winrt class
---

<!-- Class syntax.
public class ESimProfilePolicy 
-->

# Windows.Networking.NetworkOperators.ESimProfilePolicy

## -description
A class that represents the policy for an eSIM profile.

> [!NOTE]
> To use this API you will need to contact Microsoft to request the restricted capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations?branch=live).

## -remarks
The policy for an eSIM profile includes PPR1 (Profile Policy Rule) and PPR2 as defined in [SGP.22](https://www.gsma.com/newsroom/all-documents/sgp-22-v2-2-technical-specification) (the published eSIM standard). PPR1 (can disable) and PPR2 (can delete) are defined by the eSIM standard to be present in eSIM profiles. The policy also includes whether the eSIM profile is managed by an enterprise.

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe