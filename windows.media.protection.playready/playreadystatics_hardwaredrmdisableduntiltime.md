---
-api-id: P:Windows.Media.Protection.PlayReady.PlayReadyStatics.HardwareDRMDisabledUntilTime
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IReference<DateTime> HardwareDRMDisabledUntilTime { get; }
-->

# Windows.Media.Protection.PlayReady.PlayReadyStatics.HardwareDRMDisabledUntilTime

## -description
Queries the date and time at which hardware digital rights management (DRM) will be re-enabled after it was temporarily disabled on the system.

## -property-value
The date and time at which hardware digital rights management (DRM) will be re-enabled.  If it is not currently temporarily disabled, returns null.

## -remarks
When the CheckSupportedHardware property returns false when querying the HardwareDRM feature, it is possible that this occurs because the feature was temporarily disabled due to a system component requiring an update, for example, a graphics driver.  This property indicates whether this occurred and, if so, when it will automatically be re-enabled.  If the system component has not been updated, it will automatically get re-disabled and both this property and the HardwareDRMDisabledAtTime property will begin returning updated values.

## -examples

## -see-also
[HardwareDRMDisabledAtTime](playreadystatics_hardwaredrmdisabledattime.md), [ResetHardwareDRMDisabled](playreadystatics_resethardwaredrmdisabled_231965222.md)
