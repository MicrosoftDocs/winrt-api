---
-api-id: M:Windows.Media.Protection.PlayReady.PlayReadyStatics.ResetHardwareDRMDisabled
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void PlayReadyStatics.ResetHardwareDRMDisabled()
-->

# Windows.Media.Protection.PlayReady.PlayReadyStatics.ResetHardwareDRMDisabled

## -description
Explicitly resets any temporary disablement of hardware digital rights management (DRM), if any.

## -remarks
When the CheckSupportedHardware property returns false when querying the HardwareDRM feature, it is possible that this occurs because the feature was temporarily disabled due to a system component requiring an update, for example, a graphics driver.  This method explicitly resets the temporary disablement state.  An application could call this method when it is able to determine that a system component which may allow HardwareDRM to succeed has been updated in order to attempt hardware DRM before the date and time returned by HardwareDRMDisabledUntilTime.  If the system component has not been updated, it will automatically get re-disabled and the HardwareDRMDisabledAtTime and HardwareDRMDisabledUntilTime properties will begin returning updated values.  If it is not currently temporarily disabled, this method performs no action.

## -examples

## -see-also
[HardwareDRMDisabledAtTime](playreadystatics_hardwaredrmdisabledattime.md), [HardwareDRMDisabledUntilTime](playreadystatics_hardwaredrmdisableduntiltime.md)
