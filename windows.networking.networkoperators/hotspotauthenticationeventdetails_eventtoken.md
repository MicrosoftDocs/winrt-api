---
-api-id: P:Windows.Networking.NetworkOperators.HotspotAuthenticationEventDetails.EventToken
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string EventToken { get; }
-->

# Windows.Networking.NetworkOperators.HotspotAuthenticationEventDetails.EventToken

## -description
Gets a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) that uniquely identifies the authentication attempt for which this event was raised.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators. For more information, see [Mobile Broadband: ](https://docs.microsoft.com/windows-hardware/drivers/mobilebroadband/index) and [Windows 8 Integration for Wireless Hotspot Operators](https://docs.microsoft.com/windows-hardware/drivers/mobilebroadband/integrating-windows-with-wireless-hotspots).

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -property-value
A [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) that uniquely identifies the connection attempt.

## -remarks
The handler retrieving this token must call [TryGetAuthenticationContext](hotspotauthenticationcontext_trygetauthenticationcontext_1029198546.md) to retrieve the full context of this event.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
