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

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

## -see-also
[HotspotAuthenticationEventDetails](../windows.networking.networkoperators/hotspotauthenticationeventdetails.md), [Wi-Fi hotpost authentication sample](https://code.msdn.microsoft.com/windowsapps/Wi-Fi-hotspot-authenticatio-943569eb), [Windows 8 Integration for Wireless Hotspot Operators](https://msdn.microsoft.com/library/windows/hardware/hh770516.aspx), [Mobile operator notification event technical details](/windows-hardware/drivers/mobilebroadband/mobile-operator-notification-event-technical-details?branch=live)
