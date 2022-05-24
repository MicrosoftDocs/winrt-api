---
-api-id: P:Windows.Media.Protection.PlayReady.PlayReadyStatics.HardwareDRMDisabledAtTime
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IReference<DateTime> HardwareDRMDisabledAtTime { get; }
-->

# Windows.Media.Protection.PlayReady.PlayReadyStatics.HardwareDRMDisabledAtTime

## -description
Queries the date and time at which hardware digital rights management (DRM) was temporarily disabled on the system.

## -property-value
The date and time at which hardware digital rights management (DRM) was temporarily disabled.  If it is not currently temporarily disabled, returns null.

## -remarks
When the CheckSupportedHardware property returns false when querying the HardwareDRM feature, it is possible that this occurs because the feature was temporarily disabled due to a system component requiring an update, for example, a graphics driver.  This property indicates whether this occurred and, if so, when it occurred.

## -examples

## -see-also
[HardwareDRMDisabledUntilTime](playreadystatics_hardwaredrmdisableduntiltime.md), [ResetHardwareDRMDisabled](playreadystatics_resethardwaredrmdisabled_231965222.md)
