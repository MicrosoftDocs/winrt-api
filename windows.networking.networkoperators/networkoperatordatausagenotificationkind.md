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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations), and [Mobile Broadband](https://msdn.microsoft.com/library/windows/hardware/hh852368.aspx).

## -enum-fields
### -field DataUsageProgress:0
Indicates that actionable progress in data usage has occurred.

## -remarks

## -see-also
[NetworkOperatorDataUsageTriggerDetails.NotificationKind](networkoperatordatausagetriggerdetails_notificationkind.md)

## -examples

## -capabilities
networkDataPlanProvisioning
