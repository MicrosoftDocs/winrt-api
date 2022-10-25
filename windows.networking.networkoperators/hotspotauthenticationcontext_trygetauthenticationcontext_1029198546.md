---
-api-id: M:Windows.Networking.NetworkOperators.HotspotAuthenticationContext.TryGetAuthenticationContext(System.String,Windows.Networking.NetworkOperators.HotspotAuthenticationContext@)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool TryGetAuthenticationContext(System.String evenToken, Windows.Networking.NetworkOperators.HotspotAuthenticationContext context)
-->

# Windows.Networking.NetworkOperators.HotspotAuthenticationContext.TryGetAuthenticationContext

## -description
Gets the context of an authentication attempt.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -parameters
### -param evenToken
The event token retrieved from the network operator hotspot authentication [event](hotspotauthenticationeventdetails.md). The token is a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) in string format.

### -param context
The network operator hotspot authentication context.

## -returns
If **true**, the authentication context was retrieved. The authentication context can only be retrieved if the calling application matches the application ID specified in the hotspot profile of the underlying WLAN connection and if the authentication hasn’t be completed by the corresponding context already or timed out.

## -remarks

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
