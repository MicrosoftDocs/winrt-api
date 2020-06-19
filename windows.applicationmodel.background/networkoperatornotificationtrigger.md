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
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://msdn.microsoft.com/en-us/library/windows/apps/hh771042.aspx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](https://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

## -see-also
[HotspotAuthenticationEventDetails](../windows.networking.networkoperators/hotspotauthenticationeventdetails.md), [Wi-Fi hotpost authentication sample](https://code.msdn.microsoft.com/windowsapps/Wi-Fi-hotspot-authenticatio-943569eb), [Windows 8 Integration for Wireless Hotspot Operators](https://docs.microsoft.com/windows-hardware/drivers/mobilebroadband/integrating-windows-with-wireless-hotspots), [Mobile operator notification event technical details](/windows-hardware/drivers/mobilebroadband/mobile-operator-notification-event-technical-details?branch=live)
