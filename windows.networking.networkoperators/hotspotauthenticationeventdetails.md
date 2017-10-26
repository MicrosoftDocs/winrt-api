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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators. For more information, see [Mobile Broadband: ](http://msdn.microsoft.com/library/windows/hardware/hh852368.aspx) and [Windows 8 Integration for Wireless Hotspot Operators](http://msdn.microsoft.com/library/windows/hardware/hh770516.aspx).

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations). 

## -remarks
An application can register for the hotspot authentication event through the [NetworkOperatorHotspotAuthenticationTrigger](../windows.applicationmodel.background/networkoperatorhotspotauthenticationtrigger.md).

## -examples

## -see-also
[HotspotAuthenticationContext](HotspotAuthenticationContext.md), [Wi-Fi hotpost authentication sample](http://code.msdn.microsoft.com/windowsapps/Wi-Fi-hotspot-authenticatio-943569eb)
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
