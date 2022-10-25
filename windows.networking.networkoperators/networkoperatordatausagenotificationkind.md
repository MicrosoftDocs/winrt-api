---
-api-id: T:Windows.Networking.NetworkOperators.NetworkOperatorDataUsageNotificationKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum NetworkOperatorDataUsageNotificationKind : int 
-->

# Windows.Networking.NetworkOperators.NetworkOperatorDataUsageNotificationKind

## -description
Defines constants that specify the kind of data usage change that activated a [NetworkOperatorDataUsageTrigger](../windows.applicationmodel.background/networkoperatordatausagetrigger.md).

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic, and [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -enum-fields
### -field DataUsageProgress:0
Indicates that actionable progress in data usage has occurred.

## -remarks

## -see-also
[NetworkOperatorDataUsageTriggerDetails.NotificationKind](networkoperatordatausagetriggerdetails_notificationkind.md)

## -examples

## -capabilities
networkDataPlanProvisioning
