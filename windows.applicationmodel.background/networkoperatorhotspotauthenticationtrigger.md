---
-api-id: T:Windows.ApplicationModel.Background.NetworkOperatorHotspotAuthenticationTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class NetworkOperatorHotspotAuthenticationTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger, Windows.ApplicationModel.Background.INetworkOperatorHotspotAuthenticationTrigger
-->

# Windows.ApplicationModel.Background.NetworkOperatorHotspotAuthenticationTrigger

## -description
Represents a mobile network operator hotspot authentication trigger.

> [!NOTE]
> An app can only instantiate this object and register for the hotspot authentication event after a WLAN profile has been provisioned that references this app to handle hotspot authentication. For more info, see [Windows 8 Integration for Wireless Hotspot Operators](/windows-hardware/drivers/mobilebroadband/integrating-windows-with-wireless-hotspots).

## -remarks

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples

## -see-also