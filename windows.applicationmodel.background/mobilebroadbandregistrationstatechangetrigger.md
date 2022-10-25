---
-api-id: T:Windows.ApplicationModel.Background.MobileBroadbandRegistrationStateChangeTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class MobileBroadbandRegistrationStateChangeTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger
-->

# Windows.ApplicationModel.Background.MobileBroadbandRegistrationStateChangeTrigger

## -description
Represents a trigger that indicates when mobile broadband registration state has changed. For example, this trigger activates when a mobile device transitions to or from Roaming.

This functionality is available only to mobile operator apps and UWP app given privileged access by mobile network operators. For more information, see [Mobile broadband](/windows-hardware/drivers/mobilebroadband/index).

## -remarks
When this trigger activates, the [IBackgroundTaskInstance.TriggerDetails](ibackgroundtaskinstance_triggerdetails.md) for the background task is a [MobileBroadbandNetworkRegistrationStateChangeTriggerDetails](../windows.networking.networkoperators/mobilebroadbandnetworkregistrationstatechangetriggerdetails.md) instance.

## -examples

## -see-also
[IBackgroundTrigger](ibackgroundtrigger.md)