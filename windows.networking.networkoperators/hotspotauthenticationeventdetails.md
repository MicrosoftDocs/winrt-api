---
-api-id: T:Windows.Networking.NetworkOperators.HotspotAuthenticationEventDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class HotspotAuthenticationEventDetails : Windows.Networking.NetworkOperators.IHotspotAuthenticationEventDetails
-->

# Windows.Networking.NetworkOperators.HotspotAuthenticationEventDetails

## -description
Provides the content of the event that is raised for background task handlers for the hotspot authentication event.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators. For more information, see [Mobile Broadband: ](https://docs.microsoft.com/windows-hardware/drivers/mobilebroadband/index) and [Windows 8 Integration for Wireless Hotspot Operators](https://docs.microsoft.com/windows-hardware/drivers/mobilebroadband/integrating-windows-with-wireless-hotspots).

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -remarks
An application can register for the hotspot authentication event through the [NetworkOperatorHotspotAuthenticationTrigger](../windows.applicationmodel.background/networkoperatorhotspotauthenticationtrigger.md).

## -examples

## -see-also
[HotspotAuthenticationContext](HotspotAuthenticationContext.md), [Wi-Fi hotpost authentication sample](https://github.com/microsoft/VCSamples/tree/master/VC2012Samples/Windows%208%20samples/C%2B%2B/Windows%208%20app%20samples/Wi-Fi%20hotspot%20authentication%20sample%20(Windows%208))
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
