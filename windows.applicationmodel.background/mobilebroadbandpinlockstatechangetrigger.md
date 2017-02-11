---
-api-id: T:Windows.ApplicationModel.Background.MobileBroadbandPinLockStateChangeTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class MobileBroadbandPinLockStateChangeTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger
-->

# Windows.ApplicationModel.Background.MobileBroadbandPinLockStateChangeTrigger

## -description
Represents a trigger that indicates when the SIM PIN lock state has changed.

This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators. For more information, see [Mobile Broadband: ](http://msdn.microsoft.com/library/windows/hardware/hh852368.aspx).

## -remarks
When this trigger activates, the [IBackgroundTaskInstance.TriggerDetails](ibackgroundtaskinstance_triggerdetails.md) for the background task is a [MobileBroadbandPinLockStateChangeTriggerDetails](../windows.networking.networkoperators/mobilebroadbandpinlockstatechangetriggerdetails.md) instance.

## -examples

## -see-also
[IBackgroundTrigger](ibackgroundtrigger.md)