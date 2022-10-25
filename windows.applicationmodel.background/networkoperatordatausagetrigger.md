---
-api-id: T:Windows.ApplicationModel.Background.NetworkOperatorDataUsageTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class NetworkOperatorDataUsageTrigger : IBackgroundTrigger
-->

# Windows.ApplicationModel.Background.NetworkOperatorDataUsageTrigger

## -description
Represents a trigger that launches a background task when the local data counters estimate that usage (bytes sent and received) on the mobile broadband interface has changed by an actionable threshold.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic, and [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -remarks
The trigger activates when the local data counters estimate that usage has changed by 5% since the last occurrence, except in these cases.
1. If you're connected to a home network (non-roaming) and your data plan limit hasn't been specified, then this trigger activates at every 100 MB of local data usage.
2. If you're connected to a roaming network, then your data plan limit doesn't apply and this trigger actives at every 5 MB of local data usage.

When this trigger activates, the [IBackgroundTaskInstance.TriggerDetails](ibackgroundtaskinstance_triggerdetails.md) for the background task is a [NetworkOperatorDataUsageTriggerDetails](../windows.networking.networkoperators/networkoperatordatausagetriggerdetails.md) instance.

**NetworkOperatorDataUsageTrigger** is the replacement for using [NetworkOperatorNotificationTrigger](networkoperatornotificationtrigger.md) and handling a **DataPlanThresholdReached** value for [NetworkOperatorEventMessageType](../windows.networking.networkoperators/networkoperatoreventmessagetype.md). You can register **NetworkOperatorDataUsageTrigger** by using standard background trigger idioms (see [Register a background task](/windows/uwp/launch-resume/register-a-background-task)), and it has the same prerequisites as **NetworkOperatorNotificationTrigger**. Your mobile operator app still needs to provision a data plan and set [DataUsageInMobileOperatorNotificationEnabled](/uwp/schemas/mobilebroadbandschema/plans/element-datausageinmobileoperatornotificationenabled) to `true`. See [Mobile operator notification event technical details](/windows-hardware/drivers/mobilebroadband/mobile-operator-notification-event-technical-details) for more details.

## -see-also
[IBackgroundTrigger](ibackgroundtrigger.md)

## -examples

## -capabilities
networkDataPlanProvisioning
