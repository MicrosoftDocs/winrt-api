---
-api-id: T:Windows.ApplicationModel.Background.NetworkOperatorNotificationTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class NetworkOperatorNotificationTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger, Windows.ApplicationModel.Background.INetworkOperatorNotificationTrigger
-->

# Windows.ApplicationModel.Background.NetworkOperatorNotificationTrigger

## -description
Represents a mobile network operator notification trigger.

## -remarks
In preference to using **NetworkOperatorNotificationTrigger** and handling a **DataPlanThresholdReached** value for [NetworkOperatorEventMessageType](../windows.networking.networkoperators/networkoperatoreventmessagetype.md), you should use [NetworkOperatorDataUsageTrigger](networkoperatordatausagetrigger.md). You can register **NetworkOperatorDataUsageTrigger** by using standard background trigger idioms.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples

## -see-also
[HotspotAuthenticationEventDetails](../windows.networking.networkoperators/hotspotauthenticationeventdetails.md), [Wi-Fi hotpost authentication sample](/samples/microsoft/windows-universal-samples/hotspotauthentication/), [Windows 8 Integration for Wireless Hotspot Operators](/windows-hardware/drivers/mobilebroadband/integrating-windows-with-wireless-hotspots), [Mobile operator notification event technical details](/windows-hardware/drivers/mobilebroadband/mobile-operator-notification-event-technical-details)