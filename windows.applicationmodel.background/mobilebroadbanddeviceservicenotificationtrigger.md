---
-api-id: T:Windows.ApplicationModel.Background.MobileBroadbandDeviceServiceNotificationTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class MobileBroadbandDeviceServiceNotificationTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger
-->

# Windows.ApplicationModel.Background.MobileBroadbandDeviceServiceNotificationTrigger

## -description
Represents a trigger that activates when the network sends SIM tool commands. Apps receiving this notification then process the SIM tool commands.

This functionality is available only to mobile operator apps and UWP app given privileged access by mobile network operators. For more information, see [Mobile broadband](/windows-hardware/drivers/mobilebroadband/index).

## -remarks
When this trigger activates, the [IBackgroundTaskInstance.TriggerDetails](ibackgroundtaskinstance_triggerdetails.md) for the background task is a [MobileBroadbandDeviceServiceTriggerDetails](../windows.networking.networkoperators/mobilebroadbanddeviceservicetriggerdetails.md) instance.

## -examples

## -see-also
[IBackgroundTrigger](ibackgroundtrigger.md)