---
-api-id: T:Windows.ApplicationModel.Background.MobileBroadbandRadioStateChangeTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class MobileBroadbandRadioStateChangeTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger
-->

# Windows.ApplicationModel.Background.MobileBroadbandRadioStateChangeTrigger

## -description
Represents a trigger that indicates when mobile broadband radio state has changed. For example, this trigger activates when a mobile device transitions to or from airplane mode.

This functionality is available only to mobile operator apps and UWP app given privileged access by mobile network operators. For more information, see [Mobile broadband](/windows-hardware/drivers/mobilebroadband/index).

## -remarks
When this trigger activates, the [IBackgroundTaskInstance.TriggerDetails](ibackgroundtaskinstance_triggerdetails.md) for the background task is a [MobileBroadbandRadioStateChangeTriggerDetails](../windows.networking.networkoperators/mobilebroadbandradiostatechangetriggerdetails.md) instance.

## -examples

## -see-also
[IBackgroundTrigger](ibackgroundtrigger.md)